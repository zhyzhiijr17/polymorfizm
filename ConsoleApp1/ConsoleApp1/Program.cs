abstract class Shape
{
    public string Name { get; }

    protected Shape(string name)
    {
        Name = name;
    }

    public abstract double Area();
    public abstract double Perimeter();
}

class Circle : Shape
{
    public double Radius { get; }

    public Circle(double radius) : base("Circle")
    {
        Radius = radius;
    }

    public override double Area()
    {
        return Math.PI * Radius * Radius;
    }

    public override double Perimeter()
    {
        return 2 * Math.PI * Radius;
    }
}

class Square : Shape
{
    public double Side { get; }

    public Square(double side) : base("Square")
    {
        Side = side;
    }

    public override double Area()
    {
        return Side * Side;
    }

    public override double Perimeter()
    {
        return 4 * Side;
    }
}

class Program
{
    static void Main()
    {
        Circle[] circles = new Circle[2];
        Square[] squares = new Square[2];

        // Введення даних для кругів
        for (int i = 0; i < 2; i++)
        {
            Console.Write($"Введіть радіус кола {i + 1}: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            circles[i] = new Circle(radius);
        }

        // Введення даних для квадратів
        for (int i = 0; i < 2; i++)
        {
            Console.Write($"Введіть сторону квадрата {i + 1}: ");
            double side = Convert.ToDouble(Console.ReadLine());
            squares[i] = new Square(side);
        }

        Console.WriteLine("\nФігури:");

        foreach (var circle in circles)
        {
            Console.WriteLine($"{circle.Name}: Площа = {circle.Area()}, Периметр = {circle.Perimeter()}");
        }

        foreach (var square in squares)
        {
            Console.WriteLine($"{square.Name}: Площа = {square.Area()}, Периметр = {square.Perimeter()}");
        }

        // Знаходження найбільшого квадрата та кола
        double maxCircleArea = Math.Max(circles[0].Area(), circles[1].Area());
        double maxSquareArea = Math.Max(squares[0].Area(), squares[1].Area());

        Console.WriteLine($"\nПлоща найбільшого кола: {maxCircleArea}");
        Console.WriteLine($"Площа найбільшого квадрата: {maxSquareArea}");
    }
}