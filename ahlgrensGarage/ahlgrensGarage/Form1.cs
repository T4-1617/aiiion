using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ahlgrensGarage
{
    public partial class Form1 : Form
    {
        System.Collections.ArrayList MyTransport;
        Transport temp;
        public Form1()
        {
            InitializeComponent();

            panel1.Visible = false;
            MyTransport = new System.Collections.ArrayList();

            Transport a = new Transport() {Type="halvkombi", Car = "pergout 206 gti", reg = "XYM603", door = "3", hp = "136" };
            Transport b = new Transport() { Type = "Sport", Car = "Ferrari 911", reg = "UMP911", door = "3", hp = "391" };
            Transport c = new Transport() { Type = "kombi", Car = "Volkswagen Passat TDI", reg = "NOB000", door = "5", hp = "171" };
            Transport d = new Transport() { Type = "SUV", Car = "Tesla Modell X", reg = "KOL909", door = "5", hp = "270" };
            Transport e = new Transport() { Type = "Sedan", Car = "Tesla Modell S", reg = "BRM711", door = "5", hp = "286" };
            MyTransport.Add(a);
            MyTransport.Add(b);
            MyTransport.Add(c);
            MyTransport.Add(d);
            MyTransport.Add(e);
            listBox1.Items.Add(a);
            listBox1.Items.Add(b);
            listBox1.Items.Add(c);
            listBox1.Items.Add(d);
            listBox1.Items.Add(e);
            listBox1.DisplayMember = "Car";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel1.Visible = true;

            //Transport a = (Transport)MyTransport[listBox1.SelectedIndex];
            Transport k = (Transport)listBox1.SelectedItem;
            textBox1.Text = string.Format("{0}", k.Type);
            textBox2.Text = string.Format("{0}", k.reg);
            textBox3.Text = string.Format("{0}", k.door);
            textBox4.Text = string.Format("{0}", k.hp);
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Transport k = (Transport)listBox1.SelectedItem;
            k.Type = textBox1.Text;
            k.reg = textBox2.Text;
            k.door = textBox3.Text;
            k.hp = textBox4.Text;




        }
    }
}
