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
        Boolean busy;
        public Form1()
        {
            InitializeComponent();
            panel1.Visible = false;
            Carlist = new System.Collections.ArrayList();
            Carlist.Add(new Cars() {//lägger till en bil
                Brand="Subaru ",
                Modell="impreza",
                hp = "231",
                passangers="5",
                year="2015"
            });
            Carlist.Add(new Cars()
            {//lägger till en bil
                Brand = "Volkswagen ",
                Modell = "Tiguan",
                hp = "189",
                passangers = "5",
                year = "2016"
            });
            Carlist.Add(new Cars()
            {//lägger till en bil
                Brand = "Mitsubishi ",
                Modell = "Evolution Lacer",
                hp = "249",
                passangers = "5",
                year = "2014"
            });

            foreach (var Cars in Carlist)
            {
                if (busy == false) //skriver ut de lediga bilarna
                {
                    listBox1.Items.Add(Cars);
                    listBox1.DisplayMember = "Brand";
                } 
                else
                {
                  //  listBox2.Items.Add(Cars);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;

            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            busy = true;
            panel1.Visible = false;
        }
    }
}
