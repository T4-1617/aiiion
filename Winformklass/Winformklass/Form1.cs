using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winformklass
{
    public partial class Form1 : Form
    {
        System.Collections.ArrayList MyCustomers = new System.Collections.ArrayList();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer cus = new Customer();

            cus.Firstname = Firstname.Text;
            cus.Lastname = Lastname.Text;

            MyCustomers.Add(cus);

            MessageBox.Show(string.Format("added the customer {0}", cus.Fullname()));
        }
    }
}
