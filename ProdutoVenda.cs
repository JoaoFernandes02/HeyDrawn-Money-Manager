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

        public ProdutoVenda() : base() { }

        public override DataGridViewRow GetRow()
        {
            DataGridViewRow dataGridViewRow = new DataGridViewRow();

            dataGridViewRow.Cells.Add(new DataGridViewTextBoxCell() { Value = base.ID.ToString() });
            dataGridViewRow.Cells.Add(new DataGridViewTextBoxCell() { Value = base.Nome });
            dataGridViewRow.Cells.Add(new DataGridViewTextBoxCell() { Value = base.Descricao });
            dataGridViewRow.Cells.Add(new DataGridViewTextBoxCell() { Value = base.Preco.ToString("0.00") });
            dataGridViewRow.Cells.Add(new DataGridViewTextBoxCell() { Value = Lucro.ToString("0.00") });
            dataGridViewRow.Cells.Add(new DataGridViewTextBoxCell() { Value = (base.Data.Ano == 0) ? "": base.Data.ToString() });

            return dataGridViewRow;
        }
    }
}
