
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Collections.Generic;
using System.Runtime;

namespace auth
{
	public partial class ProductCard : Form
	{
		ProductsForm prodForm = new ProductsForm();
		string connectionString = ProductsForm.connectionString;
		public static bool isPictureGot = false;
		uint itemId;
		
		bool isCollapsed = false;
		
		public ProductCard(uint itemId, string itemName, uint itemQuantity, string itemDate, string type)
		{
			InitializeComponent();
			
			this.itemId = itemId;
			
			Height = 222;
			
			itemPicture.DoubleClick += itemPicture_DoubleClick;
			itemPicture.MouseHover += itemPicture_MouseHover;
			
			idLabel.Text = itemId.ToString();
			itemNamelabel.Text = itemName;
			quantityLabel.Text = itemQuantity.ToString();
			dateLabel.Text = itemDate.Substring(0,10);
			typeLabel.Text = type;
			dateTimePicker.Value = Convert.ToDateTime(itemDate);
			
			nameTextBox.Text = itemName;
			quantityUpdown.Value = itemQuantity;
			dateMaskedTextBox.Text = dateLabel.Text;
			
			if (ProductsForm.idIsExist) {
				itemPicture.ImageLocation = CardProperties.GetImageLocation(itemId);
			}
		}

		public void SetCardProperties()
		{
			
		}
		
		void itemPicture_MouseHover(object sender, EventArgs e)
		{
			if (!isPictureGot) {
				pictureAddTip.Show("Вы можете добавить изображение товара двойным щелчком мыши", itemPicture, 5000);
			} else
				pictureAddTip.Hide(itemPicture);
		}
		
		void itemPicture_DoubleClick(object sender, EventArgs e)
		{
			openFileDialog.ShowDialog();
			itemPicture.ImageLocation = openFileDialog.FileName;
			string imageLocation = itemPicture.ImageLocation;
			if (!ProductsForm.idIsExist) {
				CardProperties.SetImageLocation(itemId, imageLocation);
			} else {
				CardProperties.UpdateImageLocation(itemId, imageLocation);
			}
			isPictureGot = true;
			
		}
		void ProductCardLoad(object sender, EventArgs e)
		{
	
		}
		void SaveDateButtonClick(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection(ProductsForm.connectionString)) {
				connection.Open();
				SqlCommand cmd = new SqlCommand("UPDATE test SET Srok = '" + dateTimePicker.Value + "' WHERE id = " + itemId, connection);
				int result = cmd.ExecuteNonQuery();
				if(result > 0)
					{
					MessageBox.Show("Изменение даты успешно");
					prodForm.RefreshButtonClick(sender, e);
					}
				else
					MessageBox.Show("Ошибка изменения");
			}
		}
		void Button1Click(object sender, EventArgs e)
		{
			if(!isCollapsed){
				Height = 341;	
				isCollapsed = true;
				collapseButton.Text = "Закончить изменение данных";
			} else if (isCollapsed) {
				Height = 222;
				isCollapsed = false;
				collapseButton.Text = "Изменить данные";
			}
		}
	}
}
