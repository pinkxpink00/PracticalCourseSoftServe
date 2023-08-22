interface IShape
{
	double Area()
	{
		return 0;
	}
}

	class Rectangle : IShape
	{
		double Lenght { get; set; }
		double Width { get; set; }

		double Area()
		{
			return Lenght * Width;
		}
	}

	class Trapezoid : IShape
	{
		double Length1 { get; set; }
		double Length2 { get; set; }
		double Width { get; set; }

		double Area()
		{
			return 0.5 * (Length1 + Length2) * Width;
	}
}

class Room<T> : IShape
{
	public double Height { get; set; }
	public T Floor { get; set; }

}