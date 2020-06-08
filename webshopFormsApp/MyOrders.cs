using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using webshopFormsApp.ServiceReference1;

namespace webshopFormsApp
{
    public partial class MyOrders : Form
    {
        string username;
        string password;
        User currentUser;

        public MyOrders(string u, string p)
        {
            username = u;
            password = p;

            InitializeComponent();

            using (IwebshopServiceClient shopProxy = new IwebshopServiceClient())
            {
                currentUser = shopProxy.GetUserByName(username, password);
                int[] orders = shopProxy.GetAllOrdersByCustomerID(currentUser.Id, username, password);

                foreach(var o in orders)
                {
                    ordersBox.Items.Add($"{o}");
                }
            }
        }

        private void ordersBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (IwebshopServiceClient shopProxy = new IwebshopServiceClient())
            {
                selectedBox.Items.Clear();
                OrderProductDTO[] orderProducts = shopProxy.GetProductsFromOrder(Int32.Parse(ordersBox.SelectedItem.ToString()), username, password);

                double total = 0;
                foreach(var op in orderProducts)
                {
                    Product p = shopProxy.GetProductById(op.product, username, password);
                    total += p.price * op.quantity;
                    selectedBox.Items.Add($"{p.name} \t|  {op.quantity} \t  ${p.price}");
                }

                totalLabel.Text = "total: $" + total;
            }
        }

        private void ShopBtn_Click(object sender, EventArgs e)
        {
            Shop s = new Shop(username, password);
            s.Show();
            this.Close();
        }
    }
}
