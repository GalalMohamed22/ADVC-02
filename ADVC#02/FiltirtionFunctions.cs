using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADVC_02
{
    internal static class FiltirtionFunctions
    {

        public static List<Product> SearchProduct(List<Product> p,Predicate<Product> filter)
        {

            List<Product> products = new List<Product>();
            foreach (Product item in p)
            {
                if(filter(item)) products.Add(item);
            }
            return products;
        }
        public static void PrintReport(List<Product> p, Action<Product> act)
        {
            foreach (Product item in p)
            {
                act(item);
            }
        }
        public static void TransformProducts(List<Product> p, Func<Product,string> fun)
        {
            foreach (Product item in p)
            {
                Console.WriteLine(fun(item));
            }
        }

        public static List<Product> FilterProducts(List<Product> p, Predicate<Product> predicate)
        {
            List<Product> products = new List<Product>();
            foreach (Product item in p)
            {
                if (predicate(item)) products.Add(item);
            }
            return products;
        }


    }
}
