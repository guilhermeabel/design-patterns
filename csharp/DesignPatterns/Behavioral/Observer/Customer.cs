namespace DesignPatterns.Behavioral.Observer
{
	public class Customer : IObserver
	{
		public string Name { get; set; }

		public Customer(string name)
		{
			Name = name;
		}

		public void Update(ISubject subject)
		{
			if (subject is Store store)
			{
				List<Product> availableProducts = store.GetAvailableProducts();
				Console.WriteLine("Customer {0} received notification:", Name);
				foreach (Product product in availableProducts)
				{
					Console.WriteLine("- {0} is now available for {1:C}", product.Name, product.Price);
				}
			}
		}
	}

}
