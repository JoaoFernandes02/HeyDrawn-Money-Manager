using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Control;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
using FireSharp;
using System.IO;

namespace HeyDrawn_Money_Manager
{
    public class Dados
    {
        #region Propriedades
        #region Tipos
        public List<string> TiposCompra
        {
            get
            {
                var getTiposCompras = client.Get("/TiposCompra");
                var resultado = getTiposCompras.ResultAs<List<string>>();
                if (resultado == null) resultado = new List<string>();
                return resultado;
            }
        }
        public List<string> TiposVenda
        {
            get
            {
                var getTiposVenda = client.Get("/TiposVenda");
                var resultado = getTiposVenda.ResultAs<List<string>>();
                if (resultado == null) resultado = new List<string>();
                return resultado;
            }
        }
        public List<string> TiposStock
        {
            get
            {
                var getTiposStock = client.Get("/TiposStock");
                var resultado = getTiposStock.ResultAs<List<string>>();
                if (resultado == null) resultado = new List<string>();
                return resultado;
            }
        }
        #endregion

        #region Compras e Vendas
        public ListaVendas Vendas
        {
            get
            {
                var getVendas = client.Get("/Vendas");
                var resultado = getVendas.ResultAs<ListaVendas>();
                if (resultado == null) resultado = new ListaVendas();
                return resultado;
            }
        }
        public ListaCompras Compras
        {
            get
            {
                var getCompras = client.Get("/Compras");
                var resultado = getCompras.ResultAs<ListaCompras>();
                if (resultado == null) resultado = new ListaCompras();
                return resultado;
            }
        }
        public double Lucro
        {
            get {
                double lucro = 0;

                lucro += Vendas.GetLucro();

                lucro -= Compras.GetGastos();

                lucro -= Stock.GetGastos();

                return lucro;
            }
        }

        public SalesInfo MaisVendido {
            get
            {
                if(Vendas.Count == 0) return new SalesInfo() { Nome = "Ainda não foi vendido nada", Valor = 0 };

                var result = Vendas.GroupBy(venda => venda.Nome)
                    .Select(maisVendido => new { nome = maisVendido.Key, total = maisVendido.Count() })
                    .OrderByDescending(maisVendido => maisVendido.total).First();

                return new SalesInfo() { Nome = result.nome, Valor = result.total };
            }
        }

        public SalesInfo MaisLucrado {
            get
            {
                if (Vendas.Count == 0) return new SalesInfo() { Nome = "Ainda não foi vendido nada", Valor = 0 };

                var result = Vendas.GroupBy(venda => venda.Nome)
                    .Select(maisLucrado => new { nome = maisLucrado.Key, valorTotal = maisLucrado.Sum(venda => venda.Lucro) })
                    .OrderByDescending(maisLucrado => maisLucrado.valorTotal).First();

                return new SalesInfo() { Nome = result.nome, Valor = result.valorTotal };
            }
        }
        #endregion

        #region Planos
        public ListaPlanos Planos
        {
            get
            {
                var getPlanos = client.Get("/Planos");
                var resultado = getPlanos.ResultAs<ListaPlanos>();
                if (resultado == null) resultado = new ListaPlanos();
                return resultado;
            }
        }
        public ListaPlanos PlanosTlm
        {
            get
            {
                var getPlanosTlm = client.Get("/PlanosTlm");
                var resultado = getPlanosTlm.ResultAs<ListaPlanos>();
                if (resultado == null) resultado = new ListaPlanos();
                return resultado;
            }
        }

        public string Apontamentos
        {
            get
            {
                var getApontamentos = client.Get("/Apontamentos");
                var resultado = getApontamentos.ResultAs<string>();
                if (resultado == null) resultado = "";
                return resultado;
            }
        }
        #endregion

        #region Stock
        public ListaStock Stock
        {
            get
            {
                var getStock = client.Get("/Stock");
                var resultado = getStock.ResultAs<ListaStock>();
                if (resultado == null) resultado = new ListaStock();
                return resultado;
            }
        }
        #endregion
        #endregion

        //Config para conectar à base de dados
        

        //Declaração do cliente
        private FirebaseClient client;

