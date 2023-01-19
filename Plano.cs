using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeyDrawn_Money_Manager
{
    public class Plano
    {
        public string Descricao { get; set; }
        public string NomeLista { get; set; }

        public Plano(string descricao, string nomeLista)
        {
            Descricao = descricao;
            NomeLista = nomeLista;
        }
    }
}
