
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.manualWithButtonsOption = new System.Windows.Forms.RadioButton();
			this.autoSaveOption = new System.Windows.Forms.RadioButton();
			this.onlySaveOption = new System.Windows.Forms.RadioButton();
			this.RadioButtonTip = new System.Windows.Forms.ToolTip(this.components);
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.manualWithButtonsOption);
			this.groupBox1.Controls.Add(this.autoSaveOption);
			this.groupBox1.Controls.Add(this.onlySaveOption);
			this.groupBox1.Location = new System.Drawing.Point(8, 12);
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
			// SettingsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "SettingsForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SettingsForm";
			this.Load += new System.EventHandler(this.SettingsFormLoad);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
