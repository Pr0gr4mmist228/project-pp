using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Collections.Generic;


namespace auth
{
	public partial class FindItems : Form
	{
		public static DataSet dataSet;
		SqlDataAdapter adap;
		string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
		
		ChooseForm choose;
		
		public static Button addDataButton;
		
		public FindItems()
		{
			InitializeComponent();
			
			using(SqlConnection connection = new SqlConnection(connectionString)){
			connection.Open();
			adap = new SqlDataAdapter("SELECT * FROM test", connection);
			dataSet = new DataSet();
			adap.Fill(dataSet);
			dataGridView1.DataSource = dataSet.Tables[0];
			
			FormClosing += FindItems_FormClosing;
			}
		}
		
		public FindItems(ChooseForm choose)
		{
			InitializeComponent();
			
			using(SqlConnection connection = new SqlConnection(connectionString)){
			connection.Open();
			adap = new SqlDataAdapter("SELECT * FROM test", connection);
			dataSet = new DataSet();
			adap.Fill(dataSet);
			dataGridView1.DataSource = dataSet.Tables[0];
			
			FormClosing += FindItems_FormClosing;
			this.choose = choose;
			}
		}
		
		void ButtonFindClick(object sender, EventArgs e)
		{
			using(SqlConnection connection = new SqlConnection(connectionString)){
				connection.Open();
				if (nameBox.Text != "" && quantityBox.Value != 0 && groupBox.Text != "") {
					adap = new SqlDataAdapter("SELECT Name,Quantity,Srok,Type FROM test WHERE Name = '" + nameBox.Text + "' OR Quantity = '" + quantityBox.Value + "' AND Type = '" + groupBox.Text + "'", connection);
				}
				else if(nameBox.Text != ""  && quantityBox.Value == 0 && groupBox.Text == ""){
					adap = new SqlDataAdapter("SELECT Name,Quantity,Srok,Type FROM test WHERE Name = '" + nameBox.Text + "'", connection);
				}
				else if(nameBox.Text != "" && groupBox.Text != "" && quantityBox.Value == 0){
					adap = new SqlDataAdapter("SELECT Name,Quantity,Srok,Type FROM test WHERE Name = '" + nameBox.Text + "' AND Type = '"+groupBox.Text+"'", connection);
				}
				else if(nameBox.Text != "" && quantityBox.Value != 0 && groupBox.Text == ""){
					adap = new SqlDataAdapter("SELECT Name,Quantity,Srok,Type FROM test WHERE Name = '" + nameBox.Text + "' AND Quantity = '"+quantityBox.Value+"'", connection);
				}
				else if(groupBox.Text != "" && nameBox.Text == "" && quantityBox.Value == 0)
				{
					adap = new SqlDataAdapter("SELECT Name,Quantity,Srok,Type FROM test WHERE Type = '"+groupBox.Text+"'", connection);
				}
				else if(quantityBox.Value != 0) adap = new SqlDataAdapter("SELECT Name,Quantity,Srok,Type FROM test WHERE Quantity = '"+quantityBox.Value+"'", connection);
					dataSet = new DataSet();
					adap.Fill(dataSet);
					dataGridView1.DataSource = dataSet.Tables[0];
			}
		}
		
		void ButtonResetClick(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection(connectionString)) {
				connection.Open();
				adap = new SqlDataAdapter("SELECT * FROM test", connection);
				dataSet = new DataSet();
				adap.Fill(dataSet);
				dataGridView1.DataSource = dataSet.Tables[0];
			}
			}
		void FindDateButtonClick(object sender, EventArgs e)
		{
			DateTime date = DateTime.Now;
			
			int fromDay = dateTimePicker1.Value.Day;
			int fromMouth = dateTimePicker1.Value.Month;
			int fromYear = dateTimePicker1.Value.Year;
			
			int toDay = dateTimePicker2.Value.Day;
			int toMouth = dateTimePicker2.Value.Month;
			int toYear = dateTimePicker2.Value.Year;
			
			string toDate = fromYear + "." + fromMouth +"." + fromDay;
			string fromDate = toYear + "."+ toMouth +"."+ toDay;
			
			
			if ((toDay - fromDay >= 0 && toMouth - fromMouth >= 0) || (toYear - fromYear >= 1)) {
				using (SqlConnection connection = new SqlConnection(connectionString)) {
					connection.Open();
					SqlCommand command = new SqlCommand("SELECT * FROM test WHERE Srok >= '" + toDate + "' AND Srok <= '" + fromDate + "'",connection);
					SqlDataReader reader = command.ExecuteReader();
					if (reader.HasRows) {
						reader.Close();
						adap = new SqlDataAdapter(command.CommandText,connection);
						dataSet = new DataSet();
						adap.Fill(dataSet);
						dataGridView1.DataSource = dataSet.Tables[0];
					}
					else MessageBox.Show("Продуктов со сроком годности в заданном промежутке не существует","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
				}
				}
				else
					MessageBox.Show("Дата отсчета позже чем дата окончания","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		void IdSearchButtonClick(object sender, EventArgs e)
		{
				using (SqlConnection connection = new SqlConnection(connectionString)) {
					connection.Open();
					SqlCommand command = new SqlCommand("SELECT * FROM test WHERE id =" + idBox.Value, connection);
					SqlDataReader reader = command.ExecuteReader();
					if (reader.HasRows) {
						reader.Close();
						adap = new SqlDataAdapter(command.CommandText, connection);
						dataSet = new DataSet();
						adap.Fill(dataSet);
						dataGridView1.DataSource = dataSet.Tables[0];
					} else
						MessageBox.Show("Такого ID не существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}

		void FindItems_FormClosing(object sender, FormClosingEventArgs e)
		{
			addDataButton.Enabled = true;
		}
		void GoToHomeButtonClick(object sender, EventArgs e)
		{
			choose.Visible = true;
			Visible = false;
		}
		void FindItemsLoad(object sender, EventArgs e)
		{
	
		}
		}
	}
