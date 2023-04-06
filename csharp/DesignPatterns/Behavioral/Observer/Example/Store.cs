namespace DesignPatterns.Behavioral.Observer.Example
{
	public class Store : ISubject
	{
		private List<Product> _products = new List<Product>();
		private List<IObserver> _observers = new List<IObserver>();

		public void AddProduct(Product product)
		{
			_products.Add(product);
		}

		public void ProductAvailable(Product product)
		{
			product.SetAvailable();
			Notify();
		}

		public void Attach(IObserver observer)
		{
			_observers.Add(observer);
		}

		public void Detach(IObserver observer)
		{
			_observers.Remove(observer);
		}

		public void Notify()
		{
			foreach (IObserver observer in _observers)
			{
				observer.Update(this);
			}
		}

		public List<Product> GetAvailableProducts()
		{
			List<Product> availableProducts = new List<Product>();
			foreach (Product product in _products)
			{
				if (product.IsAvailable)
				{
					availableProducts.Add(product);
				}
			}
			return availableProducts;
		}
	}

}
