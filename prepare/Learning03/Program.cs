using System;

class Program
{
    static void Main(string[] args)
    {
        // First fraction instance using the First Constructor:
        Fraction fraction1 = new Fraction();
        // Second fraction instance using the Second Constructor:
        Fraction fraction2 = new Fraction(6);
        // Third fraction instance using the Third Constructor:
        Fraction fraction3 = new Fraction(6, 7);

        //The output should be 1/1:Console.WriteLine($" The First Fraction is: {fraction1.GetFractionString}");
        
        //The output should be 6/1:
        Console.WriteLine($" The Second Fraction is: {fraction2.GetFractionString}");
        //The output should be 6/7:
        Console.WriteLine($" The Third Fraction is: {fraction3.GetFractionString}");

        //fraction1.SetBottom(8);
        // Console.WriteLine($" The First Fraction is: {fraction1.GetBottom}");
//Act

    }
}