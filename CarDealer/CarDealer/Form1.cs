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
        int avalible = 2;

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
                busy = false,
                customer = string.Empty
            });
            Carlist.Add(new Cars()
            {//lägger till en bil
                Brand = "Volkswagen ",
                Modell = "Tiguan",
                hp = "189",
                passangers = "5",
                year = "2016",
                busy = true,
                customer = "Urban Suedi"
            });
            Carlist.Add(new Cars()
            {//lägger till en bil
                Brand = "Mitsubishi ",
                Modell = "Evolution Lacer",
                hp = "249",
                passangers = "5",
                year = "2014",
                busy = false,
                customer = string.Empty
            });
            label1.Text = String.Format("Det finns {0} bilar tillgängliga", avalible);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;//ser till att rätt panel visas
            panel1.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false;
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
            panel1.Visible = true;
            panel2.Visible = true;
            panel3.Visible = true;
            panel4.Visible = true;
            panel5.Visible = true;
            if (avalible > 0)//ser till att värdet för lediga bilar kan bli negativt
            {
                avalible--;
                label1.Text = String.Format("Det finns {0} bilar tillgängliga", avalible);//uppdaterar hur många bilar det finns
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = true;
            panel3.Visible = true;
            panel4.Visible = false;//ser till att rätt panel visas

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false; 
            //ser till att rätt panel visas
            listBox2.Items.Clear();//rensar listan på ´hyrda bilar
            foreach (Cars Cars in Carlist)//skriver ut de upptagna bilarna
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
            Cars k = (Cars)listBox2.SelectedItem;
            k.busy = false;
            avalible++;
            label1.Text = String.Format("Det finns {0} bilar tillgängliga", avalible);
            panel1.Visible = true;
            panel2.Visible = true;
            panel3.Visible = true;
            panel4.Visible = true;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Carlist.Add(new Cars()
            {                   //lägger till en bil
                Brand = textBox1.Text,
                Modell = textBox2.Text,
                hp = textBox3.Text,
                passangers = textBox4.Text,
                year = textBox5.Text,
                busy = false
                
            });
            avalible++;
            label1.Text = String.Format("Det finns {0} bilar tillgängliga", avalible);//ser till att rätt antal lediga bilar visas
            panel1.Visible = true;
            panel2.Visible = true;
            panel3.Visible = true;
            panel4.Visible = true;//visar rätt panel
            textBox1.Text = null;//rensar gammal data från textbox
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Cars k = (Cars)listBox1.SelectedItem;
            k.customer = textBox6.Text;//anger vem som hyr bilen
            panel5.Visible = false;
        }




        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            foreach (Cars Cars in Carlist)//skriver ut de upptagna bilarna och vem som hyr dem
            {
                if (Cars.busy == true)
                {
                    listBox3.Items.Add(Cars.ToString());
                    
                }
            }
        }
    }
}
