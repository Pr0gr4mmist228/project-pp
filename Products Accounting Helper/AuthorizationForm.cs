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
			string connString = "Server=localhost\\MSSQLSERVER01;Database=main;Trusted_Connection=True;";
			SqlConnection con = new SqlConnection(connString);
			con.Open();
			string login = textBox1.Text;
			string password = textBox2.Text;
			SqlCommand comm = new SqlCommand("SELECT login,password FROM auth WHERE [login] = @userLogin COLLATE Latin1_General_100_CS_AI AND [password] = @userPassword COLLATE Latin1_General_100_CS_AI",con);
			comm.Parameters.Add("@userLogin",SqlDbType.NChar).Value = login;
			comm.Parameters.Add("@userPassword",SqlDbType.NChar).Value = password;
			SqlDataReader reader = comm.ExecuteReader();
			if (reader.HasRows)
			{
				MessageBox.Show("Успешный вход","Успех",MessageBoxButtons.OK,MessageBoxIcon.Information);
				con.Close();
				ProductsForm asd = new ProductsForm();
				asd.Show();
				this.Hide();
			}
			else{ MessageBox.Show("Проверьте правильность логина и пароля","Вход не удался.",MessageBoxButtons.OK,MessageBoxIcon.Error);
				con.Close();}
		}
		void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Button1Click(sender,e);
            }
        }
		void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
          if (e.KeyCode == Keys.Enter)
          {
                Button1Click(sender,e);
          }
        }
		void AuthorizationFormLoad(object sender, EventArgs e)
		{
	
		}		
	}
}
		
