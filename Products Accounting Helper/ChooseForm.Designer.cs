
namespace auth
{
	partial class ChooseForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button showProductsForm;
		private System.Windows.Forms.Button showCardForm;
		private System.Windows.Forms.Button findItemsFormShow;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button showSettingsForm;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseForm));
			this.showProductsForm = new System.Windows.Forms.Button();
			this.showCardForm = new System.Windows.Forms.Button();
			this.findItemsFormShow = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.showSettingsForm = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// showProductsForm
			// 
			this.showProductsForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
			this.showProductsForm.FlatAppearance.BorderSize = 0;
			this.showProductsForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.showProductsForm.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.showProductsForm.ForeColor = System.Drawing.Color.White;
			this.showProductsForm.Image = ((System.Drawing.Image)(resources.GetObject("showProductsForm.Image")));
			this.showProductsForm.Location = new System.Drawing.Point(24, 32);
			this.showProductsForm.Name = "showProductsForm";
			this.showProductsForm.Size = new System.Drawing.Size(168, 56);
			this.showProductsForm.TabIndex = 5;
			this.showProductsForm.Text = "Управление продуктами";
			this.showProductsForm.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.showProductsForm.UseVisualStyleBackColor = false;
			this.showProductsForm.Click += new System.EventHandler(this.ShowProductsFormClick);
			// 
			// showCardForm
			// 
			this.showCardForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
			this.showCardForm.FlatAppearance.BorderSize = 0;
			this.showCardForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.showCardForm.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.showCardForm.ForeColor = System.Drawing.Color.White;
			this.showCardForm.Image = ((System.Drawing.Image)(resources.GetObject("showCardForm.Image")));
			this.showCardForm.Location = new System.Drawing.Point(24, 176);
			this.showCardForm.Name = "showCardForm";
			this.showCardForm.Size = new System.Drawing.Size(168, 56);
			this.showCardForm.TabIndex = 5;
			this.showCardForm.Text = "Карточка продукта";
			this.showCardForm.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.showCardForm.UseVisualStyleBackColor = false;
			this.showCardForm.Click += new System.EventHandler(this.findProductsFormShow);
			// 
			// findItemsFormShow
			// 
			this.findItemsFormShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
			this.findItemsFormShow.FlatAppearance.BorderSize = 0;
			this.findItemsFormShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.findItemsFormShow.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.findItemsFormShow.ForeColor = System.Drawing.Color.White;
			this.findItemsFormShow.Image = ((System.Drawing.Image)(resources.GetObject("findItemsFormShow.Image")));
			this.findItemsFormShow.Location = new System.Drawing.Point(24, 104);
			this.findItemsFormShow.Name = "findItemsFormShow";
			this.findItemsFormShow.Size = new System.Drawing.Size(168, 56);
			this.findItemsFormShow.TabIndex = 5;
			this.findItemsFormShow.Text = "Найти продукты";
			this.findItemsFormShow.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.findItemsFormShow.UseVisualStyleBackColor = false;
			this.findItemsFormShow.Click += new System.EventHandler(this.FindCardItemShowClick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Location = new System.Drawing.Point(0, 32);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(392, 264);
			this.pictureBox1.TabIndex = 6;
			this.pictureBox1.TabStop = false;
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
			this.groupBox1.Controls.Add(this.findItemsFormShow);
			this.groupBox1.Controls.Add(this.showSettingsForm);
			this.groupBox1.Controls.Add(this.showCardForm);
			this.groupBox1.Controls.Add(this.showProductsForm);
			this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.groupBox1.Location = new System.Drawing.Point(408, 16);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(208, 312);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Выберите опцию";
			// 
			// showSettingsForm
			// 
			this.showSettingsForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
			this.showSettingsForm.FlatAppearance.BorderSize = 0;
			this.showSettingsForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.showSettingsForm.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.showSettingsForm.ForeColor = System.Drawing.Color.White;
			this.showSettingsForm.Image = ((System.Drawing.Image)(resources.GetObject("showSettingsForm.Image")));
			this.showSettingsForm.Location = new System.Drawing.Point(24, 248);
			this.showSettingsForm.Name = "showSettingsForm";
			this.showSettingsForm.Size = new System.Drawing.Size(168, 56);
			this.showSettingsForm.TabIndex = 5;
			this.showSettingsForm.Text = "Настройки";
			this.showSettingsForm.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.showSettingsForm.UseVisualStyleBackColor = false;
			this.showSettingsForm.Click += new System.EventHandler(this.ShowSettingsFormClick);
			// 
			// ChooseForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Gainsboro;
			this.ClientSize = new System.Drawing.Size(624, 336);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.pictureBox1);
			this.Name = "ChooseForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Выбор опции";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChooseFormClosing);
			this.Load += new System.EventHandler(this.ChooseFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
