using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeyDrawn_Money_Manager
{
    public class ListaCompras : List<ProdutoCompra>
    {
        public double GetGastos()
        {
            double total = 0;
            foreach(ProdutoCompra produto in this)
                if(!produto.Nome.StartsWith("Materiais")) total += produto.Preco;

            return total;
        }

        public DataGridViewRow[] GetRows()
        {
            List<DataGridViewRow> rows = new List<DataGridViewRow>();
            foreach (ProdutoCompra produto in this)
                rows.Add(produto.GetRow());
            return rows.ToArray();
        }
    }
}
