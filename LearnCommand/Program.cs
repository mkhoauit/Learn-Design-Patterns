using LearnCommand.Classes;
using System;

namespace LearnCommand
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            BuyProduct buyProduct = new BuyProduct(product);
            SellProduct sellProduct = new SellProduct(product);
            

            Client client = new Client();

            client.takeIOrder(buyProduct);
            client.takeIOrder(sellProduct);

            client.placeOrders();
        }
    }
}
