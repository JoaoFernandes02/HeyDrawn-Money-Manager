using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeyDrawn_Money_Manager
{
    public class ListaVendas : List<ProdutoVenda>
    {
        public double GetLucro()
        {
            double total = 0;
            foreach (ProdutoVenda produto in this)
                total += produto.Lucro;

            return total;
        }

        public DataGridViewRow[] GetRows()
        {
            List<DataGridViewRow> rows = new List<DataGridViewRow>();
            foreach (ProdutoVenda produto in this)
                rows.Add(produto.GetRow());
            return rows.ToArray();
        }
    }
}
