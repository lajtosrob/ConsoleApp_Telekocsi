using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Telekocsi
{
    internal class Igeny
    {

        string azonosito;
        string indulas;
        string cel;
        int szemelyek;

        public Igeny(string azonosito, string indulas, string cel, int szemelyek)
        {
            this.Azonosito = azonosito;
            this.Indulas = indulas;
            this.Cel = cel;
            this.Szemelyek = szemelyek;
        }

        public string Azonosito { get => azonosito; set => azonosito = value; }
        public string Indulas { get => indulas; set => indulas = value; }
        public string Cel { get => cel; set => cel = value; }
        public int Szemelyek { get => szemelyek; set => szemelyek = value; }
    }
}
