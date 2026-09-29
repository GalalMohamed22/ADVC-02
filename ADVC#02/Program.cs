using System;

namespace ADVC_02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Product> catalog = new(){
                new Product { Id=1, Name="Laptop", Category="Electronics", Price=1200, Stock=10 },
                new Product { Id=2,Name="Phone", Category="Electronics", Price=800, Stock=25 },
                new Product { Id=3, Name="T-Shirt", Category="Clothing", Price=30, Stock=100 },
                new Product { Id=4, Name="Jeans", Category="Clothing", Price=60, Stock=50 },
                new Product { Id=5, Name="Chocolate", Category="Food", Price=5, Stock=200 },
                new Product { Id=6, Name="Coffee Beans", Category="Food", Price=15, Stock=80 },
                new Product { Id=7, Name="C# Book", Category="Books", Price=45, Stock=30 },
                new Product { Id=8, Name="Novel", Category="Books", Price=20, Stock=60 },
                new Product { Id=9,Name="Headphones", Category="Electronics", Price=150, Stock=40 },
                new Product { Id=10, Name="Jacket", Category="Clothing", Price=120, Stock=15 }
            };

            #region Test1

            //List<Product> p1 = FiltirtionFunctions.SearchProduct(catalog, p => p.Category == "Electronics");
            //List<Product> p2 = FiltirtionFunctions.SearchProduct(catalog, p => p.Price < 50);
            //List<Product> p3 = FiltirtionFunctions.SearchProduct(catalog, p => p.Stock > 0);
            //List<Product> p4 = FiltirtionFunctions.SearchProduct(catalog, p => p.Category == "Clothing" && p.Price < 100);
            //foreach (Product p in p1)
            //{
            //    Console.WriteLine(p);
            //}
            //Console.WriteLine("///////////////////////////////");
            //foreach (Product p in p2)
            //{
            //    Console.WriteLine(p);
            //}
            //Console.WriteLine("///////////////////////////////");
            //foreach (Product p in p3)
            //{
            //    Console.WriteLine(p);
            //}
            //Console.WriteLine("///////////////////////////////");
            //foreach (Product p in p4)
            //{
            //    Console.WriteLine(p);
            //}

            // using predicate delegate because fiteration happen throw condetions that return bool


            #endregion


            #region Task 03 : Custom Report Generator

            //Console.WriteLine("Short Report: ");
            //FiltirtionFunctions.PrintReport(catalog, p => Console.WriteLine($"{p.Name} - {p.Price}"));

            //Console.WriteLine("Detailed Report: ");
            //FiltirtionFunctions.PrintReport(catalog, p => Console.WriteLine($"[{p.Category}]{p.Name} | price: {p.Price} | stock: {p.Stock}"));

            // use Action deleget because no return type 

            #endregion



            #region Transform Products

            //Console.WriteLine("--- Summary List ---");
            //FiltirtionFunctions.TransformProducts(catalog, p => $"{p.Name} (${p.Price})");

            //Console.WriteLine("--- Price Labels ---");
            //FiltirtionFunctions.TransformProducts(catalog, p => p.Price > 100 ? $"{p.Name}: Expensive!" : $"{p.Name}: Affordable");

            // use Func because the return type was string

            #endregion


            #region Filter Products

            //List<Product> products = FiltirtionFunctions.FilterProducts(catalog, p => p.Stock < 20);
            //Console.WriteLine("--- Low-Stock Alert: ---");
            //foreach (Product product in products)
            //{
            //    Console.WriteLine($"[LOW STOCK] {product.Name}: only {product.Stock} left!");
            //}

            //// using predicate delegate because fiteration happen throw condetions that return bool

            #endregion



        }


    }

}
