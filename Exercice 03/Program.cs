namespace Exercice_03
{
	public class Program
	{
		static void Main(string[] args)
		{
			Product product = new Product();
			product.AddProduct(01, "Laptop", 05, 10.99M);
			product.AddProduct(02, "Phone", 03, 29.99M);
			product.AddProduct(03, "Case", 15, 99.99M);
			Console.WriteLine(product.CalculateTotal());
			product.RemoveProduct(01);
			product.UpdateQuantity(02, 10);
			product.ListProducts();
		}
	}
}