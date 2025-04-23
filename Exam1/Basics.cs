namespace Exam1;


public class Q1_Add
{
   
    public static int Add(int a , int b)
    {
        return a+b;
    }
}

public class Basics
{
    public static void Q2MultiplyAndReset(ref int a , ref int b)
    {
        a = a*b;
        b=1;

    }

    
    public static void Q5TryCatchFinally(bool a , List<string> b , bool c=false)
    {   
        if(c==true)
        {
            try{
                if(a==true)
                {
                    throw new InvalidOperationException();
                }

            }
            catch(InvalidOperationException)
            {
                throw;
            }
        }
        else{

        try
        {
            b.Add("Try");
            
            if(a==true)
            {
                throw new Exception();
            }
            else{
                b.Add("AfterTry");
            }

        }

        
        catch(Exception )
        {   b.Add("Catch");
            throw;
        }

        finally
        {   
            b.Add("Finally");
            System.Console.WriteLine($"When shouldThrow is {a}, expect {b[0]} → {b[1]} → {b[2]}");
        }
        }
        
    }
}

public struct Type1
{
    public int Count { get; set; }
}

public class Type2 
{
    public int Count { get; set; }
}

public class Q4Person
{
    public int Age { get; set; }
    public string  Name { get; set; }

    public Q4Person(string n , int a)
    {
        this.Age=a;
        this.Name=n;
    }
    public string Introduce()
    {
        return $"Hello, my name is {this.Name} and I am {this.Age} years old.";
    }
}

public class Q6Temperature
{
    private double celsius;
    private double fahrenheit;

    public double Celsius { 
        get 
        {
            if(this.fahrenheit!=null)
            {   
                return (this.fahrenheit-32)*5/9;
            }
            return celsius;
        }
        set { celsius = value; }
    }
    public double Fahrenheit {
        get {
            if(this.celsius!=null)
            {
                return (1.8*this.celsius)+32;
            
            }
            return fahrenheit;
            }  
            set {fahrenheit = value; }
    }


}

public interface IShape{
    public double GetArea();
    public double GetPerimeter();
}
public class Q7Circle : IShape
{   
    private double radius ;

    public Q7Circle(double r)
    {
        this.radius=r;
    }
    public double GetArea()
    {
        return radius*radius*Math.PI;
    }

    public double GetPerimeter()
    {
        return 2*Math.PI*radius;
    }
}

public class Q7Rectangle : IShape
{   

    private double length;
    private double width;

    public Q7Rectangle(double l , double w)
    {
        this.length=l;
        this.width=w;
    }
    public double GetArea()
    {
        return this.length*this.width;
    }

    public double GetPerimeter()
    {
        return 2*(this.length+this.width);
    }
}
public class ShapeUtils
{   
    public static double Q7TotalArea(IShape[] shapes)
    {
        double total = 0;
            foreach(var i in shapes)
            {
                total+=i.GetArea();
            }

        return total;
    }
}

public class Q8StringLengthComparer : IComparer<string>
{
    public int Compare(string x, string y)
    {   
        if((x==null && y=="" )||(x=="" && y==null))
    {
        return -1;
    }
    
    if(x==null && y==null)
    {
        return string.Compare(x,y);
    }
   
    if((x==null && y!="" )||(x!="" && y==null))
    {
        return 1;
    }

    else{

        if(x.Length<y.Length)
        {
            return -1;
        }
        else if(x.Length>y.Length)
        {
            return 1;
        }

        else{
            return x.CompareTo(y);
        }
    }
    }

    
}

public class Q8ComparableString
{

}