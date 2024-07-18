var list = new List<Figure>();
list.Add(new Square(100, 50));
list.Add(new Sircle(100, 100));


foreach (var item in list)
{
    Console.WriteLine(item.Area());
}

class Square : Figure
{
    public Square(int width, int height) : base(width, height)
    {
    }

    public override double Area()
    {
        return Width * Height;
    }
}

class Sircle : Figure
{
    public Sircle(int width, int height) : base(width, height)
    {
    }

    public override double Area()
    {
        return Math.PI * (Width / 2) * (Width / 2);
    }
}

abstract class Figure
{
    public Figure(int width, int height)
    {
        Width = width;
        Height = height;
    }

    public int Width { get; set; }
    public int Height { get; set; }

    private int x;
    public int X
    {
        get
        {
            return x;
        }
        set
        {
            x = value;
        }
    }

    private int y;

    public int Y { get; set; }

    public void InvertCoordinte()
    {
        (x, y) = (y, x);
    }

    public abstract double Area();

    public virtual double SwapCoordinte()
    {
        return 0;
    }
}