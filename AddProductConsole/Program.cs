using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebshopDomain;

namespace AddProductConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductDAO pDao = new ProductDAO();

            Console.WriteLine("Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Description: ");
            string description = Console.ReadLine();

            Console.WriteLine("Quantity: ");
            Int32 quantity = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Quantity: ");
            NumberFormatInfo provider = new NumberFormatInfo();
            provider.NumberDecimalSeparator = ", ";
            provider.NumberGroupSeparator = ".";
            double price = Convert.ToDouble(Console.ReadLine(), provider);

            Product p = new Product();
            p.name = name;
            p.description = description;
            p.stock = quantity;
            p.price = price;

            pDao.SaveProduct(p);

            Product pGet = pDao.GetProductById(2);
            Console.WriteLine($"name: {pGet.name},\ndecription: {pGet.description}, \nPrice: {pGet.price},\nStock: {pGet.stock}.");
            Console.ReadKey();

        }
    }
}
