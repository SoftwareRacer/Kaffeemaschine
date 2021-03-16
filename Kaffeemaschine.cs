using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Übung_14_Kaffeemaschine
{
    public class Kaffeemaschine
    {
        public double wasser { get; private set; }
        public double bohnen { get; private set; }
        public double gesamtMengeKaffeProduziert { get; private set; }

        private static double maxWasser = 2.5;
        private static double maxBohnen = 2.5;

        public Kaffeemaschine()
        {
            wasser = 0;
            bohnen = 0;
            gesamtMengeKaffeProduziert = 0;
        }

        public double wasserAuffuellen(double menge)
        {
            if (menge <= 0)
                return 0;

            if (wasser + menge <= maxWasser)
            {
                wasser += menge;
                return menge;
            }

            double tatsaechlMenge = maxWasser - wasser;
            wasser = maxWasser;
            return tatsaechlMenge;
        }

        public double bohnenAuffuellen(double menge)
        {
            if (menge <= 0)
                return 0;

            if (bohnen + menge <= maxBohnen)
            {
                bohnen += menge;
                return menge;
            }

            double tatsaechlMenge = maxBohnen - bohnen;
            bohnen = maxBohnen;
            return tatsaechlMenge;
        }

        public bool macheKaffee(double menge, double verhaeltnisWasserBohnen)
        {
            if (menge <= 0 || verhaeltnisWasserBohnen <= 0)
                return false;

            double bohnenAnteil = menge / (verhaeltnisWasserBohnen + 1);
            double wasserAnteil = menge - bohnenAnteil;

            if (bohnenAnteil > bohnen || wasserAnteil > wasser)
                return false;

            bohnen -= bohnenAnteil;
            wasser -= wasserAnteil;

            gesamtMengeKaffeProduziert += menge;
            return true;
        }

        public override bool Equals(object obj)
        {
            if (obj is Kaffeemaschine)
            {
                Kaffeemaschine other = obj as Kaffeemaschine;
                return other.wasser == wasser && other.bohnen == bohnen;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return string.Format("{0}/{1}", wasser, bohnen).GetHashCode();
        }

        public static bool operator ==(Kaffeemaschine maschine1, Kaffeemaschine maschine2)
        {
            if (object.ReferenceEquals(maschine1, null))
            {
                return object.ReferenceEquals(maschine2, null);
            }
            return maschine1.Equals(maschine2);
        }

        public static bool operator !=(Kaffeemaschine maschine1, Kaffeemaschine maschine2)
        {
            return !(maschine1 == maschine2);
        }
    }
}
