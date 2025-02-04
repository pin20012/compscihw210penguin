using System.Runtime.CompilerServices;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction (int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // public GetTop()
    // {
    //     _top
    // }

    // public SetTop(int top)
    // {

    // }

    // public GetBottom()
    // {

    // }
    // public SetBottom(int bottom)
    // {

    // }

    public string GetFractionString()
    // string
    {
         string text = $"{_top}/{_bottom}";
         return text;
       
    }

    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }

    // public GetDecimalValue()
    // // double
    // {

    // }
}