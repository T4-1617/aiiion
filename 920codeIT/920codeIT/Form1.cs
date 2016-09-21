using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _920codeIT
{
    public partial class Form1 : Form
    {
        System.Collections.ArrayList peopleList;
        int customersID = 0;
        int employed = 0;
        int Suppliers = 0;
        public Form1()
        {
            InitializeComponent();
            panel1.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            label2.Text = string.Format("Du har {0} kunder, {1} anställda och {2} leverantörer registerarde",customersID,employed,Suppliers);

        } 
        private void label5_Click(object sender, EventArgs e) { }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "Kund":
                    panel1.Visible = true;
                    panel3.Visible = false;
                    panel4.Visible = false;
                    break;
                case "Anställd":
                    panel1.Visible = true;
                    panel3.Visible = true;
                    panel4.Visible = false;
                    break;
                case "Leverantör":
                    panel1.Visible = true;
                    panel3.Visible = false;
                    panel4.Visible = true;
                    break;
                default:
                    break;
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e){}

        private void button1_Click(object sender, EventArgs e)
        {
            peopleList = new System.Collections.ArrayList();
            switch (comboBox1.Text)
            {
                case "Kund":
                    customersID++;
                    peopleList.Add(new Customers()
                    {//lägger till en ny kund
                        firstname=textBox1.Text,
                        lastname=textBox2.Text,
                        phoneNbr=textBox3.Text,
                        customerID=String.Format("{0}",customersID),
                    });
                    label2.Text = string.Format("Du har {0} kunder, {1} anställda och {2} leverantörer registerarde", customersID, employed, Suppliers);
                    break;
                case "Anställd":
                    employed++;
                    peopleList.Add(new Employees()
                    {//lägger till en ny anställd
                        firstname = textBox1.Text,
                        lastname = textBox2.Text,
                        phoneNbr = textBox3.Text,
                        employeeID = textBox4.Text,
                        title = textBox5.Text,
                        pay=textBox6.Text,
                    });
                    label2.Text = string.Format("Du har {0} kunder, {1} anställda och {2} leverantörer registerarde", customersID, employed, Suppliers);
                    break;
                case "Leverantör":
                    Suppliers++;
                    peopleList.Add(new Supplier()
                    {//lägger till en ny leverantör
                        firstname = textBox1.Text,
                        lastname = textBox2.Text,
                        phoneNbr = textBox3.Text,
                        company = textBox7.Text,
                    });
                    label2.Text = string.Format("Du har {0} kunder, {1} anställda och {2} leverantörer registerarde", customersID, employed, Suppliers);
                    break;
                default:
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;
            textBox6.Text = null;
            textBox7.Text = null;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
