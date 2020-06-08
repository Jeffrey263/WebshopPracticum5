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
    public partial class NewOrder : Form
    {
        private string username;
        private string password;
        private List<Order_Product> orderList = new List<Order_Product>();
        private User currentUser;
        private double total = 0;

        public NewOrder(string u, string p, List<Order_Product> o)
        {
            username = u;
            password = p;
            orderList = o;

            using (IwebshopServiceClient shopProxy = new IwebshopServiceClient())
            {
                currentUser = shopProxy.GetUserByName(username, password);
            }

            InitializeComponent();
            orderProducts.Items.Clear();

            foreach(var op in orderList)
            {
                total += op.Product.price * op.quantity;
                orderProducts.Items.Add($"{op.Product.name} \t |   {op.quantity} \t |   $ {op.Product.price * op.quantity}");
            }

            totalLabel.Text = "total: $" + total;
            balanceLabel.Text = "your balance: $" +  currentUser.balance;
            alertLabel.Text = "";
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            orderProducts.Items.Clear();
            this.Close();
        }

        private void SendOrder_Click(object sender, EventArgs e)
        {
            if(total < currentUser.balance)
            {
                using (IwebshopServiceClient shopProxy = new IwebshopServiceClient())
                {
                    shopProxy.SaveNewOrder(currentUser, orderList.ToArray(), username, password);
                }
                orderProducts.Items.Clear();
                this.Close();
            }
            else
            {
                alertLabel.Text = "Not enough balance.";
            }
        }
    }
}
