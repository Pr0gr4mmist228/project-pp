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
		public System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button confirmButton;
		public System.Windows.Forms.Button deleteDataButton;
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
		public System.Windows.Forms.Button checkbutton;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
		private System.Windows.Forms.DataGridViewComboBoxColumn Column5;
		
		
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
			this.checkbutton = new System.Windows.Forms.Button();
			this.changeDataButton = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// confirmButton
			// 
			this.confirmButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
			this.confirmButton.FlatAppearance.BorderSize = 0;
			this.confirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.confirmButton.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.confirmButton.ForeColor = System.Drawing.Color.White;
			this.confirmButton.Location = new System.Drawing.Point(0, 34);
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
			this.maskedTextBox1.Location = new System.Drawing.Point(483, 42);
			this.maskedTextBox1.Mask = "00/00/0000";
			this.maskedTextBox1.Name = "maskedTextBox1";
			this.maskedTextBox1.Size = new System.Drawing.Size(120, 20);
			this.maskedTextBox1.TabIndex = 6;
			this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
			this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.MaskedTextBox1MaskInputRejected);
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
			this.numericUpDown1.ForeColor = System.Drawing.Color.White;
			this.numericUpDown1.Location = new System.Drawing.Point(351, 42);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
			this.numericUpDown1.TabIndex = 5;
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
			this.textBox1.ForeColor = System.Drawing.Color.White;
			this.textBox1.Location = new System.Drawing.Point(189, 42);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(150, 20);
			this.textBox1.TabIndex = 3;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 8.25F);
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Thistle;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
			this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView1.BackgroundColor = System.Drawing.Color.LavenderBlush;
			this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.Thistle;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Thistle;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepPink;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.Column5});
			this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
			this.dataGridView1.Location = new System.Drawing.Point(0, 26);
			this.dataGridView1.Name = "dataGridView1";
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Thistle;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(651, 156);
			this.dataGridView1.TabIndex = 0;
			// 
			// Column5
			// 
			this.Column5.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
			this.Column5.HeaderText = "ButtonColumn";
			this.Column5.Items.AddRange(new object[] {
			"csdfas",
			"aSADd",
			"Фрукты"});
			this.Column5.Name = "Column5";
			this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// addDataButton
			// 
			this.addDataButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
			this.addDataButton.FlatAppearance.BorderSize = 0;
			this.addDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.addDataButton.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addDataButton.ForeColor = System.Drawing.Color.White;
			this.addDataButton.Location = new System.Drawing.Point(0, 188);
			this.addDataButton.Name = "addDataButton";
			this.addDataButton.Size = new System.Drawing.Size(131, 41);
			this.addDataButton.TabIndex = 8;
			this.addDataButton.Text = "Добавить данные";
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
			this.deleteDataButton.Location = new System.Drawing.Point(145, 188);
			this.deleteDataButton.Name = "deleteDataButton";
			this.deleteDataButton.Size = new System.Drawing.Size(131, 41);
			this.deleteDataButton.TabIndex = 2;
			this.deleteDataButton.Text = "Удалить данные";
			this.deleteDataButton.UseVisualStyleBackColor = false;
			this.deleteDataButton.Click += new System.EventHandler(this.DeleteDataButtonClick);
			// 
			// refreshButton
			// 
			this.refreshButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
			this.refreshButton.FlatAppearance.BorderSize = 0;
			this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.refreshButton.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.refreshButton.ForeColor = System.Drawing.Color.White;
			this.refreshButton.Location = new System.Drawing.Point(440, 188);
			this.refreshButton.Name = "refreshButton";
			this.refreshButton.Size = new System.Drawing.Size(71, 41);
			this.refreshButton.TabIndex = 4;
			this.refreshButton.Text = "Обновить данные";
			this.refreshButton.UseVisualStyleBackColor = false;
			this.refreshButton.Click += new System.EventHandler(this.RefreshButtonClick);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Location = new System.Drawing.Point(12, 1);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.checkbutton);
			this.splitContainer1.Panel1.Controls.Add(this.changeDataButton);
			this.splitContainer1.Panel1.Controls.Add(this.refreshButton);
			this.splitContainer1.Panel1.Controls.Add(this.deleteDataButton);
			this.splitContainer1.Panel1.Controls.Add(this.addDataButton);
			this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Gainsboro;
			this.splitContainer1.Panel2.Controls.Add(this.label3);
			this.splitContainer1.Panel2.Controls.Add(this.label2);
			this.splitContainer1.Panel2.Controls.Add(this.label1);
			this.splitContainer1.Panel2.Controls.Add(this.textBox1);
			this.splitContainer1.Panel2.Controls.Add(this.numericUpDown1);
			this.splitContainer1.Panel2.Controls.Add(this.maskedTextBox1);
			this.splitContainer1.Panel2.Controls.Add(this.confirmButton);
			this.splitContainer1.Size = new System.Drawing.Size(660, 314);
			this.splitContainer1.SplitterDistance = 232;
			this.splitContainer1.SplitterWidth = 1;
			this.splitContainer1.TabIndex = 7;
			// 
			// checkbutton
			// 
			this.checkbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
			this.checkbutton.FlatAppearance.BorderSize = 0;
			this.checkbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkbutton.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkbutton.ForeColor = System.Drawing.Color.White;
			this.checkbutton.Location = new System.Drawing.Point(522, 188);
			this.checkbutton.Name = "checkbutton";
			this.checkbutton.Size = new System.Drawing.Size(128, 41);
			this.checkbutton.TabIndex = 10;
			this.checkbutton.Text = "Проверить состояние продуктов";
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
			this.changeDataButton.Location = new System.Drawing.Point(292, 188);
			this.changeDataButton.Name = "changeDataButton";
			this.changeDataButton.Size = new System.Drawing.Size(131, 41);
			this.changeDataButton.TabIndex = 9;
			this.changeDataButton.Text = "Изменить данные";
			this.changeDataButton.UseVisualStyleBackColor = false;
			this.changeDataButton.Click += new System.EventHandler(this.ChangeDataButtonClick);
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Gainsboro;
			this.label3.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(483, 24);
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
			this.label2.Location = new System.Drawing.Point(351, 24);
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
			this.label1.Location = new System.Drawing.Point(189, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(150, 17);
			this.label1.TabIndex = 7;
			this.label1.Text = "Наименование товара";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.настройкиToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(766, 24);
			this.menuStrip1.TabIndex = 8;
			this.menuStrip1.Text = "menuStrip1";
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
			this.ClientSize = new System.Drawing.Size(766, 310);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.splitContainer1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "ProductsForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Управление товарами";
			this.Load += new System.EventHandler(this.ProductsFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}}