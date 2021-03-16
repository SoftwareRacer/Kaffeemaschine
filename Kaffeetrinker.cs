using System;

public class Kaffeetrinker : Kaffeemaschine
{
	public Kaffeetrinker()
	{
	}
	public void registerKaffeemaschine(Kaffeemaschine maschine)
    {
		maschine.KaffeeIstZubereitet += Maschine_KaffeeIstZubereitet;
    }

	private void Maschine_KaffeeIstZubereitet(object sender, EventArgs e)
	{
		Console.WriteLine("Yam!");
	}
}
