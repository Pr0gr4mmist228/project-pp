/*
 * Создано в SharpDevelop.
 * Пользователь: artem
 * Дата: 04.05.2020
 * Время: 14:45
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System.Windows.Forms;
namespace auth
{
	partial class AuthorizationForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox loginBox;
		private System.Windows.Forms.TextBox passwordBox;
		private System.Windows.Forms.Button logInButton;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.ErrorProvider errorProvider;
		
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorizationForm));
			this.loginBox = new System.Windows.Forms.TextBox();
			this.passwordBox = new System.Windows.Forms.TextBox();
			this.logInButton = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
			this.SuspendLayout();
			// 
			// loginBox
			// 
			this.loginBox.BackColor = System.Drawing.Color.White;
			this.loginBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.loginBox.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.loginBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
			this.loginBox.Location = new System.Drawing.Point(56, 105);
			this.loginBox.Multiline = true;
			this.loginBox.Name = "loginBox";
			this.loginBox.Size = new System.Drawing.Size(223, 33);
			this.loginBox.TabIndex = 0;
			this.loginBox.Text = "Введите логин";
			this.loginBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.loginBox.WordWrap = false;
			// 
			// passwordBox
			// 
			this.passwordBox.BackColor = System.Drawing.Color.White;
			this.passwordBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.passwordBox.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.passwordBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
			this.passwordBox.Location = new System.Drawing.Point(56, 154);
			this.passwordBox.Multiline = true;
			this.passwordBox.Name = "passwordBox";
			this.passwordBox.PasswordChar = '*';
			this.passwordBox.Size = new System.Drawing.Size(223, 33);
			this.passwordBox.TabIndex = 0;
			this.passwordBox.Text = "Введите пароль";
			this.passwordBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.passwordBox.WordWrap = false;
			// 
			// logInButton
			// 
			this.logInButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
			this.logInButton.FlatAppearance.BorderSize = 0;
			this.logInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.logInButton.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.logInButton.ForeColor = System.Drawing.Color.White;
			this.logInButton.Image = ((System.Drawing.Image)(resources.GetObject("logInButton.Image")));
			this.logInButton.Location = new System.Drawing.Point(104, 208);
			this.logInButton.Name = "logInButton";
			this.logInButton.Size = new System.Drawing.Size(84, 65);
			this.logInButton.TabIndex = 1;
			this.logInButton.Text = "Войти";
			this.logInButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.logInButton.UseVisualStyleBackColor = false;
			this.logInButton.Click += new System.EventHandler(this.Button1Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
			this.panel1.Controls.Add(this.label3);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(292, 61);
			this.panel1.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
			this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label3.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(0, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(292, 61);
			this.label3.TabIndex = 0;
			this.label3.Text = "Авторизация";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(2, 100);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(46, 40);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(2, 150);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(46, 39);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 5;
			this.pictureBox2.TabStop = false;
			// 
			// errorProvider
			// 
			this.errorProvider.ContainerControl = this;
			// 
			// AuthorizationForm
			// 
			this.AcceptButton = this.logInButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.Color.Gainsboro;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.ClientSize = new System.Drawing.Size(292, 285);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.logInButton);
			this.Controls.Add(this.passwordBox);
			this.Controls.Add(this.loginBox);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "AuthorizationForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Авторизация";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.AuthorizationFormLoad);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
