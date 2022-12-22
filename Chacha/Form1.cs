using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Chacha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //string[] countries = { "Бразилия", "Аргентина", "Чили", "Уругвай", "Колумбия" };
            //listBox1.Items.AddRange(countries);
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.TextLength == 1)  
            {
                textBox1.Text = " --- ";
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Наименнование: " + textBox1.Text);
            listBox1.Items.Add("Артикул: " + textBox2.Text);
            listBox1.Items.Add("Группа: " + textBox3.Text);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
    }
}