namespace Прокат_велосипедов
{
    partial class Form3
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
            System.Windows.Forms.Label код_изделияLabel;
            System.Windows.Forms.Label предприятиеLabel;
            System.Windows.Forms.Label год_выпускаLabel;
            System.Windows.Forms.Label объем_выпускаLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.button7 = new System.Windows.Forms.Button();
            this.контроль_качестваDataSet = new Прокат_велосипедов.Контроль_качестваDataSet();
            this.выпускBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.выпускTableAdapter = new Прокат_велосипедов.Контроль_качестваDataSetTableAdapters.ВыпускTableAdapter();
            this.tableAdapterManager = new Прокат_велосипедов.Контроль_качестваDataSetTableAdapters.TableAdapterManager();
            this.выпускBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.выпускBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.выпускDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.код_изделияTextBox = new System.Windows.Forms.TextBox();
            this.предприятиеTextBox = new System.Windows.Forms.TextBox();
            this.год_выпускаDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.объем_выпускаTextBox = new System.Windows.Forms.TextBox();
            код_изделияLabel = new System.Windows.Forms.Label();
            предприятиеLabel = new System.Windows.Forms.Label();
            год_выпускаLabel = new System.Windows.Forms.Label();
            объем_выпускаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.контроль_качестваDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.выпускBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.выпускBindingNavigator)).BeginInit();
            this.выпускBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.выпускDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // код_изделияLabel
            // 
            код_изделияLabel.AutoSize = true;
            код_изделияLabel.Location = new System.Drawing.Point(595, 40);
            код_изделияLabel.Name = "код_изделияLabel";
            код_изделияLabel.Size = new System.Drawing.Size(96, 17);
            код_изделияLabel.TabIndex = 9;
            код_изделияLabel.Text = "Код изделия:";
            // 
            // предприятиеLabel
            // 
            предприятиеLabel.AutoSize = true;
            предприятиеLabel.Location = new System.Drawing.Point(595, 68);
            предприятиеLabel.Name = "предприятиеLabel";
            предприятиеLabel.Size = new System.Drawing.Size(101, 17);
            предприятиеLabel.TabIndex = 11;
            предприятиеLabel.Text = "Предприятие:";
            // 
            // год_выпускаLabel
            // 
            год_выпускаLabel.AutoSize = true;
            год_выпускаLabel.Location = new System.Drawing.Point(595, 97);
            год_выпускаLabel.Name = "год_выпускаLabel";
            год_выпускаLabel.Size = new System.Drawing.Size(94, 17);
            год_выпускаLabel.TabIndex = 13;
            год_выпускаLabel.Text = "Год выпуска:";
            // 
            // объем_выпускаLabel
            // 
            объем_выпускаLabel.AutoSize = true;
            объем_выпускаLabel.Location = new System.Drawing.Point(595, 124);
            объем_выпускаLabel.Name = "объем_выпускаLabel";
            объем_выпускаLabel.Size = new System.Drawing.Size(115, 17);
            объем_выпускаLabel.TabIndex = 15;
            объем_выпускаLabel.Text = "Объем выпуска:";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Salmon;
            this.button7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(848, 271);
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
            // выпускBindingSource
            // 
            this.выпускBindingSource.DataMember = "Выпуск";
            this.выпускBindingSource.DataSource = this.контроль_качестваDataSet;
            // 
            // выпускTableAdapter
            // 
            this.выпускTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Прокат_велосипедов.Контроль_качестваDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ВыпускTableAdapter = this.выпускTableAdapter;
            this.tableAdapterManager.ДоговорTableAdapter = null;
            this.tableAdapterManager.ИзделияTableAdapter = null;
            this.tableAdapterManager.ПоставщикиTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            this.tableAdapterManager.СпецификацияTableAdapter = null;
            // 
            // выпускBindingNavigator
            // 
            this.выпускBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.выпускBindingNavigator.BindingSource = this.выпускBindingSource;
            this.выпускBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.выпускBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.выпускBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.выпускBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.выпускBindingNavigatorSaveItem});
            this.выпускBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.выпускBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.выпускBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.выпускBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.выпускBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.выпускBindingNavigator.Name = "выпускBindingNavigator";
            this.выпускBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.выпускBindingNavigator.Size = new System.Drawing.Size(1004, 27);
            this.выпускBindingNavigator.TabIndex = 9;
            this.выпускBindingNavigator.Text = "bindingNavigator1";
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
            // выпускBindingNavigatorSaveItem
            // 
            this.выпускBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.выпускBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("выпускBindingNavigatorSaveItem.Image")));
            this.выпускBindingNavigatorSaveItem.Name = "выпускBindingNavigatorSaveItem";
            this.выпускBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.выпускBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.выпускBindingNavigatorSaveItem.Click += new System.EventHandler(this.выпускBindingNavigatorSaveItem_Click);
            // 
            // выпускDataGridView
            // 
            this.выпускDataGridView.AutoGenerateColumns = false;
            this.выпускDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.выпускDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.выпускDataGridView.DataSource = this.выпускBindingSource;
            this.выпускDataGridView.Location = new System.Drawing.Point(12, 40);
            this.выпускDataGridView.Name = "выпускDataGridView";
            this.выпускDataGridView.RowHeadersWidth = 51;
            this.выпускDataGridView.RowTemplate.Height = 24;
            this.выпускDataGridView.Size = new System.Drawing.Size(553, 220);
            this.выпускDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Код_изделия";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код_изделия";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Предприятие";
            this.dataGridViewTextBoxColumn2.HeaderText = "Предприятие";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Год_выпуска";
            this.dataGridViewTextBoxColumn3.HeaderText = "Год_выпуска";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Объем_выпуска";
            this.dataGridViewTextBoxColumn4.HeaderText = "Объем_выпуска";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // код_изделияTextBox
            // 
            this.код_изделияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.выпускBindingSource, "Код_изделия", true));
            this.код_изделияTextBox.Location = new System.Drawing.Point(716, 37);
            this.код_изделияTextBox.Name = "код_изделияTextBox";
            this.код_изделияTextBox.Size = new System.Drawing.Size(200, 22);
            this.код_изделияTextBox.TabIndex = 10;
            // 
            // предприятиеTextBox
            // 
            this.предприятиеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.выпускBindingSource, "Предприятие", true));
            this.предприятиеTextBox.Location = new System.Drawing.Point(716, 65);
            this.предприятиеTextBox.Name = "предприятиеTextBox";
            this.предприятиеTextBox.Size = new System.Drawing.Size(200, 22);
            this.предприятиеTextBox.TabIndex = 12;
            // 
            // год_выпускаDateTimePicker
            // 
            this.год_выпускаDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.выпускBindingSource, "Год_выпуска", true));
            this.год_выпускаDateTimePicker.Location = new System.Drawing.Point(716, 93);
            this.год_выпускаDateTimePicker.Name = "год_выпускаDateTimePicker";
            this.год_выпускаDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.год_выпускаDateTimePicker.TabIndex = 14;
            // 
            // объем_выпускаTextBox
            // 
            this.объем_выпускаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.выпускBindingSource, "Объем_выпуска", true));
            this.объем_выпускаTextBox.Location = new System.Drawing.Point(716, 121);
            this.объем_выпускаTextBox.Name = "объем_выпускаTextBox";
            this.объем_выпускаTextBox.Size = new System.Drawing.Size(200, 22);
            this.объем_выпускаTextBox.TabIndex = 16;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1004, 339);
            this.Controls.Add(код_изделияLabel);
            this.Controls.Add(this.код_изделияTextBox);
            this.Controls.Add(предприятиеLabel);
            this.Controls.Add(this.предприятиеTextBox);
            this.Controls.Add(год_выпускаLabel);
            this.Controls.Add(this.год_выпускаDateTimePicker);
            this.Controls.Add(объем_выпускаLabel);
            this.Controls.Add(this.объем_выпускаTextBox);
            this.Controls.Add(this.выпускDataGridView);
            this.Controls.Add(this.выпускBindingNavigator);
            this.Controls.Add(this.button7);
            this.Name = "Form3";
            this.Text = "Выпуск";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.контроль_качестваDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.выпускBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.выпускBindingNavigator)).EndInit();
            this.выпускBindingNavigator.ResumeLayout(false);
            this.выпускBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.выпускDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button7;
        private Контроль_качестваDataSet контроль_качестваDataSet;
        private System.Windows.Forms.BindingSource выпускBindingSource;
        private Контроль_качестваDataSetTableAdapters.ВыпускTableAdapter выпускTableAdapter;
        private Контроль_качестваDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator выпускBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton выпускBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView выпускDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox код_изделияTextBox;
        private System.Windows.Forms.TextBox предприятиеTextBox;
        private System.Windows.Forms.DateTimePicker год_выпускаDateTimePicker;
        private System.Windows.Forms.TextBox объем_выпускаTextBox;
    }
}