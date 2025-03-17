using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");

		FractionNumber fraction1 = new FractionNumber();
		FractionNumber fraction2 = new FractionNumber(5);
		FractionNumber fraction3 = new FractionNumber(3, 4);
		FractionNumber fraction4 = new FractionNumber(1, 3);

		string fRep = fraction1.FractionRep();		
		double dRep = fraction1.DecimalRep();
		Console.WriteLine(fRep);
		Console.WriteLine($"{dRep}\n");

		Console.WriteLine(fraction2.FractionRep());
		Console.WriteLine(fraction2.DecimalRep());
		Console.WriteLine();

		Console.WriteLine(fraction3.FractionRep());
		Console.WriteLine(fraction3.DecimalRep());
		Console.WriteLine();
	
		Console.WriteLine(fraction4.FractionRep());
		Console.WriteLine(fraction4.DecimalRep());
		Console.WriteLine();
	}
}