using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeyDrawn_Money_Manager
{
    public abstract class Produto
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double Preco { get; set; }
        public double Envio { get; set; }
        public int ID { get; set; }
        public Produto(string nome, string descricao, double preco, double envio)
        {
            Nome = nome;
            Descricao = descricao;
            Preco = preco;
            Envio = envio;
        }

        public abstract DataGridViewRow GetRow();
    }
}