        #region Construtores
        public Dados()
        {
            //Caminho do ficheiro que tem a config da db
            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var filePath = Path.Combine(path, "heydrawnmanager.cfg");
            //Conecta à base de dados
            try
            {
                string[] fcfgData = File.ReadAllLines(filePath);

                IFirebaseConfig fcfg = new FirebaseConfig()
                {
                    AuthSecret = fcfgData[1],
                    BasePath = fcfgData[0]
                };

                client = new FirebaseClient(fcfg);
            }
            catch
            {
                MessageBox.Show("Houve um problema com a internet ou com os dados de acesso à DB!");
            }


            List<string> tiposCompraSemNull = new List<string>();
            foreach(string tipoCompra in TiposCompra) if(tipoCompra != null) tiposCompraSemNull.Add(tipoCompra);
            client.Set("/TiposCompra", tiposCompraSemNull);

            List<string> tiposVendaSemNull = new List<string>();
            foreach (string tipoVenda in TiposVenda) if (tipoVenda != null) tiposVendaSemNull.Add(tipoVenda);
            client.Set("/TiposVenda", tiposVendaSemNull);

            List<string> tiposStockSemNull = new List<string>();
            foreach (string tipoStock in TiposStock) if (tipoStock != null) tiposStockSemNull.Add(tipoStock);
            client.Set("/TiposStock", tiposStockSemNull);

            List<ProdutoVenda> vendasSemNull = new List<ProdutoVenda>();
            foreach (ProdutoVenda produtoVenda in Vendas) if (produtoVenda != null)
                {
                    vendasSemNull.Add(produtoVenda);
                    produtoVenda.ID = vendasSemNull.IndexOf(vendasSemNull.Last());
                }
            client.Set("/Vendas", vendasSemNull);

            List<ProdutoCompra> comprasSemNull = new List<ProdutoCompra>();
            foreach (ProdutoCompra produtoCompra in Compras) if (produtoCompra != null)
                {
                    comprasSemNull.Add(produtoCompra);
                    produtoCompra.ID = comprasSemNull.IndexOf(comprasSemNull.Last());
                }
            client.Set("/Compras", comprasSemNull);

            List<ProdutoStock> stockSemNull = new List<ProdutoStock>();
            foreach (ProdutoStock produtoStock in Stock) if (produtoStock != null)
                {
                    stockSemNull.Add(produtoStock);
                    produtoStock.ID = stockSemNull.IndexOf(stockSemNull.Last());
                }
            client.Set("/Stock", stockSemNull);

            List<Plano> planosSemNull = new List<Plano>();
            foreach (Plano plano in Planos) if (plano != null)
                {
                    planosSemNull.Add(plano);
                    plano.ID = planosSemNull.IndexOf(planosSemNull.Last());
                }
            client.Set("/Planos", planosSemNull);

            List<Plano> planosTlmSemNull = new List<Plano>();
            foreach (Plano planoTlm in PlanosTlm) if (planoTlm != null)
                {
                    planosTlmSemNull.Add(planoTlm);
                    planoTlm.ID = planosTlmSemNull.IndexOf(planosTlmSemNull.Last());
                }
            client.Set("/PlanosTlm", planosTlmSemNull);
        }
        #endregion

        #region Vendas e Compras
        public void addVenda(ProdutoVenda produto)
        {
            produto.ID = Vendas.Count;
            client.Set("Vendas/" + produto.ID, produto);
        }
        public void addCompra(ProdutoCompra produto)
        {
            produto.ID = Compras.Count;
            client.Set("Compras/" + produto.ID, produto);
        }
        #endregion

        #region Planos

        public void addPlano(string tipoPlano, Plano plano)
        {
            if(tipoPlano == "planoGeral")
            {
                plano.ID = Planos.Count;
                client.Set("/Planos/" + plano.ID, plano);
            }
            else if(tipoPlano == "planoTlm")
            {
                plano.ID = PlanosTlm.Count;
                client.Set("/PlanosTlm/" + plano.ID, plano);
            }
        }

        public void removePlano(string nomePlano)
        {
            string id = nomePlano.Split(' ')[0];
            client.Delete("/Planos/" + id);

            List<Plano> planosSemNull = new List<Plano>();
            foreach (Plano plano in Planos) if (plano != null)
                {
                    planosSemNull.Add(plano);
                    plano.ID = planosSemNull.IndexOf(planosSemNull.Last());
                }
            client.Set("/Planos", planosSemNull);
        }

        public void removePlanoTlm(string nomePlano)
        {
            string id = nomePlano.Split(' ')[0];
            client.Delete("/PlanosTlm/" + id);

            List<Plano> planosTlmSemNull = new List<Plano>();
            foreach (Plano planoTlm in PlanosTlm) if (planoTlm != null)
                {
                    planosTlmSemNull.Add(planoTlm);
                    planoTlm.ID = planosTlmSemNull.IndexOf(planosTlmSemNull.Last());
                }
            client.Set("/PlanosTlm", planosTlmSemNull);
        }

        public Plano editEstadoPlano(string nomePlano, string path, int nextEstado)
        {
            string id = nomePlano.Split(' ')[0];
            var query = client.Get("/" + path + "/" + id);
            Plano plano = query.ResultAs<Plano>();

            plano.UpdateEstado(nextEstado);

            client.Update("/" + path + "/" + id, plano);

            return plano;
        }
        #endregion
        #region Stock

        public void addStock(ProdutoStock produto) {
            produto.ID = Stock.Count;
            client.Set("Stock/" + produto.ID, produto);
        }

        public ProdutoStock FindStock(string nomeStock)
        {
            foreach(ProdutoStock produto in this.Stock)
            {
                if(produto.Nome == nomeStock)
                return produto;
            }

            return null;
        }

        public void RemoverStock(ProdutoStock produto)
        {
            produto.RemoverStock();
            client.Update("/Stock/" + produto.ID, produto);
        }
        public void RefreshStock(DataGridView stockDatagrid)
        {
            stockDatagrid.Rows.Clear();

            foreach(ProdutoStock produto in this.Stock)
            {
                if (produto.Quantidade <= 0) client.Delete("/Stock/" + produto.ID);
            }

            stockDatagrid.Rows.AddRange(Stock.GetRows());
        }
        #endregion

        #region Tipos
        public void SetTipo(List<string> lista, string tipo)
        {
            client.Set(tipo, lista);
        }
        #endregion

        #region Apontamentos

        public void SaveApontamentos(string txt)
        {
            client.Set("Apontamentos", txt);
        }
        #endregion
    }
}