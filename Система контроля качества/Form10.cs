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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void выпускBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.выпускBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.контроль_качестваDataSet);

        }

        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "контроль_качестваDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.контроль_качестваDataSet.Сотрудники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "контроль_качестваDataSet.Спецификация". При необходимости она может быть перемещена или удалена.
            this.спецификацияTableAdapter.Fill(this.контроль_качестваDataSet.Спецификация);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "контроль_качестваDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.контроль_качестваDataSet.Сотрудники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "контроль_качестваDataSet.Поставщики". При необходимости она может быть перемещена или удалена.
            this.поставщикиTableAdapter.Fill(this.контроль_качестваDataSet.Поставщики);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "контроль_качестваDataSet.Изделия". При необходимости она может быть перемещена или удалена.
            // TODO: данная строка кода позволяет загрузить данные в таблицу "контроль_качестваDataSet.Договор". При необходимости она может быть перемещена или удалена.
            this.договорTableAdapter.Fill(this.контроль_качестваDataSet.Договор);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "контроль_качестваDataSet.Выпуск". При необходимости она может быть перемещена или удалена.
            this.выпускTableAdapter.Fill(this.контроль_качестваDataSet.Выпуск);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
