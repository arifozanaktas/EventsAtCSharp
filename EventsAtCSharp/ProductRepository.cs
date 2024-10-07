using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace EventsAtCSharp;
internal class ProductRepository
{
    private static Product product;

    public ProductRepository()
    {
        product = new Product() { Name = "Telefon", Stock = 5 };
    }

    internal void UpdateStock(int stock)=> product.Stock = stock;


    internal Product GetProduct()=> product;

}
