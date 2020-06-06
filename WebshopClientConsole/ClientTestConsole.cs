using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebshopClientConsole.webshopService;

namespace WebshopClientConsole
{
    class ClientTestConsole
    {
        static void Main(string[] args)
        {
            using(IwebshopServiceClient shopProxy = new IwebshopServiceClient()) 
            {
                Console.WriteLine(shopProxy.CheckUserAuthentication("yeet", "yeet69"));

                Console.WriteLine("\n----------------| USER |---------------------------------\n");
                Console.WriteLine("new user? [y/n]");
                var newU = Console.ReadLine();
                if (newU.Equals("y"))
                {
                    Console.WriteLine("Name: ");
                    string uName = Console.ReadLine();
                    Console.WriteLine(shopProxy.SaveNewUser(uName));
                }

                //LOGIN
                //Console.Write("username:");
                string username = "Jeff263";
                //Console.Write("\npassword:");
                string password = "Fukm*GK8";

                User currenUser = shopProxy.GetUserByName(username, password);

                var users = shopProxy.GetAllUsers(username, password);
                foreach (User u in users)
                {
                    Console.WriteLine($"\nname: {u.name},\npassword: {u.password},\nbalance: {u.balance}");
                }

                Console.WriteLine("\n----------------| PRODUCT |---------------------------------\n");

                //Add new product
                Console.WriteLine("new product? [y/n]");
                var newP = Console.ReadLine();
                if (newP.Equals("y"))
                {
                    Console.WriteLine("Name: ");
                    string name = Console.ReadLine();

                    Console.WriteLine("Description: ");
                    string description = Console.ReadLine();

                    Console.WriteLine("Stock: ");
                    Int32 quantity = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Price: ");
                    NumberFormatInfo provider = new NumberFormatInfo();
                    provider.NumberDecimalSeparator = ", ";
                    provider.NumberGroupSeparator = ".";
                    double price = Convert.ToDouble(Console.ReadLine(), provider);

                    shopProxy.SaveProduct(name, description, quantity, price);
                }

                var pList = shopProxy.GetAllProducts(username, password);

                foreach (Product pGet in pList)
                {
                    Console.WriteLine($"\nname: {pGet.name},\ndecription: {pGet.description}, \nPrice: {pGet.price},\nStock: {pGet.stock}.");
                }

                var pd = shopProxy.GetProductById(1, username, password);
                Console.WriteLine($"\nname: {pd.name}");
                Console.ReadKey();

                Console.WriteLine("\n----------------| ORDER |---------------------------------\n");

                var p1 = shopProxy.GetProductById(1, username, password);
                var p2 = shopProxy.GetProductById(2, username, password);

                Order_Product op1 = new Order_Product
                {
                    quantity = 7,
                    Product = p1
                };

                Order_Product op2 = new Order_Product
                {
                    quantity = 8,
                    Product = p2
                };

                Order_Product[] opList = new Order_Product[] { op1, op2 };


                shopProxy.SaveNewOrder(currenUser, opList, username, password);

                //Order foundOrder = shopProxy.GetOrderByID(1, username, password);

                //Console.WriteLine($"order:\ncustomer: {foundOrder.User.name}");

            }
        }
    }
}

//Klaas420
//SgL15F%y
