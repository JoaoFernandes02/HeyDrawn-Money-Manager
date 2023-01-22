using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeyDrawn_Money_Manager
{
    public class Data
    {
        public int Dia { get; set; }
        public int Mês { get; set; }
        public int Ano { get; set; }

        public Data()
        {
            Dia = DateTime.Now.Day;
            Mês = DateTime.Now.Month;
            Ano = DateTime.Now.Year;
        }

        public override string ToString()
        {
            return Dia.ToString("00") + "/" + Mês.ToString("00") + "/" + Ano;
        }
    }
}
