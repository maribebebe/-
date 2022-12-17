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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2 newform = new Form2();
            newform.Show();
            Hide();
        }

        private void выпускBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.выпускBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.контроль_качестваDataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "контроль_качестваDataSet.Выпуск". При необходимости она может быть перемещена или удалена.
            this.выпускTableAdapter.Fill(this.контроль_качестваDataSet.Выпуск);

        }
    }
}
