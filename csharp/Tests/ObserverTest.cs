using DesignPatterns.Behavioral.Observer;

public class ObserverTest : IDesignPatternTest
{
	public void Run()
	{

		Store store = new Store();

		Product product1 = new Product("T-shirt", 19.99m);
		Product product2 = new Product("Hoodie", 39.99m);
		Product product3 = new Product("Mug", 9.99m);

		store.AddProduct(product1);
		store.AddProduct(product2);
		store.AddProduct(product3);


		Customer customer1 = new Customer("John");
		Customer customer2 = new Customer("Jane");

		store.Attach(customer1);
		store.Attach(customer2);

		store.ProductAvailable(product1);
		store.Detach(customer1);
		store.ProductAvailable(product2);
	}
}
