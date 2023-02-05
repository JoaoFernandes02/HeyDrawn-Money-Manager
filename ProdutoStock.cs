using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeyDrawn_Money_Manager
{
    public class ProdutoStock : Produto
    {
        public int Quantidade { get; set; }
        public double PrecoUnidade { 
            get
            {
                return Math.Round((Preco + Envio) / Quantidade, 2);
            }
        }
        public ProdutoStock(string nome, string descricao, double preco, double envio, int quantidade) : base(nome, descricao, preco, envio)
        {
            Quantidade = quantidade;
        }

        public ProdutoStock() : base() { }
        public override DataGridViewRow GetRow()
        {
            DataGridViewRow dataGridViewRow = new DataGridViewRow();

            dataGridViewRow.Cells.Add(new DataGridViewTextBoxCell() { Value = base.ID.ToString() });
            dataGridViewRow.Cells.Add(new DataGridViewTextBoxCell() { Value = base.Nome });
            dataGridViewRow.Cells.Add(new DataGridViewTextBoxCell() { Value = Quantidade.ToString() });
            dataGridViewRow.Cells.Add(new DataGridViewTextBoxCell() { Value = PrecoUnidade.ToString("0.00") });
            dataGridViewRow.Cells.Add(new DataGridViewTextBoxCell() { Value = base.Data.ToString() });

            return dataGridViewRow;
        }

        public void RemoverStock()
        {
            Envio -= Envio / Quantidade;
            Preco -= Preco / Quantidade;
            Quantidade--;
        }
    }

}
