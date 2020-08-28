/*
 * Создано в SharpDevelop.
 * Пользователь: artem
 * Дата: 05/04/2020
 * Время: 15:39
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
namespace auth
{
	partial class ProductsForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button confirmButton;
		private System.Windows.Forms.Button deleteDataButton;
		private System.Windows.Forms.TextBox textBox1;
		public System.Windows.Forms.Button refreshButton;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.MaskedTextBox maskedTextBox1;
		private System.Windows.Forms.SplitContainer splitContainer1;
		public System.Windows.Forms.Button addDataButton;
		public System.Windows.Forms.Button changeDataButton;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button checkbutton;
		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
		private System.Windows.Forms.DataGridViewComboBoxColumn Column5;
		public System.Windows.Forms.Button refreshDataGridViewButton;
		private System.Windows.Forms.Button findItemButton;
		private System.Windows.Forms.Button showOnlyBadProducts;
		private System.Windows.Forms.Button button1;
		
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
			
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsForm));
			this.confirmButton = new System.Windows.Forms.Button();
			this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Column5 = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.addDataButton = new System.Windows.Forms.Button();
			this.deleteDataButton = new System.Windows.Forms.Button();
			this.refreshButton = new System.Windows.Forms.Button();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.showOnlyBadProducts = new System.Windows.Forms.Button();
			this.checkbutton = new System.Windows.Forms.Button();
			this.changeDataButton = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.findItemButton = new System.Windows.Forms.Button();
			this.refreshDataGridViewButton = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.menuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// confirmButton
			// 
			this.confirmButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
			this.confirmButton.FlatAppearance.BorderSize = 0;
			this.confirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.confirmButton.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.confirmButton.ForeColor = System.Drawing.Color.White;
			this.confirmButton.Location = new System.Drawing.Point(23, 324);
			this.confirmButton.Name = "confirmButton";
			this.confirmButton.Size = new System.Drawing.Size(118, 30);
			this.confirmButton.TabIndex = 1;
			this.confirmButton.Text = "OK";
			this.confirmButton.UseVisualStyleBackColor = false;
			// 
			// maskedTextBox1
			// 
			this.maskedTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
			this.maskedTextBox1.ForeColor = System.Drawing.Color.White;
			this.maskedTextBox1.Location = new System.Drawing.Point(506, 332);
			this.maskedTextBox1.Mask = "00/00/0000";
			this.maskedTextBox1.Name = "maskedTextBox1";
			this.maskedTextBox1.Size = new System.Drawing.Size(120, 20);
			this.maskedTextBox1.TabIndex = 6;
			this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
			this.numericUpDown1.ForeColor = System.Drawing.Color.White;
			this.numericUpDown1.Location = new System.Drawing.Point(374, 332);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
			this.numericUpDown1.TabIndex = 5;
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
			this.textBox1.ForeColor = System.Drawing.Color.White;
			this.textBox1.Location = new System.Drawing.Point(212, 332);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(150, 20);
			this.textBox1.TabIndex = 3;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToResizeColumns = false;
			this.dataGridView1.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkViolet;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
			this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
			this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
			this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.GhostWhite;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkViolet;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.Column5});
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F);
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Honeydew;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkViolet;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
			this.dataGridView1.EnableHeadersVisualStyles = false;
			this.dataGridView1.GridColor = System.Drawing.Color.White;
			this.dataGridView1.Location = new System.Drawing.Point(72, 32);
			this.dataGridView1.Name = "dataGridView1";
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F);
			dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Info;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkViolet;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F);
			dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkViolet;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle6;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(636, 144);
			this.dataGridView1.TabIndex = 0;
			// 
			// Column5
			// 
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.NullValue = "Выбрать тип продукта";
			this.Column5.DefaultCellStyle = dataGridViewCellStyle3;
			this.Column5.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
			this.Column5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.Column5.HeaderText = "Тип продукта";
			this.Column5.Items.AddRange(new object[] {
			"Фрукты",
			"Овощи",
			"Молочные продукты",
			"Мясные изделия",
			"Напитки"});
			this.Column5.Name = "Column5";
			this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.Column5.Width = 99;
			// 
			// addDataButton
			// 
			this.addDataButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
			this.addDataButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.addDataButton.FlatAppearance.BorderSize = 0;
			this.addDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.addDataButton.Font = new System.Drawing.Font("Segoe UI Emoji", 8F);
			this.addDataButton.ForeColor = System.Drawing.Color.White;
			this.addDataButton.Image = ((System.Drawing.Image)(resources.GetObject("addDataButton.Image")));
			this.addDataButton.Location = new System.Drawing.Point(0, 192);
			this.addDataButton.Name = "addDataButton";
			this.addDataButton.Size = new System.Drawing.Size(131, 45);
			this.addDataButton.TabIndex = 8;
			this.addDataButton.Text = "Добавить данные";
			this.addDataButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.addDataButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.addDataButton.UseVisualStyleBackColor = false;
			this.addDataButton.Click += new System.EventHandler(this.AddDataButtonClick);
			// 
			// deleteDataButton
			// 
			this.deleteDataButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
			this.deleteDataButton.FlatAppearance.BorderSize = 0;
			this.deleteDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.deleteDataButton.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.deleteDataButton.ForeColor = System.Drawing.Color.White;
			this.deleteDataButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteDataButton.Image")));
			this.deleteDataButton.Location = new System.Drawing.Point(138, 192);
			this.deleteDataButton.Name = "deleteDataButton";
			this.deleteDataButton.Size = new System.Drawing.Size(131, 45);
			this.deleteDataButton.TabIndex = 2;
			this.deleteDataButton.Text = "Удалить данные";
			this.deleteDataButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.deleteDataButton.UseVisualStyleBackColor = false;
			this.deleteDataButton.Click += new System.EventHandler(this.DeleteDataButtonClick);
			// 
			// refreshButton
			// 
			this.refreshButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
			this.refreshButton.FlatAppearance.BorderSize = 0;
			this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.refreshButton.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F);
			this.refreshButton.ForeColor = System.Drawing.Color.White;
			this.refreshButton.Image = ((System.Drawing.Image)(resources.GetObject("refreshButton.Image")));
			this.refreshButton.Location = new System.Drawing.Point(416, 192);
			this.refreshButton.Name = "refreshButton";
			this.refreshButton.Size = new System.Drawing.Size(88, 45);
			this.refreshButton.TabIndex = 4;
			this.refreshButton.Text = "Обновить данные";
			this.refreshButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.refreshButton.UseVisualStyleBackColor = false;
			this.refreshButton.Click += new System.EventHandler(this.RefreshButtonClick);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Location = new System.Drawing.Point(8, 0);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.showOnlyBadProducts);
			this.splitContainer1.Panel1.Controls.Add(this.checkbutton);
			this.splitContainer1.Panel1.Controls.Add(this.changeDataButton);
			this.splitContainer1.Panel1.Controls.Add(this.refreshButton);
			this.splitContainer1.Panel1.Controls.Add(this.deleteDataButton);
			this.splitContainer1.Panel1.Controls.Add(this.button1);
			this.splitContainer1.Panel1.Controls.Add(this.addDataButton);
			this.splitContainer1.Panel1.Controls.Add(this.findItemButton);
			this.splitContainer1.Panel1.Controls.Add(this.refreshDataGridViewButton);
			this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Gainsboro;
			this.splitContainer1.Size = new System.Drawing.Size(816, 314);
			this.splitContainer1.SplitterDistance = 285;
			this.splitContainer1.SplitterWidth = 1;
			this.splitContainer1.TabIndex = 7;
			// 
			// showOnlyBadProducts
			// 
			this.showOnlyBadProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
			this.showOnlyBadProducts.FlatAppearance.BorderSize = 0;
			this.showOnlyBadProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.showOnlyBadProducts.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.showOnlyBadProducts.ForeColor = System.Drawing.Color.White;
			this.showOnlyBadProducts.Location = new System.Drawing.Point(664, 192);
			this.showOnlyBadProducts.Name = "showOnlyBadProducts";
			this.showOnlyBadProducts.Size = new System.Drawing.Size(144, 45);
			this.showOnlyBadProducts.TabIndex = 4;
			this.showOnlyBadProducts.Text = "Показать только просроченные продукты";
			this.showOnlyBadProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.showOnlyBadProducts.UseVisualStyleBackColor = false;
			this.showOnlyBadProducts.Click += new System.EventHandler(this.ShowOnlyBadItemsButtonClick);
			// 
			// checkbutton
			// 
			this.checkbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
			this.checkbutton.FlatAppearance.BorderSize = 0;
			this.checkbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkbutton.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkbutton.ForeColor = System.Drawing.Color.White;
			this.checkbutton.Image = ((System.Drawing.Image)(resources.GetObject("checkbutton.Image")));
			this.checkbutton.Location = new System.Drawing.Point(512, 192);
			this.checkbutton.Name = "checkbutton";
			this.checkbutton.Size = new System.Drawing.Size(144, 45);
			this.checkbutton.TabIndex = 10;
			this.checkbutton.Text = "Проверить состояние продуктов";
			this.checkbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.checkbutton.UseVisualStyleBackColor = false;
			this.checkbutton.Click += new System.EventHandler(this.CheckbuttonClick);
			// 
			// changeDataButton
			// 
			this.changeDataButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
			this.changeDataButton.FlatAppearance.BorderSize = 0;
			this.changeDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.changeDataButton.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.changeDataButton.ForeColor = System.Drawing.Color.White;
			this.changeDataButton.Image = ((System.Drawing.Image)(resources.GetObject("changeDataButton.Image")));
			this.changeDataButton.Location = new System.Drawing.Point(277, 192);
			this.changeDataButton.Name = "changeDataButton";
			this.changeDataButton.Size = new System.Drawing.Size(131, 45);
			this.changeDataButton.TabIndex = 9;
			this.changeDataButton.Text = "Изменить данные";
			this.changeDataButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.changeDataButton.UseVisualStyleBackColor = false;
			this.changeDataButton.Click += new System.EventHandler(this.ChangeDataButtonClick);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
			this.button1.Location = new System.Drawing.Point(0, 24);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(34, 35);
			this.button1.TabIndex = 4;
			this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.GoToHomeButtonClick);
			// 
			// findItemButton
			// 
			this.findItemButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
			this.findItemButton.FlatAppearance.BorderSize = 0;
			this.findItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.findItemButton.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.findItemButton.ForeColor = System.Drawing.Color.White;
			this.findItemButton.Image = ((System.Drawing.Image)(resources.GetObject("findItemButton.Image")));
			this.findItemButton.Location = new System.Drawing.Point(720, 134);
			this.findItemButton.Name = "findItemButton";
			this.findItemButton.Size = new System.Drawing.Size(84, 45);
			this.findItemButton.TabIndex = 4;
			this.findItemButton.Text = "Найти данные";
			this.findItemButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.findItemButton.UseVisualStyleBackColor = false;
			this.findItemButton.Click += new System.EventHandler(this.FindItemButtonClick);
			// 
			// refreshDataGridViewButton
			// 
			this.refreshDataGridViewButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
			this.refreshDataGridViewButton.FlatAppearance.BorderSize = 0;
			this.refreshDataGridViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.refreshDataGridViewButton.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.refreshDataGridViewButton.ForeColor = System.Drawing.Color.White;
			this.refreshDataGridViewButton.Image = ((System.Drawing.Image)(resources.GetObject("refreshDataGridViewButton.Image")));
			this.refreshDataGridViewButton.Location = new System.Drawing.Point(720, 32);
			this.refreshDataGridViewButton.Name = "refreshDataGridViewButton";
			this.refreshDataGridViewButton.Size = new System.Drawing.Size(84, 45);
			this.refreshDataGridViewButton.TabIndex = 4;
			this.refreshDataGridViewButton.Text = "Обновить данные";
			this.refreshDataGridViewButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.refreshDataGridViewButton.UseVisualStyleBackColor = false;
			this.refreshDataGridViewButton.Click += new System.EventHandler(this.RefreshButtonClick);
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Gainsboro;
			this.label3.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(506, 314);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(120, 17);
			this.label3.TabIndex = 7;
			this.label3.Text = "Срок списания";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Gainsboro;
			this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(374, 314);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(120, 17);
			this.label2.TabIndex = 7;
			this.label2.Text = "Количество";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Gainsboro;
			this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(212, 314);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(150, 17);
			this.label1.TabIndex = 7;
			this.label1.Text = "Наименование товара";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// menuStrip
			// 
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.настройкиToolStripMenuItem});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(830, 24);
			this.menuStrip.TabIndex = 8;
			this.menuStrip.Text = "menuStrip1";
			// 
			// настройкиToolStripMenuItem
			// 
			this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
			this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
			this.настройкиToolStripMenuItem.Text = "Настройки";
			this.настройкиToolStripMenuItem.Click += new System.EventHandler(this.НастройкиToolStripMenuItemClick);
			// 
			// ProductsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Gainsboro;
			this.ClientSize = new System.Drawing.Size(830, 358);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.menuStrip);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.maskedTextBox1);
			this.Controls.Add(this.confirmButton);
			this.Controls.Add(this.splitContainer1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MainMenuStrip = this.menuStrip;
			this.Name = "ProductsForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Управление товарами";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductsFormClosing);
			this.Load += new System.EventHandler(this.ProductsFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.splitContainer1.Panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}}