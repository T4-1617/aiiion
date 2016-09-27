using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanKing
{
    public partial class Form1 : Form
    {
        private System.Collections.ArrayList CustomerList;
        Boolean admin;
        public Form1()
        {
            InitializeComponent();
            CustomerList = new System.Collections.ArrayList();
            SetPanels(false, false, false, false, false, false, false, false, false);

            Customer c = new Customer() { CustomerName = "Urban" };
            c.CreateAccount(1200);
            CustomerList.Add(c);
            foreach (Customer Customer in CustomerList)
            {
                listBox1.Items.Add(Customer);
                listBox1.DisplayMember = "CustomerName";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "Customer":
                    admin = false;
                    SetPanels(false, false, false, false,false,false,false,true,false);
                    break;
                case "Employee":
                    admin = true;
                    SetPanels(false, false, false, false, false, false,false, true,false);
                    break;
                default:
                    break;
            }
        }

        private void SetPanels(bool panAcc, bool PanCusBtns, bool PanWithdraw, bool PanDeposit,
            bool PanBalance, bool PanNewAcc, bool BtnDetails, bool Field1, bool Field3)
        {
            panAccounts.Visible = panAcc;
            panCusBtns.Visible = PanCusBtns;
            panWithdraw.Visible = PanWithdraw;
            panDeposit.Visible = PanDeposit;
            panBalance.Visible = PanBalance;
            panNewAcc.Visible = PanNewAcc;
            btnDetails.Visible = BtnDetails;
            listBox1.Visible = Field1;
            listBox3.Visible = Field3;                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Customer c = (Customer)listBox1.SelectedItem;
            panAccounts.Visible = true;
            listBox2.Items.Clear();
            foreach (Account account in c.GetAccounts())
            {
                listBox2.Items.Add(account);
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            switch (admin)//skriver ut panelerna som respektive användare behöver
            {
                case true:
                    SetPanels(true, false, false, false, false, false, true, true, false);
                    break;
                case false:
                    SetPanels(true, true, false, false, false, false, false, true, false);
                    break;
                default:
                    break;
            } 
        }

        private void btnBalance_Click(object sender, EventArgs e)
        {
            Account a = (Account)listBox2.SelectedItem;//visar hur mycket pengar som finns på kontot
            textBox3.Text = a.Balance.ToString();
            SetPanels(true, true, false, false, true, false, false, true, false);
            
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            SetPanels(true, true, true, false, false, false, false, true, false);
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            SetPanels(true, true, false, true, false, false, false, true, false);
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            SetPanels(true, false, false, false, false, false, true, true, true);
        }

        private void btnOpenNew_Click(object sender, EventArgs e)
        {
            SetPanels(true, false, false, false, false, true, false, true, false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //tar ut pengar
            Account a = (Account)listBox2.SelectedItem;
            a.Withdraw(decimal.Parse(textBox2.Text));
            SetPanels(true, true, false, false, false, false, false, true, false);
            textBox2.Text = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Account a = (Account)listBox2.SelectedItem;
            a.Deposit(decimal.Parse(textBox1.Text));
            SetPanels(true, true, false, false, false, false, false, true, false);
            textBox1.Text = null;
        }
    }
}
