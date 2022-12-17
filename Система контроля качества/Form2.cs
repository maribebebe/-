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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
          Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 newform = new Form3();
            newform.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 newform = new Form6();
            newform.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 newform = new Form5();
            newform.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 newform = new Form4();
            newform.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 newform = new Form3();
            newform.Show();
            Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form7 newform = new Form7();
            newform.Show();
            Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form9 newform = new Form9();
            newform.Show();
            Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
