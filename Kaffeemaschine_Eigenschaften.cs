using System;
using System.Collections.Generic;
using Übung_14_Kaffeemaschine;

public class Kaffeemaschine_Eigenschaften
{

	public Kaffeemaschine_Eigenschaften()
	{
	}

	public void KaffeemaschinenAngleichen(Kaffeemaschine maschine1, Kaffeemaschine maschine2)
    {
        if (maschine1.wasser > maschine2.wasser)
        {
			maschine2.wasserAuffuellen(maschine1.wasser - maschine2.wasser);
        }
		if (maschine2.bohnen > maschine1.bohnen)
		{
			maschine1.bohnenAuffuellen(maschine2.bohnen - maschine1.bohnen);
        }
        if (maschine2.wasser > maschine1.wasser)
        {
            maschine1.wasserAuffuellen(maschine2.wasser - maschine1.wasser);
        }
        if (maschine1.bohnen > maschine2.bohnen)
        {
            maschine2.bohnenAuffuellen(maschine1.bohnen - maschine2.bohnen);
        }
    }

    public void alleKaffeemaschinenAngleichen(List<Kaffeemaschine> alleMaschinen)
    {
        double maxWasser = 0;
        double maxBohnen = 0;

        foreach (Kaffeemaschine maschine in alleMaschinen)
        {
            if (maschine.wasser > maxWasser)
                maxWasser = maschine.wasser;
            if (maschine.bohnen > maxBohnen)
                maxBohnen = maschine.bohnen;
        }

        foreach (Kaffeemaschine maschine in alleMaschinen)
        {
            if (maschine.wasser < maxWasser)
                maschine.wasserAuffuellen(maxWasser - maschine.wasser);
            if (maschine.bohnen < maxBohnen)
                maschine.bohnenAuffuellen(maxBohnen - maschine.bohnen);
        }

    }


    public void FuellMich(Kaffeemaschine maschine, double menge)
    {
		if(maschine == null)
        {
			maschine = new Kaffeemaschine();
			maschine.wasserAuffuellen(menge / 2);
            maschine.bohnenAuffuellen(menge / 2);
        }
		if(maschine.wasser < menge)
		{
            maschine.wasserAuffuellen(menge- maschine.wasser);
        }
        if (maschine.bohnen < menge)
        {
            maschine.wasserAuffuellen(menge - maschine.bohnen);
        }
    }
}
