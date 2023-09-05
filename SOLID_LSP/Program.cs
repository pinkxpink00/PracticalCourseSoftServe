class Shape
{
	public virtual int CalculateArea()
	{
		return 0; // Базовая реализация для фигуры
	}
}

class Rectangle : Shape
{
	public int Width { get; set; }
	public int Height { get; set; }

	public override int CalculateArea()
	{
		return Width * Height;
	}
}

class Square : Shape
{
	public int SideLength { get; set; }

	public override int CalculateArea()
	{
		return SideLength * SideLength;
	}
}

class Program
{
	static void Main(string[] args)
	{
		Shape shape = new Shape();
		int shapeArea = shape.CalculateArea(); // Вернет 0
        Console.WriteLine(shapeArea);

        Rectangle rectangle = new Rectangle();
		rectangle.Width = 5;
		rectangle.Height = 4;
		int rectangleArea = rectangle.CalculateArea(); // Вернет 20
        Console.WriteLine(rectangleArea);

        Square square = new Square();
		square.SideLength = 5;
		int squareArea = square.CalculateArea(); // Вернет 25
        Console.WriteLine(squareArea);
    }

}