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

        public string Marke { get => marke; set => marke = value; }
        public double Preis { get => preis; set => preis = value; }
        public string Modellname { get => modellname; set => modellname = value; }
        public int Baujahr { get => baujahr; set => baujahr = value; }

        public string autoInfo()
        {
            return marke + ", " + preis.ToString() + ", " + modellname + ", " + baujahr.ToString();
        }
    }
}
