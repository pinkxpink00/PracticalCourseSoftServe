using System.Reflection;
using System.Security.Principal;
using System.Threading.Channels;

//Single Responsibility Principle (Принцип единственной обязанности)

//class Report
//{
//	public string Text { get; set; }
//	public void GoToFirstPage() => Console.WriteLine("First Page");
//	public void GoToSecondPage() => Console.WriteLine("Second Page");
//	public void GoToPage(int pageNumber) => Console.WriteLine($"GoToPage:{pageNumber}");
//}

//class Printer
//{
//	public void PrintReport(Report report)
//	{
//		Console.WriteLine("Print Report");
//		Console.WriteLine(report.Text);
//	}
//}


class Phone
{
	public string Model { get; }
	public int Price { get; }
    public Phone(string model,int price)
    {
        Model = model;
        Price = price;
    }

    class MobileStore
    {
        List<Phone> phones = new List<Phone>();
		public IPhoneReader Reader { get; set; }
		public IPhoneBinder 
    }
	interface IPhoneReader
	{
		string?[] GetInputData();
	}
	class ConsolePhoneReader : IPhoneReader
	{
		public string?[] GetInputData()
		{
			Console.WriteLine("Input model:");
			string? model = Console.ReadLine();
			Console.WriteLine("Input price:");
			string? price = Console.ReadLine();
			return new string?[] { model, price };
		}
	}
	interface IPhoneBinder
	{
		Phone CreatePhone(string?[] data);
	}
	class GeneralPhoneBuilder : IPhoneBinder
	{
		public Phone CreatePhone(string?[] data)
		{
			if (data is { Length: 2 } && data[0] is string model &&
				model.Length > 0 && int.TryParse(data[1], out var price))
			{
				return new Phone (model, price);
			}
			throw new Exception("Incorrect data");
		}
	}
	interface IPhoneValidator
	{
		bool IsValid(Phone phone);
	}
	class GeneralPhoneValidator : IPhoneValidator
	{
		public bool IsValid(Phone phone) => !string.IsNullOrEmpty(phone.Model) && phone.Price > 0;
	}
	interface IPhoneSaver
	{
		void Save(Phone phone,string fileName);
	}
	class TextPhoneSaver : IPhoneSaver
	{
		public void Save(Phone phone, string fileName)
		{
			using StreamWriter writer = new StreamWriter(fileName,true);
			writer.WriteLine(phone.Model);
			writer.WriteLine(phone.Price);
		}
	}
}