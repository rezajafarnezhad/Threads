using System.IO;
using System.Threading;

namespace Threads
{
    internal class Program
    {

        public static List<object> Products = new();


        /// <summary>
        /// txt file path
        /// </summary>
        public const string path = @"C:\Users\mReza\source\repos\Threads\Threads\ListProducts.txt";

        static object _lock = new();

        static void Main(string[] args)
        {
            new Thread(AddProduct).Start("Product_1");
            new Thread(AddProduct).Start("Product_2");
            new Thread(AddProduct).Start("Product_3");
            new Thread(AddProduct).Start("Product_4");

            foreach (var item in Products)
            {
                Console.WriteLine($"product: {item} Added");
            }
        }

        static void AddProduct(Object product)
        {
            lock (_lock)
            {
                Thread.Sleep(3000);
                Console.WriteLine($"Thread Number. {Thread.CurrentThread.ManagedThreadId} .is adding product");
                string result = $"ProductName:{product} |";
                File.AppendAllText(path, result);
                Thread.Sleep(1000);
                Products.Add(product);
            }
        }
    }
}
