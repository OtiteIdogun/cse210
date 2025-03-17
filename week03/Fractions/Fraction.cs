using System;

public class Fraction
{
	private double _numerator;
	private double _denominator;

	public Fraction()
	{
		_numerator = 1;
		_denominator = 1;
	}

    public Fraction(int numerator)
	{
		_numerator = numerator;
		_denominator = 1;
	}

	public Fraction(int numerator, int denominator)
	{
		_numerator = numerator;
		_denominator = denominator;
	}

	public string FractionRep()
	{
		string fraction = $"{_numerator} / {_denominator}";
		return fraction;
	}
	
	public double DecimalRep()
	{
		double decimalRep = _numerator / _denominator;
		return decimalRep;
	}
	
	public double GetNumerator()
	{
	    return _numerator;
	}
	
	public double GetDenominator()
	{
	    return _denominator;
	}
	
	public void SetNumerator(int numerator)
	{
	    _numerator = numerator;
	}
	
    public void SetDenominator(int denominator)
	{
	    _denominator = denominator;
	}
}