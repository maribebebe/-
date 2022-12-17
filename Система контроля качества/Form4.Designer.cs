namespace Прокат_велосипедов
{
    partial class Form4
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
            System.Windows.Forms.Label код_поставщикаLabel;
            System.Windows.Forms.Label названиеLabel;
            System.Windows.Forms.Label годовой_объемLabel;
            System.Windows.Forms.Label примечаниеLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.button7 = new System.Windows.Forms.Button();
            this.контроль_качестваDataSet = new Прокат_велосипедов.Контроль_качестваDataSet();
            this.изделияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.изделияTableAdapter = new Прокат_велосипедов.Контроль_качестваDataSetTableAdapters.ИзделияTableAdapter();
            this.tableAdapterManager = new Прокат_велосипедов.Контроль_качестваDataSetTableAdapters.TableAdapterManager();
            this.изделияBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.изделияBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.изделияDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.код_изделияTextBox = new System.Windows.Forms.TextBox();
            this.код_поставщикаTextBox = new System.Windows.Forms.TextBox();
            this.названиеTextBox = new System.Windows.Forms.TextBox();
            this.годовой_объемTextBox = new System.Windows.Forms.TextBox();
            this.примечаниеTextBox = new System.Windows.Forms.TextBox();
            код_изделияLabel = new System.Windows.Forms.Label();
            код_поставщикаLabel = new System.Windows.Forms.Label();
            названиеLabel = new System.Windows.Forms.Label();
            годовой_объемLabel = new System.Windows.Forms.Label();
            примечаниеLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.контроль_качестваDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.изделияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.изделияBindingNavigator)).BeginInit();
            this.изделияBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.изделияDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // код_изделияLabel
            // 
            код_изделияLabel.AutoSize = true;
            код_изделияLabel.Location = new System.Drawing.Point(713, 32);
            код_изделияLabel.Name = "код_изделияLabel";
            код_изделияLabel.Size = new System.Drawing.Size(96, 17);
            код_изделияLabel.TabIndex = 9;
            код_изделияLabel.Text = "Код изделия:";
            // 
            // код_поставщикаLabel
            // 
            код_поставщикаLabel.AutoSize = true;
            код_поставщикаLabel.Location = new System.Drawing.Point(713, 60);
            код_поставщикаLabel.Name = "код_поставщикаLabel";
            код_поставщикаLabel.Size = new System.Drawing.Size(120, 17);
            код_поставщикаLabel.TabIndex = 11;
            код_поставщикаLabel.Text = "Код поставщика:";
            // 
            // названиеLabel
            // 
            названиеLabel.AutoSize = true;
            названиеLabel.Location = new System.Drawing.Point(713, 88);
            названиеLabel.Name = "названиеLabel";
            названиеLabel.Size = new System.Drawing.Size(76, 17);
            названиеLabel.TabIndex = 13;
            названиеLabel.Text = "Название:";
            // 
            // годовой_объемLabel
            // 
            годовой_объемLabel.AutoSize = true;
            годовой_объемLabel.Location = new System.Drawing.Point(713, 116);
            годовой_объемLabel.Name = "годовой_объемLabel";
            годовой_объемLabel.Size = new System.Drawing.Size(113, 17);
            годовой_объемLabel.TabIndex = 15;
            годовой_объемLabel.Text = "Годовой объем:";
            // 
            // примечаниеLabel
            // 
            примечаниеLabel.AutoSize = true;
            примечаниеLabel.Location = new System.Drawing.Point(713, 144);
            примечаниеLabel.Name = "примечаниеLabel";
            примечаниеLabel.Size = new System.Drawing.Size(93, 17);
            примечаниеLabel.TabIndex = 17;
            примечаниеLabel.Text = "примечание:";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Salmon;
            this.button7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(841, 307);
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
            // изделияBindingSource
            // 
            this.изделияBindingSource.DataMember = "Изделия";
            this.изделияBindingSource.DataSource = this.контроль_качестваDataSet;
            // 
            // изделияTableAdapter
            // 
            this.изделияTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Прокат_велосипедов.Контроль_качестваDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ВыпускTableAdapter = null;
            this.tableAdapterManager.ДоговорTableAdapter = null;
            this.tableAdapterManager.ИзделияTableAdapter = this.изделияTableAdapter;
            this.tableAdapterManager.ПоставщикиTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            this.tableAdapterManager.СпецификацияTableAdapter = null;
            // 
            // изделияBindingNavigator
            // 
            this.изделияBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.изделияBindingNavigator.BindingSource = this.изделияBindingSource;
            this.изделияBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.изделияBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.изделияBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.изделияBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.изделияBindingNavigatorSaveItem});
            this.изделияBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.изделияBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.изделияBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.изделияBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.изделияBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.изделияBindingNavigator.Name = "изделияBindingNavigator";
            this.изделияBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.изделияBindingNavigator.Size = new System.Drawing.Size(997, 27);
            this.изделияBindingNavigator.TabIndex = 9;
            this.изделияBindingNavigator.Text = "bindingNavigator1";
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
            // изделияBindingNavigatorSaveItem
            // 
            this.изделияBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.изделияBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("изделияBindingNavigatorSaveItem.Image")));
            this.изделияBindingNavigatorSaveItem.Name = "изделияBindingNavigatorSaveItem";
            this.изделияBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.изделияBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.изделияBindingNavigatorSaveItem.Click += new System.EventHandler(this.изделияBindingNavigatorSaveItem_Click);
            // 
            // изделияDataGridView
            // 
            this.изделияDataGridView.AutoGenerateColumns = false;
            this.изделияDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.изделияDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.изделияDataGridView.DataSource = this.изделияBindingSource;
            this.изделияDataGridView.Location = new System.Drawing.Point(12, 32);
            this.изделияDataGridView.Name = "изделияDataGridView";
            this.изделияDataGridView.RowHeadersWidth = 51;
            this.изделияDataGridView.RowTemplate.Height = 24;
            this.изделияDataGridView.Size = new System.Drawing.Size(680, 220);
            this.изделияDataGridView.TabIndex = 9;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Код_поставщика";
            this.dataGridViewTextBoxColumn2.HeaderText = "Код_поставщика";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Название";
            this.dataGridViewTextBoxColumn3.HeaderText = "Название";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Годовой_объем";
            this.dataGridViewTextBoxColumn4.HeaderText = "Годовой_объем";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "примечание";
            this.dataGridViewTextBoxColumn5.HeaderText = "примечание";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // код_изделияTextBox
            // 
            this.код_изделияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.изделияBindingSource, "Код_изделия", true));
            this.код_изделияTextBox.Location = new System.Drawing.Point(839, 29);
            this.код_изделияTextBox.Name = "код_изделияTextBox";
            this.код_изделияTextBox.Size = new System.Drawing.Size(100, 22);
            this.код_изделияTextBox.TabIndex = 10;
            // 
            // код_поставщикаTextBox
            // 
            this.код_поставщикаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.изделияBindingSource, "Код_поставщика", true));
            this.код_поставщикаTextBox.Location = new System.Drawing.Point(839, 57);
            this.код_поставщикаTextBox.Name = "код_поставщикаTextBox";
            this.код_поставщикаTextBox.Size = new System.Drawing.Size(100, 22);
            this.код_поставщикаTextBox.TabIndex = 12;
            // 
            // названиеTextBox
            // 
            this.названиеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.изделияBindingSource, "Название", true));
            this.названиеTextBox.Location = new System.Drawing.Point(839, 85);
            this.названиеTextBox.Name = "названиеTextBox";
            this.названиеTextBox.Size = new System.Drawing.Size(100, 22);
            this.названиеTextBox.TabIndex = 14;
            // 
            // годовой_объемTextBox
            // 
            this.годовой_объемTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.изделияBindingSource, "Годовой_объем", true));
            this.годовой_объемTextBox.Location = new System.Drawing.Point(839, 113);
            this.годовой_объемTextBox.Name = "годовой_объемTextBox";
            this.годовой_объемTextBox.Size = new System.Drawing.Size(100, 22);
            this.годовой_объемTextBox.TabIndex = 16;
            // 
            // примечаниеTextBox
            // 
            this.примечаниеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.изделияBindingSource, "примечание", true));
            this.примечаниеTextBox.Location = new System.Drawing.Point(839, 141);
            this.примечаниеTextBox.Name = "примечаниеTextBox";
            this.примечаниеTextBox.Size = new System.Drawing.Size(100, 22);
            this.примечаниеTextBox.TabIndex = 18;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(997, 375);
            this.Controls.Add(код_изделияLabel);
            this.Controls.Add(this.код_изделияTextBox);
            this.Controls.Add(код_поставщикаLabel);
            this.Controls.Add(this.код_поставщикаTextBox);
            this.Controls.Add(названиеLabel);
            this.Controls.Add(this.названиеTextBox);
            this.Controls.Add(годовой_объемLabel);
            this.Controls.Add(this.годовой_объемTextBox);
            this.Controls.Add(примечаниеLabel);
            this.Controls.Add(this.примечаниеTextBox);
            this.Controls.Add(this.изделияDataGridView);
            this.Controls.Add(this.изделияBindingNavigator);
            this.Controls.Add(this.button7);
            this.Name = "Form4";
            this.Text = "Изделия";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.контроль_качестваDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.изделияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.изделияBindingNavigator)).EndInit();
            this.изделияBindingNavigator.ResumeLayout(false);
            this.изделияBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.изделияDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button7;
        private Контроль_качестваDataSet контроль_качестваDataSet;
        private System.Windows.Forms.BindingSource изделияBindingSource;
        private Контроль_качестваDataSetTableAdapters.ИзделияTableAdapter изделияTableAdapter;
        private Контроль_качестваDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator изделияBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton изделияBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView изделияDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox код_изделияTextBox;
        private System.Windows.Forms.TextBox код_поставщикаTextBox;
        private System.Windows.Forms.TextBox названиеTextBox;
        private System.Windows.Forms.TextBox годовой_объемTextBox;
        private System.Windows.Forms.TextBox примечаниеTextBox;
    }
}