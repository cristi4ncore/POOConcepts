namespace POO.Concept.Logic;

public class Date
{
    private int _day;
    private int _month;
    private int _year;

    public Date()
    {
        Year = 1900;
        Month = 1;
        Day = 1;
    }

    public Date(int day, int month, int year)
    {
        Year = year;
        Month = month;
        Day = day;
    }

    public int Day {
        get
        {
            return _day;
        }
        set
        {
            _day = value;
        }
    }
    public int Month {
        get
        {
            return _month;
        }
        set
        {
            _month = value;
        }
    }
    public int Year {
        get
        {
            return _year;
        }
        set
        {
           _year = value;
        } 
    }

    public override string ToString()
    {
        return $"{Year:0000}/{Month:00}/{Day:00}";
    }

    private bool IsLeapYear(int year)
    {
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }
}
