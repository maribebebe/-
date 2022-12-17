using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Прокат_велосипедов
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Login = "Мария";
            var Password = "1821";
            if ((textBox1.Text == Login) && (textBox2.Text == Password))
            {
                Form2 newform = new Form2();
                newform.Show();
                Hide();
            }
            else
            {
                button1.Text = "Ошибка";
            }
            var LogiN = "Пользователь";
            var PassworD = "00000";
            if ((textBox1.Text == LogiN) && (textBox2.Text == PassworD))
            {
                Form10 newform = new Form10();
                newform.Show();
                Hide();
            }
            else
            {
                button1.Text = "Ошибка";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

