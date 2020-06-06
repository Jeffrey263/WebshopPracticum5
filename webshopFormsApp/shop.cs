using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace webshopFormsApp
{
    public partial class Shop : Form
    {
        private string username;
        private string password;

        public Shop(string u, string p)
        {
            InitializeComponent();
            username = u;
            password = p;
            yeet.Text = $"user: {username}, password: {password}.";
        }
    }
}
