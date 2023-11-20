using System.Collections.Concurrent;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Threads
{
    internal class Program
    {
        //    public static List<object> Products = new();
        //    public const string path = @"C:\Users\mReza\source\repos\Threads\Threads\ListProducts.txt";

        //    static object _lock = new();

        //    static void Main(string[] args)
        //    {
        //        new Thread(AddProduct).Start("Product_1");
        //        new Thread(AddProduct).Start("Product_2");
        //        new Thread(AddProduct).Start("Product_3");
        //        new Thread(AddProduct).Start("Product_4");

        //        foreach (var item in Products)
        //        {
        //            Console.WriteLine($"product: {item} Added");
        //        }
        //    }

        //    static void AddProduct(Object product)
        //    {
        //        lock (_lock)
        //        {
        //            Thread.Sleep(3000);
        //            Console.WriteLine($"Thread Number. {Thread.CurrentThread.ManagedThreadId} .is adding product");
        //            string result = $"ProductName:{product} |";
        //            File.AppendAllText(path, result);
        //            Thread.Sleep(1000);
        //            Products.Add(product);
        //        }
        //    }


        //public static List<string> Products = new();
        //public const string path = @"C:\Users\mReza\source\repos\Threads\Threads\ListProducts.txt";
        //private static SemaphoreSlim semaphoreSlim = new SemaphoreSlim(1, 10);
        //static async Task Main(string[] args)
        //{

        //    var tasks = new List<Task>();
          
        //    tasks.Add(AddProduct("A"));
        //    tasks.Add(AddProduct("B"));
        //    tasks.Add(AddProduct("C"));
        //    tasks.Add(AddProduct("D"));
        //    tasks.Add(AddProduct("F"));
        //    tasks.Add(AddProduct("K"));
        //    tasks.Add(AddProduct("O"));
        //    tasks.Add(AddProduct("PO"));
        //    tasks.Add(AddProduct("W"));

        //    await Task.WhenAll(tasks);


        //    foreach (var item in Products)
        //    {
        //        Console.WriteLine($"product: {item} Added");
        //    }
        //    Console.ReadKey();
        //}

        //static async Task AddProduct(string product)
        //{
        //    await semaphoreSlim.WaitAsync();
        //    try
        //    {
        //        await Task.Delay(1000);
        //        Console.WriteLine($"Thread Number. {Thread.CurrentThread.ManagedThreadId} is adding product");
        //        string result = $"ProductName:{product} |";
        //        await File.AppendAllTextAsync(path, result);
        //        Products.Add(product);
        //    }
        //    finally
        //    {
        //        semaphoreSlim.Release();
        //    }
        //}
    }

}


