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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2 newform = new Form2();
            newform.Show();
            Hide();
        }

        private void спецификацияBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.спецификацияBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.контроль_качестваDataSet);

        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "контроль_качестваDataSet.Договор". При необходимости она может быть перемещена или удалена.
            this.договорTableAdapter.Fill(this.контроль_качестваDataSet.Договор);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "контроль_качестваDataSet.Спецификация". При необходимости она может быть перемещена или удалена.
            this.спецификацияTableAdapter.Fill(this.контроль_качестваDataSet.Спецификация);

        }
    }
}
