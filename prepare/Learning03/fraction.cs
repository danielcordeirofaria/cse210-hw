public class Fraction{
    private int _topNumber;
    private int _bottomNumber;


    public Fraction(){
        _topNumber = 1;
        _bottomNumber = 1;
    }

    public Fraction(int topNumber){
        _topNumber = topNumber;
        _bottomNumber = 1;
    }

      public Fraction(int topNumber, int bottomNumber){
        _topNumber = topNumber;
        _bottomNumber = bottomNumber;

    }

    public string GetFractionString(){
        string text = $"{_topNumber}/{_bottomNumber}";
        return text;
    }

    public double GetDecimalValue(){
        return (double)_topNumber / (double)_bottomNumber;
    }


}