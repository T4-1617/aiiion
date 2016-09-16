using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarDealer
{
    public partial class Form1 : Form
    {
        System.Collections.ArrayList Carlist;

        public Form1()
        {
            InitializeComponent();
            panel1.Visible = false;
            panel2.Visible = false;
            Carlist = new System.Collections.ArrayList();
            Carlist.Add(new Cars() {//lägger till en bil
                Brand = "Subaru ",
                Modell = "impreza",
                hp = "231",
                passangers = "5",
                year = "2015",
                busy = false
            });
            Carlist.Add(new Cars()
            {//lägger till en bil
                Brand = "Volkswagen ",
                Modell = "Tiguan",
                hp = "189",
                passangers = "5",
                year = "2016",
                busy = true
            });
            Carlist.Add(new Cars()
            {//lägger till en bil
                Brand = "Mitsubishi ",
                Modell = "Evolution Lacer",
                hp = "249",
                passangers = "5",
                year = "2014",
                busy = false
            });

            foreach (Cars Cars in Carlist)
            {
                if (Cars.busy == false) //(ska)skriver ut de lediga bilarna
                {
                    listBox1.Items.Add(Cars);
                    listBox1.DisplayMember = "Brand";
                } 
                else if (Cars.busy ==true)//(ska) skriva ut utlånade bilar
                {
                    listBox2.Items.Add(Cars);
                    listBox2.DisplayMember = ("Brand");
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;

            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Cars busy = true;
            panel1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }
    }
}
