﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HeyDrawn_Money_Manager
{
    public partial class Form1 : Form
    {
        Dados dados = new Dados();
        public Form1()
        {
            InitializeComponent();
        }

        #region Janela
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void iconButton_Fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButton_Minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region Form
        
        private void Form1_Load(object sender, EventArgs e)
        {
            definicoes_btnReset_Click(null, null);

            LoadData();
            atualizarLabels();

            vendas_comboBoxTipos.Items.Add("Custom");
            compras_comboBoxTipos.Items.Add("Custom");

            if (dados.TiposVenda.Count > 0)
                foreach (string str in dados.TiposVenda)
                    if (str != null)
                        vendas_comboBoxTipos.Items.Add(str);

            if (dados.TiposCompra.Count > 0)
                foreach (string str in dados.TiposCompra)
                    if (str != null)
                        compras_comboBoxTipos.Items.Add(str);

            if (dados.TiposStock.Count > 0)
                foreach (string str in dados.TiposStock)
                    if (str != null)
                        stock_comboBoxMaterial.Items.Add(str);
        }

        public void LoadData()
        {
            table_Vendas.Rows.Clear();
            table_Vendas.Rows.AddRange(dados.Vendas.GetRows());

            table_Compras.Rows.Clear();
            table_Compras.Rows.AddRange(dados.Compras.GetRows());

            foreach (Plano plano in dados.Planos)
            {
                ((ListBox)tabPage_Planos.Controls[plano.NomeLista]).Items.Add(plano.Descricao);
            }

            foreach (Plano plano in dados.PlanosTlm)
            {
                ((ListBox)tabPage_PlanosTlm.Controls[plano.NomeLista]).Items.Add(plano.Descricao);
            }

            table_Stock.Rows.Clear();
            table_Stock.Rows.AddRange(dados.Stock.GetRows());
        }
        private void ChangeTab(object sender, EventArgs e)
        {
            string tab = ((Button)sender).Tag.ToString();
            form_Tab.SelectedTab = (TabPage)form_Tab.Controls[tab];

            foreach (Control control in panel_Menu.Controls)
            {
                if (control is FontAwesome.Sharp.IconButton)
                {
                    control.BackColor = Color.White;
                }
            }

            ((Button)sender).BackColor = Color.LightGray;
        }
        #endregion

        #region Funções Ajuda
        private bool HasText(List<Control> controls)
        {
            foreach (Control control in controls)
                if (string.IsNullOrEmpty(control.Text)) return false;
            return true;
        }
        private void clearText(Control tab)
        {
            foreach (Control control in tab.Controls)
            {
                if (control is TextBox) control.Text = "";
                if (control is ComboBox) ((ComboBox)control).SelectedIndex = -1;
                if (control is CheckBox) ((CheckBox)control).Checked = false;
                if (control is NumericUpDown) ((NumericUpDown)control).Value = 0;
            }
        }
        #endregion

        #region Checkboxes
        private void check_EnvioMaterial_CheckedChanged(object sender, EventArgs e)
        {
            // esconde ou mostra caixas de texto
            vendas_txtEnvioMaterial.Visible = vendas_checkEnvioMaterial.Checked;

            //esconde ou mostra checkboxes
            vendas_checkEnvioDividido.Visible = vendas_checkEnvioMaterial.Checked;

            //limpa o texto
            vendas_txtEnvioMaterial.Value = 0;
            vendas_txtEnvioDividido.Value = 0;
            vendas_checkEnvioDividido.Checked = false;
        }
        private void check_EnvioDividido_CheckedChanged(object sender, EventArgs e)
        {
            vendas_txtEnvioDividido.Visible = vendas_checkEnvioDividido.Checked;
            vendas_txtEnvioDividido.Text = "";
        }
        private void compras_checkEnvioDividido_CheckedChanged(object sender, EventArgs e)
        {
            // esconde ou mostra caixas de texto
            compras_txtEnvioDividido.Visible = compras_checkEnvioDividido.Checked;

            //limpa o texto
            compras_txtEnvioDividido.Text = "";
        }
        private void stock_checkEnvioDividido_CheckedChanged(object sender, EventArgs e)
        {
            stock_txtEnvioDividido.Visible = stock_checkEnvioDividido.Checked;
            stock_txtEnvioDividido.Text = "";
        }
        #endregion

        #region Compras e Vendas
        private void vendas_btnConfirmar_Click(object sender, EventArgs e)
        {
            //Controlos que não podem ter texto vazio
            List<Control> controls = new List<Control>(){ vendas_comboBoxTipos, vendas_txtDescricao, vendas_txtPreco, vendas_txtEnvio };

            //Caso as opções estejam selecionadas adiciona os respetivos
            //controlos à lista de controlos que não podem tar vazios
            
                //Custo de envio de material
                if (vendas_checkEnvioMaterial.Checked) controls.Add(vendas_txtEnvioMaterial);
                
                //Envio dividido de material
                if (vendas_checkEnvioDividido.Checked) controls.Add(vendas_txtEnvioDividido);
                
                //Tipo de produto custom
                if (vendas_comboBoxTipos.SelectedIndex == 0) controls.Add(vendas_txtTipo);

            //Verifica se todos os controlos têm texto
            if (!HasText(controls))
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            //Preço do produto
            double preco = (double)vendas_txtPreco.Value;

            //Preço do envio
            double envio = (double)vendas_txtEnvio.Value;

            //Custo dos materiais (sem envio)
            double custoMateriais = (double)vendas_txtMaterial.Value;

            //Envio total dos materiais
            double envioMateriaisTotal = (vendas_checkEnvioMaterial.Checked) ? (double)vendas_txtEnvioMaterial.Value : 0;
            
            //Quantiade de produtos (materiais) dentro do envio
            int envioDividido = (vendas_checkEnvioDividido.Checked) ? (int)vendas_txtEnvioDividido.Value : 1;

            //Nome do produto
            String nome = (vendas_comboBoxTipos.SelectedIndex == 0)?vendas_txtTipo.Text:vendas_comboBoxTipos.Text;
            
            //Descrição do produto
            String descricao = vendas_txtDescricao.Text;
            
            //Envio do material
            double envioMaterial = envioMateriaisTotal / envioDividido;
            
            //Custo total do material
            double custoMaterialTotal = custoMateriais + envioMaterial;

            //Cria o produto de venda
            ProdutoVenda venda = new ProdutoVenda(nome, descricao, preco, envio, custoMaterialTotal);
            
            //Adiciona o produto de venda aos dados
            dados.addVenda(venda);
            
            //Cria um produto de material caso
            //não se esteja a usar o stock e exista custo de material
            if (custoMaterialTotal > 0 && !vendas_usarStock.Checked)
            {
                ProdutoCompra material = new ProdutoCompra("Materiais para " + nome, descricao, custoMateriais, envioMaterial);
                dados.addCompra(material);
                table_Compras.Rows.Add(material.GetRow());
            }
            //Remove 1 unidade de stock caso esteja a ser usado
            else if(vendas_usarStock.Checked)
            {
                dados.RemoverStock(dados.FindStock(vendas_comboBoxTipos.Text));
                dados.RefreshStock(table_Stock);
            }

            //Atualiza as labels, remove o texto dos controlos
            //e adiciona o produto à tabela
            atualizarLabels();
            clearText(tabPage_Vendas);
            table_Vendas.Rows.Add(venda.GetRow());

        }
        private void compras_btnConfirmar_Click(object sender, EventArgs e)
        {
            //Controlos que não podem ter texto vazio
            List<Control> controls = new List<Control>() { compras_comboBoxTipos, compras_txtDescricao, compras_txtPreco, compras_txtEnvio };

            //Caso as opções estejam selecionadas adiciona os respetivos
            //controlos à lista de controlos que não podem tar vazios

            //Envio dividido de material
            if (compras_checkEnvioDividido.Checked) controls.Add(compras_txtEnvioDividido);

            //Tipo de produto custom
            if (compras_comboBoxTipos.SelectedIndex == 0) controls.Add(compras_txtTipo);

            //Verifica se todos os controlos têm texto
            if (!HasText(controls))
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            //Preço do produto
            double preco = (double)compras_txtPreco.Value;

            //Preço do envio total
            double envioTotal = (double)compras_txtEnvio.Value;

            //Quantiade de produtos (materiais) dentro do envio
            int envioDividido = (compras_checkEnvioDividido.Checked) ? (int)compras_txtEnvioDividido.Value : 1;

            //Preço do envio
            double envio = envioTotal / envioDividido;

            //Nome do produto
            String nome = (compras_comboBoxTipos.SelectedIndex == 0) ? compras_txtTipo.Text : compras_comboBoxTipos.Text;

            //Descrição do produto
            String descricao = compras_txtDescricao.Text;

            //Cria o produto de venda
            ProdutoCompra compra = new ProdutoCompra(nome, descricao, preco, envio);

            //Adiciona o produto de venda aos dados
            dados.addCompra(compra);

            //Atualiza as labels, remove o texto dos controlos
            //e adiciona o produto à tabela
            atualizarLabels();
            clearText(tabPage_Compras);
            table_Compras.Rows.Add(compra.GetRow());
        }
        private void atualizarLabels()
        {
            double lucro = dados.Lucro;
            int vendasCount = dados.Vendas.Count;
            double maisVendidoValor = dados.MaisVendido.Valor;
            string maisVendidoNome = dados.MaisVendido.Nome;
            double maisLucradoValor = dados.MaisLucrado.Valor;
            string maisLucradoNome = dados.MaisVendido.Nome;

            vendas_txtLucro.Text = lucro.ToString() + "€";
            compras_txtLucro.Text = lucro.ToString() + "€";
            if (lucro > 0)
            {
                vendas_txtLucro.ForeColor = Color.Green;
                compras_txtLucro.ForeColor = Color.Green;
            }
            else if (lucro < 0)
            {
                vendas_txtLucro.ForeColor = Color.Red;
                compras_txtLucro.ForeColor = Color.Red;
            }
            else
            {
                vendas_txtLucro.ForeColor = Color.Orange;
                compras_txtLucro.ForeColor = Color.Orange;
            }

            if (vendasCount == 0) return;


            vendas_ProdutoMaisVendido.Text = "Produto Mais Vendido: " + maisVendidoNome + " (" + maisVendidoValor + ")";
            vendas_ProdutoMaisLucrado.Text = "Produto Mais Lucrado: " + maisLucradoNome + " (" + maisLucradoValor + "€)";

            compras_ProdutoMaisVendido.Text = "Produto Mais Vendido: " + maisVendidoNome + " (" + maisVendidoValor + ")";
            compras_ProdutoMaisLucrado.Text = "Produto Mais Lucrado: " + maisLucradoNome + " (" + maisLucradoValor + "€)";
        }
        private void vendas_comboBoxTipos_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            string tag = comboBox.Tag.ToString();
            TextBox textBox = null;
            switch (tag)
            {
                case "vendas_txtTipo":
                    textBox = (TextBox)tabPage_Vendas.Controls[tag];
                    break;

                case "compras_txtTipo":
                    textBox = (TextBox)tabPage_Compras.Controls[tag];
                    break;
            }

            textBox.Text = "";
            bool custom = (comboBox.SelectedIndex == 0);
            comboBox.Width = (custom) ? 230 : 404;
            textBox.Visible = custom;
        }
        private void vendas_usarStock_CheckedChanged(object sender, EventArgs e)
        {
            vendas_txtMaterial.ReadOnly = vendas_usarStock.Checked;
            vendas_checkEnvioMaterial.Visible = !vendas_usarStock.Checked;
            vendas_checkEnvioMaterial.Checked = false;
            vendas_txtMaterial.Text = "";
            vendas_quantidadeStock.Text = "";

            ProdutoStock stock = dados.FindStock(vendas_comboBoxTipos.Text);

            if (stock == null && vendas_usarStock.Checked)
            {
                vendas_usarStock.Checked = false;
                MessageBox.Show("Não existe stock para o produto selecionado");
                return;
            }
            else if (!vendas_usarStock.Checked)
            {
                return;
            }

            vendas_txtMaterial.Text = stock.PrecoUnidade.ToString();
            vendas_quantidadeStock.Text = "Faltam " + stock.Quantidade + " unidades.";
        }
        #endregion

        #region Planos e PlanosTlm
        private void moverItemListboxPlanos(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection sourceItems = null;

            List<ListBox> listBoxes = new List<ListBox>();

            foreach(Control control in tabPage_Planos.Controls)
            {
                if (control is ListBox) listBoxes.Add((ListBox)control);
            }

            ListBox source = null;
            ListBox destiny;

            int nextListbox = int.Parse(((Control)sender).Tag.ToString());

            int numeroListbox = 0;

            foreach (ListBox listBox in listBoxes)
            {
                if(listBox.SelectedItem != null)
                {
                    source = listBox;
                    sourceItems = listBox.SelectedItems;
                    numeroListbox = int.Parse(listBox.Name.ToString()[12].ToString()) + nextListbox;
                }
            }

            destiny = (ListBox)tabPage_Planos.Controls["planos_Lista" + numeroListbox.ToString()];

            if (sourceItems == null) return;
            if (numeroListbox < 1 || numeroListbox > listBoxes.Count) return;

            foreach (var item in sourceItems)
            {
                destiny.Items.Add(item);
            }
            while (source.SelectedItems.Count > 0)
            {
                source.Items.Remove(source.SelectedItems[0]);
            }
        }
        private void moverItemListboxPlanosTlm(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection sourceItems = null;

            List<ListBox> listBoxes = new List<ListBox>();

            foreach (Control control in tabPage_PlanosTlm.Controls)
            {
                if (control is ListBox) listBoxes.Add((ListBox)control);
            }

            ListBox source = null;
            ListBox destiny;

            int nextListbox = int.Parse(((Control)sender).Tag.ToString());

            int numeroListbox = 0;

            foreach (ListBox listBox in listBoxes)
            {
                if (listBox.SelectedItem != null)
                {
                    source = listBox;
                    sourceItems = listBox.SelectedItems;
                    numeroListbox = int.Parse(listBox.Name.ToString()[15].ToString()) + nextListbox;
                }
            }

            destiny = (ListBox)tabPage_PlanosTlm.Controls["planosTlm_Lista" + numeroListbox.ToString()];

            if (sourceItems == null) return;
            if (numeroListbox < 1 || numeroListbox > listBoxes.Count) return;

            foreach (var item in sourceItems)
            {
                destiny.Items.Add(item);
            }
            while (source.SelectedItems.Count > 0)
            {
                source.Items.Remove(source.SelectedItems[0]);
            }
        }
        private void clearSelectedItem(object sender, EventArgs e)
        {
            ((ListBox)sender).Tag = "Selecionado";

            ListBox[] listBoxes = { planos_Lista1, planos_Lista2, planos_Lista3 };

            foreach (ListBox listBox in listBoxes)
            {
                if (listBox.Tag is null) {
                    listBox.ClearSelected();
                }
            }

            ((ListBox)sender).Tag = null;
        }
        private void planos_btnAdd_Click(object sender, EventArgs e)
        {
            if (!HasText(new List<Control>() { planos_txtNovoPlano })) return;
            planos_Lista1.Items.Add(planos_txtNovoPlano.Text);
            planos_txtNovoPlano.Clear();
        }

        private void planosTlm_btnAdd_Click(object sender, EventArgs e)
        {
            if (!HasText(new List<Control>() { planosTlm_txtNovoPlano })) return;
            planosTlm_Lista1.Items.Add(planosTlm_txtNovoPlano.Text);
            planosTlm_txtNovoPlano.Clear();
        }
        private void planos_btnApagar_Click(object sender, EventArgs e)
        {
            foreach (Control control in tabPage_Planos.Controls)
            {
                if (control.Name.StartsWith("planos_Lista"))
                {
                    ((ListBox)control).Items.Remove(((ListBox)control).SelectedItem);
                }
            }
        }
        private void planosTlm_btnApagar_Click(object sender, EventArgs e)
        {
            foreach (Control control in tabPage_PlanosTlm.Controls)
            {
                if (control.Name.StartsWith("planosTlm_Lista"))
                {
                    ((ListBox)control).Items.Remove(((ListBox)control).SelectedItem);
                }
            }
        }

        #endregion

        #region Stock
        private void stock_btnConfirmar_Click(object sender, EventArgs e)
		{
            //Controlos que não podem ter texto vazio
            List<Control> controls = new List<Control>() { stock_comboBoxMaterial, stock_txtQuantidade, stock_txtPreco, stock_txtEnvio };

            if (stock_checkEnvioDividido.Checked) controls.Append(stock_txtEnvioDividido);

            if (!HasText(controls))
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            double preco;
            double envio;
            int quantidade;
            int envioDividido = 1;

            bool formatoValido = double.TryParse(stock_txtPreco.Text.Trim().Replace('.', ','), out preco) &
                                double.TryParse(stock_txtEnvio.Text.Trim().Replace('.', ','), out envio) &
                                int.TryParse(stock_txtQuantidade.Text, out quantidade);

            if (stock_checkEnvioDividido.Checked) formatoValido = formatoValido & int.TryParse(stock_txtEnvioDividido.Text, out envioDividido);

            if (!formatoValido)
            {
                MessageBox.Show("Preencha os campos corretamente!");
                return;
            }

            String nome = stock_comboBoxMaterial.Text;
            double envioTotal = envio / envioDividido;

            ProdutoStock produto = new ProdutoStock(nome, "stock", preco, envioTotal, quantidade);
            dados.addStock(produto);

            clearText(tabPage_Stock);

            atualizarLabels();
            table_Stock.Rows.Add(produto.GetRow());
        }
        #endregion

        #region Definições
        private void definicoes_btnReset_Click(object sender, EventArgs e)
        {
            definicoes_Vendas.Items.Clear();
            foreach(string str in dados.TiposVenda)
                if(str != null)
                    definicoes_Vendas.Items.Add(str);

            definicoes_Compras.Items.Clear();
            foreach (string str in dados.TiposCompra)
                if (str != null)
                    definicoes_Compras.Items.Add(str);

            definicoes_Stock.Items.Clear();
            foreach (string str in dados.TiposStock)
                if (str != null)
                    definicoes_Stock.Items.Add(str);
        }

        private void definicoes_btnGuardar_Click(object sender, EventArgs e)
        {
            List<string> vendas = new List<string>();
            foreach (string str in definicoes_Vendas.Items)
                vendas.Add(str);
            dados.SetTipo(vendas, "/TiposVenda");

            List<string> compras = new List<string>();
            foreach (string str in definicoes_Compras.Items)
                compras.Add(str);
            dados.SetTipo(compras, "/TiposCompra");

            List<string> stock = new List<string>();
            foreach (string str in definicoes_Stock.Items)
                stock.Add(str);
            dados.SetTipo(stock, "/TiposStock");

            MessageBox.Show("Definições guardadas com sucesso!");

            vendas_comboBoxTipos.Items.Clear();
            vendas_comboBoxTipos.Items.Add("Custom");
            if (dados.TiposVenda.Count > 0)
                vendas_comboBoxTipos.Items.AddRange(dados.TiposVenda.ToArray());

            compras_comboBoxTipos.Items.Clear();
            compras_comboBoxTipos.Items.Add("Custom");
            if (dados.TiposCompra.Count > 0)
                compras_comboBoxTipos.Items.AddRange(dados.TiposCompra.ToArray());

            stock_comboBoxMaterial.Items.Clear();
            if (dados.TiposStock.Count > 0)
                stock_comboBoxMaterial.Items.AddRange(dados.TiposStock.ToArray());
        }

        private void definicoes_addButton_Click(object sender, EventArgs e)
        {
            string source = ((Button)sender).Tag.ToString();
            string target = tabPage_Definicoes.Controls[source].Tag.ToString();

            TextBox textBox = (TextBox)tabPage_Definicoes.Controls[source];
            ListBox listBox = (ListBox)tabPage_Definicoes.Controls[target];

            if (!HasText(new List<Control>() { textBox })) return;

            listBox.Items.Add(textBox.Text);
            textBox.Text = "";
        }

        private void definicoes_removeButton_Click(object sender, EventArgs e)
        {
            string target = ((Button)sender).Tag.ToString();

            ListBox listBox = (ListBox)tabPage_Definicoes.Controls[target];

            ((ListBox)listBox).Items.Remove(((ListBox)listBox).SelectedItem);
        }
        #endregion
    }
}