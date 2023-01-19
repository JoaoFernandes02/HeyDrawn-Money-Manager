using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeyDrawn_Money_Manager
{
    public class ProdutoCompra : Produto
    {
        public ProdutoCompra(string nome, string descricao, double preco, double envio) : base(nome, descricao, preco, envio){}

        public override DataGridViewRow GetRow()
        {
            DataGridViewRow dataGridViewRow = new DataGridViewRow();

            dataGridViewRow.Cells.Add(new DataGridViewTextBoxCell() { Value = base.ID.ToString() });
            dataGridViewRow.Cells.Add(new DataGridViewTextBoxCell() { Value = base.Nome });
            dataGridViewRow.Cells.Add(new DataGridViewTextBoxCell() { Value = base.Descricao });
            dataGridViewRow.Cells.Add(new DataGridViewTextBoxCell() { Value = base.Preco.ToString() });

            return dataGridViewRow;
        }
    }
}
