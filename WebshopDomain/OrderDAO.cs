using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebshopDomain
{
    public class OrderDAO
    {
        //geef all orders van een klant
        public List<int> GetAllOrdersByCustomerID(Int32 cId)
        {
            using (Model1Container db = new Model1Container())
            {
                List<Order> orders = db.OrderSet.ToList();

                IEnumerable<int> ordersByCustomer = from o in orders
                                           where o.User.Id == cId
                                           select o.Id;

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
                double total = 0;
                List<Order_Product> productsForDB = new List<Order_Product>();

                //voeg alle order_producten toe
                foreach (Order_Product op in producten)
                {
                    //haal product op uit database
                    Product dbProduct = db.ProductSet.Find(op.Product.Id);
                    total += dbProduct.price * op.quantity;

                    //haal de producten van de stock
                    dbProduct.stock -= op.quantity;
                    db.ProductSet.AddOrUpdate(dbProduct);

                    //vervang op.product met product uit database
                    op.Product = dbProduct;
                    productsForDB.Add(op);

                    db.Order_ProductSet.Add(op);
                }

                Order o = new Order
                {
                    User = db.UserSet.Find(u.Id),
                    producten = productsForDB
                };

                User dbUser = db.UserSet.Find(u.Id);
                dbUser.balance -= total;

                db.UserSet.AddOrUpdate(dbUser);
                db.OrderSet.Add(o);
                db.SaveChanges();
            }
        }

        public List<OrderProductDTO> GetProductsFromOrder(int orderID)
        {
            using (Model1Container db = new Model1Container())
            {
                Order order = db.OrderSet.Find(orderID);
                var orderProducts = order.producten;

                List<OrderProductDTO> opDTO = new List<OrderProductDTO>();
                foreach(Order_Product op in orderProducts)
                {
                    opDTO.Add(new OrderProductDTO()
                    {
                        product = op.Product.Id,
                        quantity = op.quantity
                    });
                }

                return opDTO;
            }
        }
    }
}
