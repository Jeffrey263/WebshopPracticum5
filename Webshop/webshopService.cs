using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WebshopDomain;

namespace Webshop
{
    public class webshopService : IwebshopService
    {

        private ProductDAO pDao = new ProductDAO();
        private UserDAO uDao = new UserDAO();
        private OrderDAO oDao = new OrderDAO();

        //----------------| ALLE PRODUCT SERVICES |----------------------------------------------------
        public List<Product> GetAllProducts(string username, string password)
        {
            if (CheckUserAuthentication(username, password))
            {
                Console.WriteLine("returning all products");
                return pDao.GetAllProducts(); 
            }

            return null;
        }

        public Product GetProductById(Int32 id, string username, string password)
        {
            if (CheckUserAuthentication(username, password))
            {
                Console.WriteLine($"returning product with id: {id}");
                return pDao.GetProductById(id);
            }

            return null;
        }

        public void SaveProduct(string name, string desc, Int32 stock, double price)
        {
            Product p = new Product
            {
                name = name,
                description = desc,
                stock = stock,
                price = price
            };

            pDao.SaveProduct(p);
        }

        //----------------| ALLE USER SERVICES |----------------------------------------------------
        public List<User> GetAllUsers(string username, string password)
        {
            if(CheckUserAuthentication(username, password))
            {
                Console.WriteLine("Getting all users");
                return uDao.GetAllUsers();
            }

            return null;
        }

        public User GetUserByID(Int32 id, string username, string password)
        {
            if (CheckUserAuthentication(username, password))
            {
                Console.WriteLine("getting user: " + id);
                return uDao.GetUserById(id);
            }

            return null;
        }

        public User GetUserByName(string username, string password)
        {
            if (CheckUserAuthentication(username, password))
            {
                Console.WriteLine("getting user: " + username);
                return uDao.GetUserByName(username);
            }

            return null;
        }

        public String SaveNewUser(string name)
        {
            Console.WriteLine("saving user: " + name);
            return uDao.SaveNewUser(name);
        }

        //----------------| ALLE ORDER SERVICES |----------------------------------------------------
        public List<int> GetAllOrdersByCustomerID(Int32 cId, string username, string password)
        {
            if (CheckUserAuthentication(username, password))
            {
                Console.WriteLine("Getting all orders from customer: " + cId);
                return oDao.GetAllOrdersByCustomerID(cId);
            }
            return null;
        }

        public Order GetOrderByID(Int32 id, string username, string password)
        {
            if (CheckUserAuthentication(username, password))
            {
                Console.WriteLine("Getting order: " + id);
                return oDao.GetOrderByID(id); 
            }
            return null;
        }

        public void SaveNewOrder(User u, List<Order_Product> producten, string username, string password)
        {
                if (CheckUserAuthentication(username, password))
                {
                    Console.WriteLine("Saving order for user: " + u.name);
                    oDao.SaveNewOrder(u, producten);
                }
        }

        public List<OrderProductDTO> GetProductsFromOrder(int orderID, string username, string password)
        {
            if (CheckUserAuthentication(username, password))
            {
                Console.WriteLine("Getting products for order: " + orderID);
                return oDao.GetProductsFromOrder(orderID);
            }
            return null;
        }

        //----------------| AUTHENTICATIE |----------------------------------------------------
        public bool CheckUserAuthentication(string username, string password)
        {
            Console.WriteLine("checking user: " + username);
            return uDao.CheckUserAuthentication(username, password);
        }
    }
}
