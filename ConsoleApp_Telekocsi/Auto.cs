using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Telekocsi
{
    internal class Auto
    {
        string indulas;
        string cel;
        string rendszam;
        string telefonszam;
        int ferohely;

        public Auto(string indulas, string cel, string rendszam, string telefonszam, int ferohely)
        {
            this.indulas = indulas;
            this.cel = cel;
            this.rendszam = rendszam;
            this.telefonszam = telefonszam;
            this.ferohely = ferohely;
        }

        public string Indulas { get => indulas; set => indulas = value; }
        public string Cel { get => cel; set => cel = value; }
        public string Rendszam { get => rendszam; set => rendszam = value; }
        public string Telefonszam { get => telefonszam; set => telefonszam = value; }
        public int Ferohely { get => ferohely; set => ferohely = value; }
    }
}
