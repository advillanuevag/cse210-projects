using System.Diagnostics;

public class Fraction
{
    private int _top;
    private int _bottom;

    
    //Constructor with no parameters:
    public Fraction()
    {
        _top = 1;
        _bottom = 1;

    }

    // Constructor with top parameter and bottom = 1:

    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;

    }

    //Constructor with two parameters:

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;

    }

    //Getters for top and bottom numbers:
    public int GetTop()
    {
        return _top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    //Setters for top and bottom numbers:
    public void SetTop(int top)
    {
        _top = top;
     
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
     
    }

    public string GetFractionString()
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }

    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;

    }




}