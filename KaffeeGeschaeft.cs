using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Übung_14_Kaffeemaschine
{
    public class KaffeeGeschaeft
    {
        private double _preisProKg;
        public double preisProKg
        {
            get
            {
                return _preisProKg;
            }
            set
            {
                if (value >= 5 && value <= 30)
                    _preisProKg = value;
            }
        }

        public KaffeeGeschaeft(double preis)
        {
            preisProKg = preis;
        }

        public double kaufeKaffee(Kaffeemaschine maschine, double menge)
        {
            double neuerKaffeeMenge = maschine.bohnenAuffuellen(menge);
            return neuerKaffeeMenge * preisProKg;
        }
    }
}
