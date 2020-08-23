using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace auth
{
	public partial class AuthorizationForm : Form
	{
		public AuthorizationForm()
		{
			InitializeComponent();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			if (loginBox.Text != "Введите логин" && passwordBox.Text != "Введите пароль") {
				string connString = "Server=localhost\\MSSQLSERVER01;Database=main;Trusted_Connection=True;";
				SqlConnection con = new SqlConnection(connString);
				con.Open();
				string login = loginBox.Text;
				string password = passwordBox.Text;
				SqlCommand comm = new SqlCommand("SELECT login,password FROM auth WHERE [login] = @userLogin COLLATE Latin1_General_100_CS_AI AND [password] = @userPassword COLLATE Latin1_General_100_CS_AI", con);
				comm.Parameters.Add("@userLogin", SqlDbType.NChar).Value = login;
				comm.Parameters.Add("@userPassword", SqlDbType.NChar).Value = password;
				SqlDataReader reader = comm.ExecuteReader();
				if (reader.HasRows) {
					MessageBox.Show("Успешный вход", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
					con.Close();
					ProductsForm asd = new ProductsForm();
					asd.Show();
					this.Hide();
				} else {
					MessageBox.Show("Проверьте правильность логина и пароля", "Вход не удался.", MessageBoxButtons.OK, MessageBoxIcon.Error);
					con.Close();
				}
			} else
				errorProvider.SetError(button1, "Одно из полей пустое");
		}
		void AuthorizationFormLoad(object sender, EventArgs e)
		{
			loginBox.GotFocus += loginBox_GotFocus;
			loginBox.LostFocus += loginBox_LostFocus;
			passwordBox.GotFocus += loginBox_GotFocus;
			passwordBox.LostFocus += loginBox_LostFocus;
		}

		void loginBox_LostFocus(object sender, EventArgs e)
		{	if(!passwordBox.Focused){
				if (passwordBox.Text == "") {
					passwordBox.Text = "Введите пароль";
					passwordBox.PasswordChar = '\0';
				}
			}
			if (!loginBox.Focused) {
				if (loginBox.Text == "") {
					loginBox.Text = "Введите логин";
				}
			}
		}
		void loginBox_GotFocus(object sender, EventArgs e)
		{
			if(passwordBox.Focused)
			{
				if (passwordBox.Text == "Введите пароль") {
					passwordBox.Clear();
					passwordBox.PasswordChar = '*';
				}
			}
			if (loginBox.Focused) {
				if (loginBox.Text == "Введите логин") {
					loginBox.Clear();
				}
			}
		}	
	}
}
		
