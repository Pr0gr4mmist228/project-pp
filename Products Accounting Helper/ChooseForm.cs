
using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Data.SqlClient;

namespace auth
{
	public partial class ChooseForm : Form
	{
		SettingsForm settings;
		ProductsForm products;
		FindItems find;
		
		public ChooseForm()
		{
			InitializeComponent();
			
			settings = new SettingsForm(this) { Visible = false };
			products = new ProductsForm(this) { Visible = false };
			find = new FindItems(this) { Visible = false };
		}
		void ChooseFormLoad(object sender, EventArgs e)
		{
			
		}
		void ShowProductsFormClick(object sender, EventArgs e)
		{
			Visible = false;
			products.Visible = true;
		}
		void findProductsFormShow(object sender, EventArgs e)
		{
			string itemId = Interaction.InputBox("Введите ID продукта");
			if(itemId != ""){
				using (SqlConnection connection = new SqlConnection(ProductsForm.connectionString)) {
					connection.Open();
					SqlCommand command = new SqlCommand("SELECT * FROM test WHERE id =" + itemId, connection);
					SqlDataReader reader = command.ExecuteReader();
					if (reader.HasRows) {
						while (reader.Read()) {
							ItemProperties.itemId = Convert.ToUInt32(reader.GetValue(0));
							ItemProperties.itemName = reader.GetValue(1).ToString();
							ItemProperties.itemQuantity = Convert.ToUInt32(reader.GetValue(2));
							ItemProperties.itemDate = reader.GetValue(3).ToString();
							ItemProperties.itemType = reader.GetValue(4).ToString();
						}
						reader.Close();
						ProductsForm.idIsExist = CardProperties.IdIsExist(ItemProperties.itemId);
					new ProductCard(ItemProperties.itemId, ItemProperties.itemName, ItemProperties.itemQuantity, ItemProperties.itemDate, ItemProperties.itemType).ShowDialog();
					} else{
						MessageBox.Show("Такого ID не существует","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
					}
				}
			}
			
		}
		void FindCardItemShowClick(object sender, EventArgs e)
		{
			find.Visible = true;
		}
		void ShowSettingsFormClick(object sender, EventArgs e)
		{
			Visible = false;
			settings.Visible = true;
		}
		void ChooseFormClosing(object sender, FormClosingEventArgs e)
		{
			var result = MessageBox.Show("Вы действительно хотите закрыть окно?", "Подтверждение действия", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
			if (result == DialogResult.No) {
				e.Cancel = true;
			} else if (result == DialogResult.Yes) {
				Application.Exit();
			} else if (result == DialogResult.Cancel) {
				e.Cancel = true;
			}
		}
	}
}
