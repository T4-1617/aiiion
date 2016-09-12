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
        int id = 100;
        Customer cus = new Customer();
        Random roll = new Random();
        Boolean[] online = new bool[200];

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (id <= 200)
            {
                online[id] = true;
                id++;
                
            }
            else
            {
                
            }
            cus.Firstname = Firstname.Text;
            cus.Lastname = Lastname.Text;
            
            cus.id = id.ToString();
            MyCustomers.Add(cus);

            MessageBox.Show(string.Format("added the customer {0}, id = {1}", cus.Fullname(),id));

             listBox1.Items.Clear();

             foreach (Customer item in MyCustomers)
             {
                 listBox1.Items.Add(item.Fullname());
                listBox1.Items.Add(item.id);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
