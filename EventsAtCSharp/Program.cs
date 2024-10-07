namespace EventsAtCSharp;

internal class Program
{
    static void StockChanged(StockObject stockObject)
    {
        Console.WriteLine($"Stock changed. {stockObject.name} stock value is{stockObject.stock}");
    }



    static void Main(string[] args)
    {
        var productService = new ProductService();
        productService.StockReturn += StockChanged;

        for (int i = 2; i < 10; i++) 
        {
            productService.UpdateStock(i);
        }

    }
}
