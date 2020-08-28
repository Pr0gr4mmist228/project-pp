
namespace auth
{
	partial class ImageTypeChoose
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button chooseFromCompButton;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox urlBox;
		private System.Windows.Forms.Button acceptButton;
		private System.Windows.Forms.ErrorProvider errorProvider;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageTypeChoose));
			this.chooseFromCompButton = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.urlBox = new System.Windows.Forms.TextBox();
			this.acceptButton = new System.Windows.Forms.Button();
			this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
			this.SuspendLayout();
			// 
			// chooseFromCompButton
			// 
			this.chooseFromCompButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
			this.chooseFromCompButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.chooseFromCompButton.Font = new System.Drawing.Font("Segoe UI Emoji", 9F);
			this.chooseFromCompButton.ForeColor = System.Drawing.Color.White;
			this.chooseFromCompButton.Image = ((System.Drawing.Image)(resources.GetObject("chooseFromCompButton.Image")));
			this.chooseFromCompButton.Location = new System.Drawing.Point(99, 47);
			this.chooseFromCompButton.Name = "chooseFromCompButton";
			this.chooseFromCompButton.Size = new System.Drawing.Size(184, 48);
			this.chooseFromCompButton.TabIndex = 16;
			this.chooseFromCompButton.Text = "Выбрать картинку из компьютера";
			this.chooseFromCompButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.chooseFromCompButton.UseVisualStyleBackColor = false;
			this.chooseFromCompButton.Click += new System.EventHandler(this.ChooseFromCompButtonClick);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(109, 113);
			this.label4.Name = "label4";
			this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label4.Size = new System.Drawing.Size(160, 24);
			this.label4.TabIndex = 17;
			this.label4.Text = "Либо указать URL картинки";
			// 
			// urlBox
			// 
			this.urlBox.AllowDrop = true;
			this.urlBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
			this.urlBox.ForeColor = System.Drawing.Color.White;
			this.urlBox.Location = new System.Drawing.Point(99, 129);
			this.urlBox.Multiline = true;
			this.urlBox.Name = "urlBox";
			this.urlBox.Size = new System.Drawing.Size(184, 24);
			this.urlBox.TabIndex = 18;
			this.urlBox.Text = "Введите url-адрес картинки";
			this.urlBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.urlBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.UrlBoxDragDrop);
			// 
			// acceptButton
			// 
			this.acceptButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
			this.acceptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.acceptButton.Font = new System.Drawing.Font("Segoe UI Emoji", 9F);
			this.acceptButton.ForeColor = System.Drawing.Color.White;
			this.acceptButton.Image = ((System.Drawing.Image)(resources.GetObject("acceptButton.Image")));
			this.acceptButton.Location = new System.Drawing.Point(171, 177);
			this.acceptButton.Name = "acceptButton";
			this.acceptButton.Size = new System.Drawing.Size(40, 40);
			this.acceptButton.TabIndex = 16;
			this.acceptButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.acceptButton.UseVisualStyleBackColor = false;
			this.acceptButton.Click += new System.EventHandler(this.AcceptButtonClick);
			// 
			// errorProvider
			// 
			this.errorProvider.ContainerControl = this;
			// 
			// openFileDialog
			// 
			this.openFileDialog.FileName = "none";
			// 
			// ImageTypeChoose
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Gainsboro;
			this.ClientSize = new System.Drawing.Size(383, 264);
			this.Controls.Add(this.urlBox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.acceptButton);
			this.Controls.Add(this.chooseFromCompButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Location = new System.Drawing.Point(191, 0);
			this.Name = "ImageTypeChoose";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Выберите хранилище изображения";
			this.Load += new System.EventHandler(this.ImageTypeChooseLoad);
			this.DragDrop += new System.Windows.Forms.DragEventHandler(this.UrlBoxDragDrop);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
