using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeyDrawn_Money_Manager
{
    public class ProdutoVenda : Produto
    {
        public double CustoMaterial { get; set; }
        public double Lucro { get
            {
                return Preco - CustoMaterial - Envio;
            }
        }
        public ProdutoVenda(string nome, string descricao, double preco, double envio, double custoMaterial) : base(nome, descricao, preco, envio)
        {
            CustoMaterial = custoMaterial;
        }

        public override DataGridViewRow GetRow()
        {
            DataGridViewRow dataGridViewRow = new DataGridViewRow();

            dataGridViewRow.Cells.Add(new DataGridViewTextBoxCell() { Value = base.ID.ToString() });
            dataGridViewRow.Cells.Add(new DataGridViewTextBoxCell() { Value = base.Nome });
            dataGridViewRow.Cells.Add(new DataGridViewTextBoxCell() { Value = base.Descricao });
            dataGridViewRow.Cells.Add(new DataGridViewTextBoxCell() { Value = base.Preco.ToString() });
            dataGridViewRow.Cells.Add(new DataGridViewTextBoxCell() { Value = Lucro.ToString() });

            return dataGridViewRow;
        }
    }
}
