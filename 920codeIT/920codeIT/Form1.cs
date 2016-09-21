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
        public Form1()
        {
            InitializeComponent();
            panel1.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;

        } 
        private void label5_Click(object sender, EventArgs e)
        {

        }

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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
