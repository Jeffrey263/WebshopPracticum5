using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebshopDomain
{
    //Deze klasse regelt alle CRUD statements rondom de klasse product.
    public class ProductDAO
    {
        //Sla een nieuw product op
        public void SaveProduct(Product p)
        {
            using (Model1Container db = new Model1Container())
            {
                db.ProductSet.Add(p);

                db.SaveChanges();
            }
        }

        public Product GetProductById(Int32 id)
        {
            using (Model1Container db = new Model1Container())
            {
                Product p = db.ProductSet.Find(id);
                return p;
            }
        }
    }
}
