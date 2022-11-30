using System;

public static class Globals
{
	internal static void Main()
	{
		Console.Write("Introduceti valorile numerelor pentru a verifica daca pot forma un triunghi:");
		Console.Write("\n");
		int a;
		int b;
		int c;
		Console.Write("a = ");
		a = Convert.ToInt32(Console.ReadLine());
		Console.Write("b = ");
		b = Convert.ToInt32(Console.ReadLine());
		Console.Write("c = ");
		c = Convert.ToInt32(Console.ReadLine());

		if (a < b + c && b < a + c && c < a + b)
		{
			Console.Write("DA");
		}
		else
		{
			Console.Write("NU");
		}
	}
}

