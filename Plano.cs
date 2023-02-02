using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeyDrawn_Money_Manager
{
    public class Plano
    {
        public int ID { get; set; }
        public string Descricao { get; set; }
        public string Estado { get; set; }

        public Plano(string descricao, string estado)
        {
            Descricao = descricao;
            Estado = estado;
        }
        public override string ToString()
        {
            return ID + " - " + Descricao;
        }

        public string UpdateEstado(int nextEstado)
        {
            List<string> estados = new List<string>{ "Pendente", "Ativo", "Pronto", "Enviados" };

            int currentEstado = estados.IndexOf(Estado);

            int newEstado = currentEstado + nextEstado;
            string newEstadoValue;

            if (newEstado < 0)
                newEstadoValue = estados[3];
            else if(newEstado > 3)
                newEstadoValue = estados[0];
            else
                newEstadoValue = estados[newEstado];

            Estado = newEstadoValue;
            return newEstadoValue;
        }
    }
}
