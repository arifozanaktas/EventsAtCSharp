using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAtCSharp;

internal record StockObject (string name,int stock);
internal class ProductService
{
    internal event Action<StockObject> StockReturn;
    private readonly ProductRepository _repository = new ProductRepository();

    internal void UpdateStock(int stock)
    {
        if (stock > 1 && stock < 100)
        {
            _repository.UpdateStock(stock);
            StockReturn?.Invoke(new StockObject(GetProduct().Name, stock));
        }
        else {
            throw new Exception("Stock 1 ile 100 arasında oomalıdır");

        }
    }

    internal Product GetProduct() => _repository.GetProduct();
}
