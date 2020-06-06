using System;
using System.Collections.Generic;
using System.Linq;

namespace WebshopDomain
{
    //Deze klasse regelt alle CRUD statements rondom de klasse product.
    public class ProductDAO
    {
        //Haal alle producten op
        public List<Product> GetAllProducts() 
        {
            using (Model1Container db = new Model1Container())
            {
                List<Product> products = db.ProductSet.ToList();
                return products;
            }
        }

        //Haal product op met specifiek ID
        public Product GetProductById(Int32 id)
        {
            using (Model1Container db = new Model1Container())
            {
                Product p = db.ProductSet.Find(id);
                return p;
            }
        }

        //Sla een nieuw product op
        public void SaveProduct(Product p)
        {
            using (Model1Container db = new Model1Container())
            {
                db.ProductSet.Add(p);
                db.SaveChanges();
            }
        }
    }
}
