
namespace auth
{
	partial class SettingsForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox groupBox1;
		internal System.Windows.Forms.RadioButton manualWithButtonsOption;
		internal System.Windows.Forms.RadioButton autoSaveOption;
		internal System.Windows.Forms.RadioButton onlySaveOption;
		private System.Windows.Forms.ToolTip RadioButtonTip;
		private System.Windows.Forms.Button goToHomeButton;
		
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.manualWithButtonsOption = new System.Windows.Forms.RadioButton();
			this.autoSaveOption = new System.Windows.Forms.RadioButton();
			this.onlySaveOption = new System.Windows.Forms.RadioButton();
			this.RadioButtonTip = new System.Windows.Forms.ToolTip(this.components);
			this.goToHomeButton = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.manualWithButtonsOption);
			this.groupBox1.Controls.Add(this.autoSaveOption);
			this.groupBox1.Controls.Add(this.onlySaveOption);
			this.groupBox1.Location = new System.Drawing.Point(8, 56);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(269, 139);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Выберите метод заполнения таблицы";
			// 
			// manualWithButtonsOption
			// 
			this.manualWithButtonsOption.Location = new System.Drawing.Point(11, 95);
			this.manualWithButtonsOption.Name = "manualWithButtonsOption";
			this.manualWithButtonsOption.Size = new System.Drawing.Size(190, 38);
			this.manualWithButtonsOption.TabIndex = 0;
			this.manualWithButtonsOption.Text = "Заполнение с полями и ручным  сохранением";
			this.manualWithButtonsOption.UseVisualStyleBackColor = true;
			this.manualWithButtonsOption.CheckedChanged += new System.EventHandler(this.ManualWithButtonsOptionCheckedChanged);
			// 
			// autoSaveOption
			// 
			this.autoSaveOption.Location = new System.Drawing.Point(11, 59);
			this.autoSaveOption.Name = "autoSaveOption";
			this.autoSaveOption.Size = new System.Drawing.Size(232, 32);
			this.autoSaveOption.TabIndex = 0;
			this.autoSaveOption.Text = "Заполнение без полей с автоматическим сохранением";
			this.autoSaveOption.UseVisualStyleBackColor = true;
			this.autoSaveOption.CheckedChanged += new System.EventHandler(this.AutoSaveOptionCheckedChanged);
			// 
			// onlySaveOption
			// 
			this.onlySaveOption.Checked = true;
			this.onlySaveOption.Location = new System.Drawing.Point(11, 23);
			this.onlySaveOption.Name = "onlySaveOption";
			this.onlySaveOption.Size = new System.Drawing.Size(217, 32);
			this.onlySaveOption.TabIndex = 0;
			this.onlySaveOption.TabStop = true;
			this.onlySaveOption.Text = "Заполнение без полей с ручным сохранением ( рекомендуется )";
			this.onlySaveOption.UseVisualStyleBackColor = true;
			this.onlySaveOption.CheckedChanged += new System.EventHandler(this.onlySaveOptionCheckedChanged);
			// 
			// goToHomeButton
			// 
			this.goToHomeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
			this.goToHomeButton.FlatAppearance.BorderSize = 0;
			this.goToHomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.goToHomeButton.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.goToHomeButton.ForeColor = System.Drawing.Color.White;
			this.goToHomeButton.Image = ((System.Drawing.Image)(resources.GetObject("goToHomeButton.Image")));
			this.goToHomeButton.Location = new System.Drawing.Point(8, 8);
			this.goToHomeButton.Name = "goToHomeButton";
			this.goToHomeButton.Size = new System.Drawing.Size(34, 35);
			this.goToHomeButton.TabIndex = 5;
			this.goToHomeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.goToHomeButton.UseVisualStyleBackColor = false;
			this.goToHomeButton.Click += new System.EventHandler(this.GoToHomeButtonClick);
			// 
			// SettingsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Gainsboro;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.goToHomeButton);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "SettingsForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Настройки";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsFormClosing);
			this.Load += new System.EventHandler(this.SettingsFormLoad);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
