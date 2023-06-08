namespace Exercice_03
{
	public class Product
	{
		public int Id { get; set; }
		public string Description { get; set; }
		public int Quantity { get; set; }
		public decimal Price { get; set; }

		public Product()
		{

		}
		public Product(int id, string description, int quantity, decimal price)
		{
			Id = id;
			Description = description;
			Quantity = quantity;
			Price = price;
		}

		List<Product> stock = new List<Product>();

		public void AddProduct(int id, string description, int quantity, decimal price)
		{
			if (stock.Any(product => product.Id == id))
			{
				Console.WriteLine("This product is already in the stock!");
				return;
			}

			Product NewProduct = new Product(id, description, quantity, price);

			stock.Add(NewProduct);
			Console.WriteLine("Product added with success!");
		}

		public void UpdateQuantity(int id, int newQuantity)
		{
			Product product = stock.FirstOrDefault(product => product.Id == id);

			if (product != null)
			{
				product.Quantity = newQuantity;
				Console.WriteLine("Quantity updated with sucess!");
			}
			else
			{
				Console.WriteLine("Product not found!");
			}
		}

		public void RemoveProduct(int id)
		{
			Product product = stock.FirstOrDefault(product => product.Id == id);

			if (product != null)
			{
				stock.Remove(product);
				Console.WriteLine("Product removed with sucess!");
			}
			else
			{
				Console.WriteLine("Product not found!");
			}
		}

		public decimal CalculateTotal()
		{
			decimal Total = 0;

			foreach (Product product in stock)
			{
				Total += product.Quantity * product.Price;
			}

			return Total;
		}

		public void ListProducts()
		{
			Console.WriteLine("Products in stock: \n");
			Console.WriteLine("----------");

			foreach (Product product in stock)
			{
				Console.WriteLine($"Id: {product.Id}\nDescription: {product.Description}\nQuantity: {product.Quantity}\nPrice: {product.Price}\n----------");
			}
		}
	}
}
