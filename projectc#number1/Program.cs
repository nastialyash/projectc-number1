using System;
using static System.Formats.Asn1.AsnWriter;

class Journal
{

    private int numberOfEmployees;


    public int NumberOfEmployees
    {
        get => numberOfEmployees;
        set
        {
            if (value < 0)
                throw new ArgumentException("Count of employes cannit be.");
            numberOfEmployees = value;
        }
    }


    public Journal(int numberOfEmployees)
    {
        NumberOfEmployees = numberOfEmployees;
    }


    public static Journal operator +(Journal journal, int value)
    {
        return new Journal(journal.NumberOfEmployees + value);
    }


    public static Journal operator -(Journal journal, int value)
    {
        if (journal.NumberOfEmployees - value < 0)
            throw new InvalidOperationException("Count of employes cannot be");
        return new Journal(journal.NumberOfEmployees - value);
    }


    public static bool operator ==(Journal journal1, Journal journal2)
    {
        return journal1?.NumberOfEmployees == journal2?.NumberOfEmployees;
    }


    public static bool operator !=(Journal journal1, Journal journal2)
    {
        return !(journal1 == journal2);
    }


    public static bool operator >(Journal journal1, Journal journal2)
    {
        return journal1?.NumberOfEmployees > journal2?.NumberOfEmployees;
    }


    public static bool operator <(Journal journal1, Journal journal2)
    {
        return journal1?.NumberOfEmployees < journal2?.NumberOfEmployees;
    }


    public override bool Equals(object obj)
    {
        if (obj is Journal otherJournal)
        {
            return NumberOfEmployees == otherJournal.NumberOfEmployees;
        }
        return false;
    }
}

class market
{

    
    private double area;

    public double Area
    {
        get { return area; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Area of market cannot be ");
            area = value;
        }

    }
        public market(double area)
    {
        this.area = area;
    }
    public static market operator + (market m, double volue){

        return new market(m.area+volue);


    }
    public static market operator -(market m, double volue) {


        if (m.area - volue < 0)
            throw new InvalidOperationException("Area of market cannot be ");
        return new market(m.area - volue);
    }

    public static bool operator ==(market m1, market m2)
    {
        return m1?.area == m2?.area;
    }
    public static bool operator !=(market m1, market m2)
    {
        return !(m1 == m2);
    }
    public static bool operator >(market m1, market m2)
    {
        return m1?.area > m2?.area;
    }

    
    public static bool operator <(market m1, market m2)
    {
        return m1?.area < m2?.area;
    }

   
    public override bool Equals(object obj)
    {
        if (obj is market otherStore)
        {
            return area == otherStore.area;
        }
        return false;
    }
}
class Program
{
    static void Main()
    {
        var store1 = new market(120.5);
        var store2 = new market(200.0);

        Console.WriteLine($"Market 1: area {store1.Area} ");
        Console.WriteLine($"Мarket 2: area{store2.Area} ");

        store1 += 50;
        Console.WriteLine($"Market 1 after area + : {store1.Area} ");

        store2 -= 30;
        Console.WriteLine($"Market 2 after area - : {store2.Area} ");

        Console.WriteLine($"Market 1 == Market 2: {store1 == store2}");
        Console.WriteLine($"Market 1 > Market 2: {store1 > store2}");

    }
}