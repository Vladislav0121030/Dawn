using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

<<<<<<< HEAD
            comboBox1.Items.Add("Природный");
            comboBox1.Items.Add("Товарный");

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

=======
            comboBox1.Items.AddRange(new string[] { "Природная ", "Товарная " });
            comboBox2.Items.AddRange(new string[] { "I ", "II ", "III " });
            comboBox3.Items.AddRange(new string[] { "Возмездный ", "Взаимный ", "Консенсуальный " });
            //comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
>>>>>>> 862af4224477a448a945f27c3335c7a2e70d2d65
        }
        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }
        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (Char.IsLetterOrDigit(number))
            {
                e.Handled = true;
            }
        }
        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (Char.IsLetterOrDigit(number))
            {
                e.Handled = true;
            }
        }
        private void comboBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (Char.IsLetterOrDigit(number))
            {
                e.Handled = true;
            }
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
<<<<<<< HEAD
            //listBox1.Items.Add("Группа: " + comboBox1.Text);
            if (comboBox1.Text == "")
=======
            if (comboBox1.Text.Length == 0)
>>>>>>> 862af4224477a448a945f27c3335c7a2e70d2d65
            {
                listBox1.Items.Add("Группа сорта: --- ");
            }
            else
            {
<<<<<<< HEAD
                listBox1.Items.Add("Группа: " + comboBox1.Text);
                if (comboBox1.Text == "Природный")
                {

                }
                else
                {
                    comboBox2.Items.AddRange(new string[] { "I сорт ", "II сорт ", "III сорт " });
                }
            }
            listBox1.Items.Add("Дата поставки: " + dateTimePicker1.Text);
=======
                listBox1.Items.Add("Группа сорта: " + comboBox1.Text);
            }
            if (comboBox2.Text.Length == 0)
            {
                listBox1.Items.Add("Сорт: --- ");
            }
            else
            {
                listBox1.Items.Add("Сорт: " + comboBox2.Text);
            }
            if (comboBox3.Text.Length == 0)
            {
                listBox1.Items.Add("Признак поставки по договору: --- ");
            }
            else
            {
                listBox1.Items.Add("Признак поставки по договору: " + comboBox3.Text);
            }
>>>>>>> 862af4224477a448a945f27c3335c7a2e70d2d65
            if (textBox7.TextLength == 0)
            {
                listBox1.Items.Add("Количество: --- шт.");
            }
            else
            {
                //if()
                listBox1.Items.Add("Количество: " + textBox7.Text + "   шт.");
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
            listBox1.Items.Add("   ----------------------------------------------");
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.ResetText();
<<<<<<< HEAD
=======
            comboBox2.ResetText();
            comboBox3.ResetText();
            //comboBox2.Items.Clear();
>>>>>>> 862af4224477a448a945f27c3335c7a2e70d2d65
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

<<<<<<< HEAD

=======
        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*"
            };
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Regex regex = new Regex(@"[А-Я а-я]+[:]{1}\s[А-Я а-я a-z A-Z 0-9]+");
                string selectedFile = openFileDialog.FileName;
                string[] input = File.ReadAllLines(selectedFile);
                for(int a = 0; a < input.Length; a++)
                {
                    if (regex.IsMatch(input[a])) 
                    {
                        listBox1.Items.Add(regex.Match(input[a]));
                        if (input[a] == "Дата поставки:")
                        {
                            listBox1.Items.Add("   ----------------------------------------------");
                        }
                    }
                }
            }
        }
>>>>>>> 862af4224477a448a945f27c3335c7a2e70d2d65
    }
}