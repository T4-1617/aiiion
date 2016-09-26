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

            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1)
            {
                default:
                    break;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
