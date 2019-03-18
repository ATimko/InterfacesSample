using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product()
            {
                Name = "Widget",
                Price = 1.99
            };
            var p2 = new Product()
            {
                Name = "Keyboard",
                Price = 9.99
            };

            List<Product> prods = new List<Product>
            {
                p,
                p2
            };
            prods.Sort();


            DisplayObject(p);

            var phone = new MobilePhone()
            {
                OS = "Android",
                ScreenSize = 5.7
            };
            DisplayObject(phone);

            Console.ReadKey();
        }
        static void DisplayObject(IDisplayable data)
        {
            Console.WriteLine(data.GetDisplayText());
        }
    }
}
