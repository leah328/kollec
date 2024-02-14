using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kkkkk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Hashtable ht = new Hashtable();
        Hashtable ht1 = new Hashtable();
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox2.Text == "" && textBox1.Text == "")
            {
                MessageBox.Show("заполните поля!");               
            }
            else
            if (textBox2.Text == "")
            {
                MessageBox.Show("поле с телефоном должно быть заполнено");             
            }
            else
            if (textBox1.Text == "")
            {
                MessageBox.Show("поле фамилия должно быть заполнено");               
            }
            else
                for (int i = 0; i < textBox1.Text.Length; i++)
                {
                    if (!char.IsLetter(textBox1.Text[i]))
                    {
                        MessageBox.Show("неправильно введена фамилия");
                        break;
                    }
                }
            for (int i = 0; i < textBox2.Text.Length; i++)
            {
                if (char.IsLetter(textBox2.Text[i]))
                {
                    MessageBox.Show("в номере не должно быть букв!");      
                    break;
                }
            }          
                try
                {                   
                        listBox1.Items.Add($"{textBox2.Text} - {textBox1.Text}");
                        ht.Add(textBox2.Text, textBox1.Text);
                        ht1.Add(textBox1.Text, textBox2.Text);                   
                }
                catch { MessageBox.Show("такой элемент уже был в списке"); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            catch { MessageBox.Show("поле не выбрано"); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ht.ContainsKey(textBox4.Text) )
            {
                string tel = Convert.ToString(ht[$"{textBox4.Text}"]);
                MessageBox.Show($"фамилия: {tel}");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (ht1.ContainsKey(textBox3.Text))
            {
                string f = Convert.ToString(ht1[$"{textBox3.Text}"]);
                MessageBox.Show($"номер: {f}");
            }
        }
    }
}
