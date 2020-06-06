using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using webshopFormsApp.ServiceReference1;

namespace webshopFormsApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            alert.Text = "";
            userField.Text = "Jeff263";
            passField.Text = "Fukm*GK8";
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            using (IwebshopServiceClient shopProxy = new IwebshopServiceClient())
            {
                try
                {
                    bool userOK = shopProxy.CheckUserAuthentication(userField.Text, passField.Text);

                    if (userOK)
                    {
                        Shop shop = new Shop(userField.Text, passField.Text);

                        shop.Show();
                        this.Hide();
                    }
                    else { alert.Text = "username/password is incorrect."; }
                }
                catch (EndpointNotFoundException y)
                {
                    alert.Text = "service ofline";
                }
            }
        }
    }
}
