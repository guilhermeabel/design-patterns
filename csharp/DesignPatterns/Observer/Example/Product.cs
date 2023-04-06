namespace DesignPatterns.Observer.Example
{
	public class Product
	{
		public string Name { get; set; }
		public decimal Price { get; set; }
		public bool IsAvailable { get; set; }

		public Product(string name, decimal price)
		{
			Name = name;
			Price = price;
			IsAvailable = false;
		}

		public void SetAvailable()
		{
			IsAvailable = true;
			Console.WriteLine("Product {0} is now available!", Name);
		}
	}

}
