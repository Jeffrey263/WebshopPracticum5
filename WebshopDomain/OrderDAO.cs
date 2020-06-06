using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebshopDomain
{
    public class OrderDAO
    {
        //geef all orders van een klant
        public List<Order> GetAllOrdersByCustomerID(Int32 cId)
        {
            using (Model1Container db = new Model1Container())
            {
                List<Order> orders = db.OrderSet.ToList();

                IEnumerable<Order> ordersByCustomer = from o in orders
                                           where o.User.Id == cId
                                           select o;

                return ordersByCustomer.ToList();
            }
        }
        
        //geef order met specifiek ID
        public Order GetOrderByID(Int32 id)
        {
            using (Model1Container db = new Model1Container())
            {
                Order o = db.OrderSet.Find(id);
                return o;
            }
        }

        //Sla een nieuw order op.
        public void SaveNewOrder(User u, List<Order_Product> producten)
        {
            Console.WriteLine("[DAO] - now saving order");
            using (Model1Container db = new Model1Container())
            {
                //voeg alle order_producten toe
                foreach (Order_Product op in producten)
                {
                    db.Order_ProductSet.Add(op);
                }

                Order o = new Order
                {
                    User = u,
                    producten = producten
                };

                db.OrderSet.Add(o);
                db.SaveChanges();
            }
        }
    }
}
