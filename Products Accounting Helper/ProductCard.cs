
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
		
		public ProductCard(uint itemId, string itemName, uint itemQuantity, string itemDate,string type)
		{
			InitializeComponent();
			
			ImageTypeChoose.picture = itemPicture;
			ImageTypeChoose.itemId = itemId;
			
			this.itemId = itemId;
			Height = 245;
			
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
				isPictureGot = true;
				itemPicture.BackgroundImage = null;
			}
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
			ImageTypeChoose imageDialog = new ImageTypeChoose();
			imageDialog.ShowDialog();
		}
		public static void SetFileLocation(string fileLocation, uint itemId){
				if (!ProductsForm.idIsExist) {
					CardProperties.SetImageLocation(itemId, fileLocation);
				} else {
					CardProperties.UpdateImageLocation(itemId, fileLocation);
				}
				isPictureGot = true;
		}
		
		void SaveDateButtonClick(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection(ProductsForm.connectionString)) {
				connection.Open();
				SqlCommand cmd = new SqlCommand("UPDATE test SET Srok = '" + dateTimePicker.Value + "' WHERE id = " + itemId, connection);
				int result = cmd.ExecuteNonQuery();
				if(result > 0)
					{
					MessageBox.Show("Успешное изменение даты","Успех!",MessageBoxButtons.OK,MessageBoxIcon.Information);
					prodForm.RefreshButtonClick(sender, e);
					} else
					MessageBox.Show("Изменение не удалось", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		void collapseButtonClick(object sender, EventArgs e)
		{
			if(!isCollapsed){
				Height = 361;	
				isCollapsed = true;
				collapseButton.Text = "Закончить изменение данных";
			} else if (isCollapsed) {
				Height = 245;
				isCollapsed = false;
				collapseButton.Text = "Изменить данные";
			}
		}
		void ConfirmButtonClick(object sender, EventArgs e)
		{
			if(String.IsNullOrWhiteSpace(nameTextBox.Text) || String.IsNullOrWhiteSpace(quantityUpdown.Value.ToString()) || String.IsNullOrWhiteSpace(dateMaskedTextBox.Text) || itemTypeComboBox.Text != ""){
			try{
			using(SqlConnection connection = new SqlConnection(connectionString)){
				connection.Open();
				SqlCommand command = new SqlCommand("UPDATE test SET Name=@name,Quantity=@quantity,Srok=@srok, Type=@type WHERE id =" + itemId,connection);
				command.Parameters.AddWithValue("@name",nameTextBox.Text);
				command.Parameters.AddWithValue("@quantity", quantityUpdown.Value);
				command.Parameters.AddWithValue("@srok", dateMaskedTextBox.Text);
				command.Parameters.AddWithValue("@type",itemTypeComboBox.Text);
				if(command.ExecuteNonQuery() > 0){
					MessageBox.Show("Успешное изменение данных","Успех!",MessageBoxButtons.OK,MessageBoxIcon.Information);
					LoadFormItems();
				}
				else
					MessageBox.Show("Изменение не удалось","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
				}
				}
				catch(SqlException ex){
				MessageBox.Show("Изменение не удалось\n" + ex.Message,"Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
				}
				} else
				errorProvider.SetError(confirmButton, "Одно из значений пустое");

		}
		void LoadFormItems(){
			typeLabel.Text = itemTypeComboBox.Text;
			quantityLabel.Text = quantityUpdown.Value.ToString();
			dateLabel.Text = dateMaskedTextBox.Text;
			itemNamelabel.Text = nameTextBox.Text;
		}
		void GoToHomeButtonClick(object sender, EventArgs e)
		{
			new ChooseForm().Show();
			Close();
		}
		void ProductCard_Closing(object sender, FormClosingEventArgs e)
		{
			
		}
	}
}
