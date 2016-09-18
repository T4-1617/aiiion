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

           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;//ser till att rätt panel visas
            panel1.Visible = true;
            listBox1.Items.Clear();//rensar listan på lediga bilar
            foreach (Cars Cars in Carlist)//skriver ut de lediga bilarna
            {
                if (Cars.busy == false) 
                {
                    listBox1.Items.Add(Cars);
                    listBox1.DisplayMember = "Brand";
                }
               
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            Cars k = (Cars)listBox1.SelectedItem;
            k.busy = true;//ändrar bilens status till tillgänglig
            panel1.Visible = false;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = true;
            //ser till att rätt panel visas
            listBox2.Items.Clear();//rensar listan på ´hyrda bilar
            foreach (Cars Cars in Carlist)//skriver ut de upptagna lediga bilarna
            {
                if (Cars.busy == true)
                {
                    listBox2.Items.Add(Cars);
                    listBox2.DisplayMember = ("Brand");
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Cars k = (Cars)listBox1.SelectedItem;
            k.busy = false;
        }
    }
}
