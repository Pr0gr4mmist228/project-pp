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
	public class CardProperties
	{	
		public CardProperties()
		{
			
		}
		
		public static bool IdIsExist(uint itemId)
		{
			using (SqlConnection connection = new SqlConnection(ProductsForm.connectionString)) {
				connection.Open();
				SqlCommand cmd = new SqlCommand("SELECT id FROM Images WHERE id ="+ itemId,connection);
				SqlDataReader reader = cmd.ExecuteReader();
				if(reader.HasRows){
						return true;
				}
					return false;
			}
		}
		public static string GetImageLocation(uint itemId){
			using(SqlConnection connection = new SqlConnection(ProductsForm.connectionString)){
				connection.Open();
				SqlCommand command = new SqlCommand("SELECT FileLocation FROM Images WHERE id =" + itemId,connection);
				SqlDataReader reader = command.ExecuteReader();
				if (reader.HasRows) {
					while (reader.Read()) {
						string imageLocation = reader.GetValue(0).ToString();
						return imageLocation;
					}
				}
					return "";
			}
		}
		public static void SetImageLocation(uint itemId, string imageLocation){
			using(SqlConnection connection = new SqlConnection(ProductsForm.connectionString)){
				connection.Open();
				SqlCommand command = new SqlCommand("INSERT INTO Images(Id,FileLocation) VALUES ('" + itemId + "','"+ imageLocation +"')",connection);
				int result = command.ExecuteNonQuery();
				if(result > 0){
					MessageBox.Show("Добавление успешно");
				}
				else
				MessageBox.Show("Ошибка добавления");
			}
		}
		public static void UpdateImageLocation(uint itemId,string imageLocation){
			using(SqlConnection connection = new SqlConnection(ProductsForm.connectionString)){
				connection.Open();
				SqlCommand command = new SqlCommand("UPDATE Images SET FileLocation = '"+ imageLocation +"' WHERE id="+itemId,connection);
				int result = command.ExecuteNonQuery();
				if(result > 0){
					MessageBox.Show("Изменение успешно");
				}
				else
					MessageBox.Show("Ошибка изменения");
			}
		}
	}
}