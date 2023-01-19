using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeyDrawn_Money_Manager
{
    public class ListaStock : List<ProdutoStock>
    {
        public double GetGastos()
        {
            double total = 0;
            foreach (ProdutoStock produto in this)
                total += produto.Preco + produto.Envio;

            return total;
        }

        public DataGridViewRow[] GetRows()
        {
            List<DataGridViewRow> rows = new List<DataGridViewRow>();
            foreach (ProdutoStock produto in this)
                rows.Add(produto.GetRow());
            return rows.ToArray();
        }
    }
}
