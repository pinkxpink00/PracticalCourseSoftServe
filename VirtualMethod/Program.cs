using System;

namespace VMethod
{
	class Program
	{
		static void Main(string[] args)
		{
			Ostrich ostrich = new Ostrich();
			ostrich.Name = "Test";
            Console.WriteLine(ostrich.Name);

			Bird ostrich2 = new Bird();
			ostrich2.Name = "Tes2t";
            Console.WriteLine(ostrich2.Name);
        }
	}

	public class Bird
	{
		private string name;

		public virtual string Name
		{
			get { return name; }
			set { name = value; }
		}
	}

	public class Ostrich : Bird
	{
		public override string Name
		{
			get { return base.Name + "ostrich"; }
		}
	}
}