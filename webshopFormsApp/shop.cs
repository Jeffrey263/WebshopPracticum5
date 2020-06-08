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
    public partial class Shop : Form
    {
        private string username;
        private string password;
        private Product[] products;
        private Product selectedProduct;
        private List<Order_Product> orderList = new List<Order_Product>();
        private User currentUser;

        public Shop(string u, string p)
        {
            InitializeComponent();

            productName.Text = "";
            productPrice.Text = "";
            ProductDesc.Text = "";
            basketAlert.Text = "";

            username = u;
            password = p;
            welcomeMessage.Text += username + ".";
            LoadProducts();

            LoadUserBalance();

        }

        private void LoadUserBalance()
        {
            using (IwebshopServiceClient shopProxy = new IwebshopServiceClient())
            {
                currentUser = shopProxy.GetUserByName(username, password);
            }
            balanceLabel.Text = "Balance: " + currentUser.balance;
        }

        private void LoadProducts()
        {
            using (IwebshopServiceClient shopProxy = new IwebshopServiceClient())
            {
                products = shopProxy.GetAllProducts(username, password);

                foreach(Product p in products)
                {
                    productsBox.Items.Add($"{p.name} \t | ${p.price}");
                }
            }
        }

        private void productsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (IwebshopServiceClient shopProxy = new IwebshopServiceClient())
            {
                int index = productsBox.SelectedIndex + 1;
                Product p = shopProxy.GetProductById(index, username, password);

                productName.Text = p.name;
                productPrice.Text = "$" + p.price;
                ProductDesc.Text = p.description;

                selectedProduct = p;
            }              
        }

        private void addToBasketPressed(object sender, EventArgs e)
        {
            if(Decimal.ToInt32(quantity.Value) <= selectedProduct.stock)
            {
                basketBox.Items.Add($"{selectedProduct.name} | {quantity.Value}");

                Order_Product op = new Order_Product
                {
                    quantity = Decimal.ToInt32(quantity.Value),
                    Product = selectedProduct
                };

                orderList.Add(op);
                basketAlert.Text = "";
            }
            else
            {
                basketAlert.Text = "product is out of stock.";
            }


        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            productsBox.Items.Clear();
            LoadProducts();
            LoadUserBalance();
        }

        private void removeSelected_Click(object sender, EventArgs e)
        {
            basketBox.Items.Clear();
            basketAlert.Text = "";
        }

        private void PlaceOrder_Click(object sender, EventArgs e)
        {
            NewOrder oPage = new NewOrder(username, password, orderList);
            oPage.Show();
        }

        private void OrdersBtn_Click(object sender, EventArgs e)
        {
            MyOrders myOrders = new MyOrders(username, password);
            myOrders.Show();
            this.Close();
        }
    }
}
