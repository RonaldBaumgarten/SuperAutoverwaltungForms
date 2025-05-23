using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoverwaltungForms
{
    public class Auto
    {
        private string marke;
        private double preis;
        private string modellname;
        private int baujahr;
        private string antrieb;
        private string extras;

        public string Marke { get => marke; set => marke = value; }
        public double Preis { get => preis; set => preis = value; }
        public string Modellname { get => modellname; set => modellname = value; }
        public int Baujahr { get => baujahr; set => baujahr = value; }

        public Auto(string marke, double preis, string modellname, int baujahr, string antrieb, string extras)
        {
            this.marke = marke;
            this.preis = preis;
            this.modellname = modellname;
            this.baujahr = baujahr;
            this.antrieb = antrieb;
            this.extras = extras;
        }

        public string autoInfo()
        {
            return marke + ", " + modellname + ", " + baujahr.ToString()+ "\t Preis: \t" + preis.ToString() + "$" ;
        }
    }
}
