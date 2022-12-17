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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2 newform = new Form2();
            newform.Show();
            Hide();
        }

        private void изделияBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.изделияBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.контроль_качестваDataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
       

        }
    }
}
