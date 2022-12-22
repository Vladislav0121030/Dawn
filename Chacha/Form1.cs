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

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 0)
            {
                listBox1.Items.Add("Наименнование: --- ");
            }
            else
            {
                listBox1.Items.Add("Наименнование: " + textBox1.Text);
            }
            if (textBox2.TextLength == 0)
            {
                listBox1.Items.Add("Артикул: --- ");
            }
            else
            {
                listBox1.Items.Add("Артикул: " + textBox2.Text);
            }
            if (textBox3.TextLength == 0)
            {
                listBox1.Items.Add("Группа: --- ");
            }
            else
            {
                listBox1.Items.Add("Группа: " + textBox3.Text);
            }
            if (textBox4.TextLength == 0)
            {
                listBox1.Items.Add("Сорт: --- ");
            }
            else
            {
                //if()
                listBox1.Items.Add("Сорт: " + textBox4.Text);
            }
            listBox1.Items.Add("Дата поставки: " + dateTimePicker1.Text);
            if (textBox6.TextLength == 0)
            {
                listBox1.Items.Add("Признак поставки по договору: --- ");
            }
            else
            {
                //if()
                listBox1.Items.Add("Признак поставки по договору: " + textBox6.Text);
            }
            if (textBox7.TextLength == 0)
            {
                listBox1.Items.Add("Количество: --- шт.");
            }
            else
            {
                //if()
                listBox1.Items.Add("Количество: " + textBox7.Text + " шт.");
            }
            if (textBox8.TextLength == 0)
            {
                listBox1.Items.Add("Поставщик: --- ");
            }
            else
            {
                //if()
                listBox1.Items.Add("Поставщик: " + textBox8.Text);
            }
            listBox1.Items.Add("  ----------------------------------------------");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}