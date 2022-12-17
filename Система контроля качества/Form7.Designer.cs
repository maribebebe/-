namespace Прокат_велосипедов
{
    partial class Form7
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label код_договораLabel;
            System.Windows.Forms.Label код_сотрудникаLabel;
            System.Windows.Forms.Label датаLabel;
            System.Windows.Forms.Label код_договораLabel1;
            System.Windows.Forms.Label код_изделияLabel;
            System.Windows.Forms.Label количествоLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.button7 = new System.Windows.Forms.Button();
            this.контроль_качестваDataSet = new Прокат_велосипедов.Контроль_качестваDataSet();
            this.спецификацияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.спецификацияTableAdapter = new Прокат_велосипедов.Контроль_качестваDataSetTableAdapters.СпецификацияTableAdapter();
            this.tableAdapterManager = new Прокат_велосипедов.Контроль_качестваDataSetTableAdapters.TableAdapterManager();
            this.договорTableAdapter = new Прокат_велосипедов.Контроль_качестваDataSetTableAdapters.ДоговорTableAdapter();
            this.спецификацияBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.спецификацияBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.спецификацияDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.договорBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.договорDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.код_договораTextBox = new System.Windows.Forms.TextBox();
            this.код_сотрудникаTextBox = new System.Windows.Forms.TextBox();
            this.датаDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.код_договораTextBox1 = new System.Windows.Forms.TextBox();
            this.код_изделияTextBox = new System.Windows.Forms.TextBox();
            this.количествоTextBox = new System.Windows.Forms.TextBox();
            код_договораLabel = new System.Windows.Forms.Label();
            код_сотрудникаLabel = new System.Windows.Forms.Label();
            датаLabel = new System.Windows.Forms.Label();
            код_договораLabel1 = new System.Windows.Forms.Label();
            код_изделияLabel = new System.Windows.Forms.Label();
            количествоLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.контроль_качестваDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.спецификацияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.спецификацияBindingNavigator)).BeginInit();
            this.спецификацияBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.спецификацияDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.договорBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.договорDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // код_договораLabel
            // 
            код_договораLabel.AutoSize = true;
            код_договораLabel.Location = new System.Drawing.Point(466, 283);
            код_договораLabel.Name = "код_договораLabel";
            код_договораLabel.Size = new System.Drawing.Size(101, 17);
            код_договораLabel.TabIndex = 9;
            код_договораLabel.Text = "Код договора:";
            // 
            // код_сотрудникаLabel
            // 
            код_сотрудникаLabel.AutoSize = true;
            код_сотрудникаLabel.Location = new System.Drawing.Point(466, 311);
            код_сотрудникаLabel.Name = "код_сотрудникаLabel";
            код_сотрудникаLabel.Size = new System.Drawing.Size(117, 17);
            код_сотрудникаLabel.TabIndex = 11;
            код_сотрудникаLabel.Text = "Код сотрудника:";
            // 
            // датаLabel
            // 
            датаLabel.AutoSize = true;
            датаLabel.Location = new System.Drawing.Point(466, 340);
            датаLabel.Name = "датаLabel";
            датаLabel.Size = new System.Drawing.Size(46, 17);
            датаLabel.TabIndex = 13;
            датаLabel.Text = "Дата:";
            // 
            // код_договораLabel1
            // 
            код_договораLabel1.AutoSize = true;
            код_договораLabel1.Location = new System.Drawing.Point(12, 285);
            код_договораLabel1.Name = "код_договораLabel1";
            код_договораLabel1.Size = new System.Drawing.Size(101, 17);
            код_договораLabel1.TabIndex = 14;
            код_договораLabel1.Text = "Код договора:";
            // 
            // код_изделияLabel
            // 
            код_изделияLabel.AutoSize = true;
            код_изделияLabel.Location = new System.Drawing.Point(12, 313);
            код_изделияLabel.Name = "код_изделияLabel";
            код_изделияLabel.Size = new System.Drawing.Size(96, 17);
            код_изделияLabel.TabIndex = 16;
            код_изделияLabel.Text = "Код изделия:";
            // 
            // количествоLabel
            // 
            количествоLabel.AutoSize = true;
            количествоLabel.Location = new System.Drawing.Point(12, 341);
            количествоLabel.Name = "количествоLabel";
            количествоLabel.Size = new System.Drawing.Size(90, 17);
            количествоLabel.TabIndex = 18;
            количествоLabel.Text = "Количество:";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Salmon;
            this.button7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(781, 398);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(144, 56);
            this.button7.TabIndex = 8;
            this.button7.Text = "Назад";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // контроль_качестваDataSet
            // 
            this.контроль_качестваDataSet.DataSetName = "Контроль_качестваDataSet";
            this.контроль_качестваDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // спецификацияBindingSource
            // 
            this.спецификацияBindingSource.DataMember = "Спецификация";
            this.спецификацияBindingSource.DataSource = this.контроль_качестваDataSet;
            // 
            // спецификацияTableAdapter
            // 
            this.спецификацияTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Прокат_велосипедов.Контроль_качестваDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ВыпускTableAdapter = null;
            this.tableAdapterManager.ДоговорTableAdapter = this.договорTableAdapter;
            this.tableAdapterManager.ИзделияTableAdapter = null;
            this.tableAdapterManager.ПоставщикиTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            this.tableAdapterManager.СпецификацияTableAdapter = this.спецификацияTableAdapter;
            // 
            // договорTableAdapter
            // 
            this.договорTableAdapter.ClearBeforeFill = true;
            // 
            // спецификацияBindingNavigator
            // 
            this.спецификацияBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.спецификацияBindingNavigator.BindingSource = this.спецификацияBindingSource;
            this.спецификацияBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.спецификацияBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.спецификацияBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.спецификацияBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.спецификацияBindingNavigatorSaveItem});
            this.спецификацияBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.спецификацияBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.спецификацияBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.спецификацияBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.спецификацияBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.спецификацияBindingNavigator.Name = "спецификацияBindingNavigator";
            this.спецификацияBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.спецификацияBindingNavigator.Size = new System.Drawing.Size(937, 27);
            this.спецификацияBindingNavigator.TabIndex = 9;
            this.спецификацияBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // спецификацияBindingNavigatorSaveItem
            // 
            this.спецификацияBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.спецификацияBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("спецификацияBindingNavigatorSaveItem.Image")));
            this.спецификацияBindingNavigatorSaveItem.Name = "спецификацияBindingNavigatorSaveItem";
            this.спецификацияBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.спецификацияBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.спецификацияBindingNavigatorSaveItem.Click += new System.EventHandler(this.спецификацияBindingNavigatorSaveItem_Click);
            // 
            // спецификацияDataGridView
            // 
            this.спецификацияDataGridView.AutoGenerateColumns = false;
            this.спецификацияDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.спецификацияDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.спецификацияDataGridView.DataSource = this.спецификацияBindingSource;
            this.спецификацияDataGridView.Location = new System.Drawing.Point(12, 41);
            this.спецификацияDataGridView.Name = "спецификацияDataGridView";
            this.спецификацияDataGridView.RowHeadersWidth = 51;
            this.спецификацияDataGridView.RowTemplate.Height = 24;
            this.спецификацияDataGridView.Size = new System.Drawing.Size(429, 220);
            this.спецификацияDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Код_договора";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код_договора";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Код_изделия";
            this.dataGridViewTextBoxColumn2.HeaderText = "Код_изделия";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Количество";
            this.dataGridViewTextBoxColumn3.HeaderText = "Количество";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // договорBindingSource
            // 
            this.договорBindingSource.DataMember = "Договор";
            this.договорBindingSource.DataSource = this.контроль_качестваDataSet;
            // 
            // договорDataGridView
            // 
            this.договорDataGridView.AutoGenerateColumns = false;
            this.договорDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.договорDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.договорDataGridView.DataSource = this.договорBindingSource;
            this.договорDataGridView.Location = new System.Drawing.Point(469, 41);
            this.договорDataGridView.Name = "договорDataGridView";
            this.договорDataGridView.RowHeadersWidth = 51;
            this.договорDataGridView.RowTemplate.Height = 24;
            this.договорDataGridView.Size = new System.Drawing.Size(429, 220);
            this.договорDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Код_договора";
            this.dataGridViewTextBoxColumn4.HeaderText = "Код_договора";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Код_сотрудника";
            this.dataGridViewTextBoxColumn5.HeaderText = "Код_сотрудника";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Дата";
            this.dataGridViewTextBoxColumn6.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // код_договораTextBox
            // 
            this.код_договораTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.договорBindingSource, "Код_договора", true));
            this.код_договораTextBox.Location = new System.Drawing.Point(589, 280);
            this.код_договораTextBox.Name = "код_договораTextBox";
            this.код_договораTextBox.Size = new System.Drawing.Size(200, 22);
            this.код_договораTextBox.TabIndex = 10;
            // 
            // код_сотрудникаTextBox
            // 
            this.код_сотрудникаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.договорBindingSource, "Код_сотрудника", true));
            this.код_сотрудникаTextBox.Location = new System.Drawing.Point(589, 308);
            this.код_сотрудникаTextBox.Name = "код_сотрудникаTextBox";
            this.код_сотрудникаTextBox.Size = new System.Drawing.Size(200, 22);
            this.код_сотрудникаTextBox.TabIndex = 12;
            // 
            // датаDateTimePicker
            // 
            this.датаDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.договорBindingSource, "Дата", true));
            this.датаDateTimePicker.Location = new System.Drawing.Point(589, 336);
            this.датаDateTimePicker.Name = "датаDateTimePicker";
            this.датаDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.датаDateTimePicker.TabIndex = 14;
            // 
            // код_договораTextBox1
            // 
            this.код_договораTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.спецификацияBindingSource, "Код_договора", true));
            this.код_договораTextBox1.Location = new System.Drawing.Point(119, 282);
            this.код_договораTextBox1.Name = "код_договораTextBox1";
            this.код_договораTextBox1.Size = new System.Drawing.Size(100, 22);
            this.код_договораTextBox1.TabIndex = 15;
            // 
            // код_изделияTextBox
            // 
            this.код_изделияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.спецификацияBindingSource, "Код_изделия", true));
            this.код_изделияTextBox.Location = new System.Drawing.Point(119, 310);
            this.код_изделияTextBox.Name = "код_изделияTextBox";
            this.код_изделияTextBox.Size = new System.Drawing.Size(100, 22);
            this.код_изделияTextBox.TabIndex = 17;
            // 
            // количествоTextBox
            // 
            this.количествоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.спецификацияBindingSource, "Количество", true));
            this.количествоTextBox.Location = new System.Drawing.Point(119, 338);
            this.количествоTextBox.Name = "количествоTextBox";
            this.количествоTextBox.Size = new System.Drawing.Size(100, 22);
            this.количествоTextBox.TabIndex = 19;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(937, 466);
            this.Controls.Add(код_договораLabel1);
            this.Controls.Add(this.код_договораTextBox1);
            this.Controls.Add(код_изделияLabel);
            this.Controls.Add(this.код_изделияTextBox);
            this.Controls.Add(количествоLabel);
            this.Controls.Add(this.количествоTextBox);
            this.Controls.Add(код_договораLabel);
            this.Controls.Add(this.код_договораTextBox);
            this.Controls.Add(код_сотрудникаLabel);
            this.Controls.Add(this.код_сотрудникаTextBox);
            this.Controls.Add(датаLabel);
            this.Controls.Add(this.датаDateTimePicker);
            this.Controls.Add(this.договорDataGridView);
            this.Controls.Add(this.спецификацияDataGridView);
            this.Controls.Add(this.спецификацияBindingNavigator);
            this.Controls.Add(this.button7);
            this.Name = "Form7";
            this.Text = "Спецификация";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.контроль_качестваDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.спецификацияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.спецификацияBindingNavigator)).EndInit();
            this.спецификацияBindingNavigator.ResumeLayout(false);
            this.спецификацияBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.спецификацияDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.договорBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.договорDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button7;
        private Контроль_качестваDataSet контроль_качестваDataSet;
        private System.Windows.Forms.BindingSource спецификацияBindingSource;
        private Контроль_качестваDataSetTableAdapters.СпецификацияTableAdapter спецификацияTableAdapter;
        private Контроль_качестваDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator спецификацияBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton спецификацияBindingNavigatorSaveItem;
        private Контроль_качестваDataSetTableAdapters.ДоговорTableAdapter договорTableAdapter;
        private System.Windows.Forms.DataGridView спецификацияDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource договорBindingSource;
        private System.Windows.Forms.DataGridView договорDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox код_договораTextBox;
        private System.Windows.Forms.TextBox код_сотрудникаTextBox;
        private System.Windows.Forms.DateTimePicker датаDateTimePicker;
        private System.Windows.Forms.TextBox код_договораTextBox1;
        private System.Windows.Forms.TextBox код_изделияTextBox;
        private System.Windows.Forms.TextBox количествоTextBox;
    }
}