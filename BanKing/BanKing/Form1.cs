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
                    SetPanels(true, false, false, false, false, true, true, true,false);
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
        void Reset()
        {
            foreach (Control control in this.Controls)
            {
                if (control is Panel || control is Button)
                {
                    control.Visible = false;
                }
            }
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
