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
	public partial class ProductsForm : Form
	{	
		bool status = false;
		SettingsForm settings = new SettingsForm();
		DataSet ds;
		SqlDataAdapter adapter;
		SqlCommandBuilder commandBuilder;
		string sql = "SELECT * FROM test";
		public static int optionId;
		public static string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
		public static bool idIsExist = false;
		
		public ProductsForm()
		{
			InitializeComponent();
			
			settings.addDataButton = this.addDataButton;
			settings.deleteDataButton = this.deleteDataButton;
			settings.changeDataButton = this.changeDataButton;
			settings.refreshButton = this.refreshButton;
			
			FormClosing += ProductsForm_FormClosing;
			
			dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;

			dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			using(SqlConnection connection = new SqlConnection(connectionString))
			 {
				connection.Open();
				adapter = new SqlDataAdapter(sql,connection);
				ds = new DataSet();
				adapter.Fill(ds);
				
				dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns["Id"].ReadOnly = true;
                dataGridView1.Columns[0].DisplayIndex = 4;
                dataGridView1.Columns[2].HeaderText = "Имя товара";
                dataGridView1.Columns[3].HeaderText = "Количество";
				dataGridView1.Columns[4].HeaderText = "Срок годности";
		  	}
		}

		void ProductsFormLoad(object sender, EventArgs e)
		{
			Height = 290;
			
			settings.onlySaveOptionCheckedChanged(sender, e);
			settings.ManualWithButtonsOptionCheckedChanged(sender,e);
		}
		void Checkdate()
		{
			bool isContainsBadProducts = false;
			DateTime CurrentData = DateTime.Now;
			int currentMonth = CurrentData.Month;
			int currentYear = CurrentData.Year;
			int currentDay = CurrentData.Day;
			string[] datagridDate = new string[2];
			
			for (int i = 0; i < dataGridView1.Rows.Count; i++) {
				datagridDate = dataGridView1[4,i].Value.ToString().Split('.');
				datagridDate[2] = datagridDate[2].Substring(0,4);
				if(int.Parse(datagridDate[0]) - currentDay <= 0 && int.Parse(datagridDate[1]) - currentMonth <= 0 && int.Parse(datagridDate[2])- currentYear <= 0){
					string currentID = dataGridView1[1,i].Value.ToString();
					MessageBox.Show("У товара с ID " + currentID + " истек срок годности","Внимание!",MessageBoxButtons.OK,MessageBoxIcon.Error);
					isContainsBadProducts = true;
				}
				else if(!isContainsBadProducts){
					MessageBox.Show("Все в порядке","Порядок",MessageBoxButtons.OK,MessageBoxIcon.Information);
				}
			}
//			int est = 0;
//			if(dataGridView1.Rows.Count != 1){
//			for (int i = 0; i < dataGridView1.Rows.Count-1;i++)
//            {
//				string check = dataGridView1[4 , i].Value.ToString();
//				int k= check.IndexOf('.');
//                string srokden = check.Substring(0, k);
//                string srokmesyac = (check.Substring(3, k));
//                string srokgod = (check.Substring(6, 4));
//                int aa = Convert.ToInt32(srokden) - den;
//                string deen = dataGridView1[1 , i].Value.ToString();
//
//                if ((Convert.ToInt32(srokmesyac) - mesyac < 1) && aa < 10 && aa > 0)
//				{
//                	MessageBox.Show("Внимание!\n У товара с ID "+deen+" до срока годности "+aa+" дней","Осторожно",MessageBoxButtons.OK,MessageBoxIcon.Error);
//                	est++;
//				}
//			}
//			if (est==0)
//			{
//				MessageBox.Show("Все товары в порядке","Порядок",MessageBoxButtons.OK,MessageBoxIcon.Information);
//			}
//			}
		}

		void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
//			uint itemId = Convert.ToUInt32(dataGridView1[1,dataGridView1.CurrentCell.RowIndex].Value);
//			string itemName = dataGridView1[2,dataGridView1.CurrentCell.RowIndex].Value.ToString();
//			uint itemQuantity = Convert.ToUInt32(dataGridView1[3,dataGridView1.CurrentCell.RowIndex].Value);   МЕТОД БЕЗ SQL
//			string itemDate = dataGridView1[4,dataGridView1.CurrentCell.RowIndex].Value.ToString().Substring(0,10);
			if(dataGridView1.CurrentCell is DataGridViewButtonCell){
				
			}
			else{
			using(SqlConnection conn = new SqlConnection(connectionString)){
				conn.Open();
				SqlCommand cmd = new SqlCommand("SELECT Id,Name,Quantity,Srok,Type FROM test WHERE Id = "+dataGridView1[1,dataGridView1.CurrentCell.RowIndex].Value+"",conn);
				SqlDataReader reader = cmd.ExecuteReader();
				while(reader.Read()){
					ItemProperties.itemId = Convert.ToUInt32(reader.GetValue(0));
					ItemProperties.itemName = reader.GetValue(1).ToString();
					ItemProperties.itemQuantity = Convert.ToUInt32(reader.GetValue(2));
					ItemProperties.itemDate = reader.GetValue(3).ToString();
					ItemProperties.itemType = reader.GetString(4);
				}
				reader.Close();
			}
			if(CardProperties.IdIsExist(ItemProperties.itemId)){
				idIsExist = true;
				ProductCard.isPictureGot = true;
				ProductCard card = new ProductCard(ItemProperties.itemId, ItemProperties.itemName, ItemProperties.itemQuantity, ItemProperties.itemDate,ItemProperties.itemType);
				card.ShowDialog();
			}
			else{				
				idIsExist = false;
				ProductCard.isPictureGot = false;
				ProductCard card = new ProductCard(ItemProperties.itemId, ItemProperties.itemName, ItemProperties.itemQuantity, ItemProperties.itemDate,ItemProperties.itemType);
				card.SetCardProperties();
				card.ShowDialog();
			}
		}
	}

		private DataTable GetEmployeesList()
		{
			DataTable dtEmployees = new DataTable();
			string connString = "Server=localhost\\MSSQLSERVER01;Database=main;Trusted_Connection=True;";

			using (SqlConnection con = new SqlConnection(connString))
			{
				using (SqlCommand cmd = new SqlCommand("SELECT * FROM test", con))
				{
					con.Open();
					SqlDataReader reader = cmd.ExecuteReader();
					dtEmployees.Load(reader);
					con.Close();
				}
			}
			
			return dtEmployees;

	}
		void Button1Click(object sender, EventArgs e)
		{try{string connString = "Server=localhost\\MSSQLSERVER01;Database=main;Trusted_Connection=True;";
		SqlConnection con = new SqlConnection(connString);
				con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into [test] values ('" + textBox1.Text + "', '" + numericUpDown1.Text + "', '" + maskedTextBox1.Text + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Данные успешно добавленны","Успех",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Checksrokgod();
             textBox1.Clear();
             maskedTextBox1.Clear();
             numericUpDown1.Text = "0";
             dataGridView1.DataSource = GetEmployeesList();
			}
                catch(Exception ex)
            {
            	MessageBox.Show(ex.Message,"Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
		}
		
		void Button2Click(object sender, EventArgs e)
		{try{string connString = "Server=localhost\\MSSQLSERVER01;Database=main;Trusted_Connection=True;";
		SqlConnection con = new SqlConnection(connString);
			int selectedIndex = dataGridView1.SelectedRows[0].Index;
            int rowID = int.Parse(dataGridView1[0,selectedIndex].Value.ToString());
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from [test] where [id]='"+rowID+"'";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Данные успешно удалены","Успех",MessageBoxButtons.OK,MessageBoxIcon.Information);
            dataGridView1.DataSource = GetEmployeesList();}
            catch(Exception ex)
            {
            	MessageBox.Show(ex.Message,"Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
		}
		void Button3Click(object sender, EventArgs e)
		{
			dataGridView1.DataSource = ds.Tables[0];
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			if (!status)
			{
				Height = 349;
				status = true;
			}
			else {Height = 290;
				status = false;
			}
		}
		void Button5Click(object sender, EventArgs e)
		{try{
			string connString = "Server=localhost\\MSSQLSERVER01;Database=main;Trusted_Connection=True;";
		SqlConnection con = new SqlConnection(connString);
			int selectedIndex = dataGridView1.SelectedRows[0].Index;
            int rowID = int.Parse(dataGridView1[0,selectedIndex].Value.ToString());
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE [test] SET [Наименование товара]= '"+textBox1.Text+"', [Наличие]= '"+numericUpDown1.Text+"', [Срок списания]= '"+maskedTextBox1.Text+"' where [id]='"+rowID+"'";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Данные успешно изменены","Успех",MessageBoxButtons.OK,MessageBoxIcon.Information);
            dataGridView1.DataSource = GetEmployeesList();
			textBox1.Clear();
            maskedTextBox1.Clear();
            numericUpDown1.Text = "0";}
            catch(Exception ex)
            {
            	MessageBox.Show(ex.Message,"Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
		}
		public void Checksrokgod()
		{
			try{
				
				string srok = maskedTextBox1.Text;
                int k=srok.IndexOf('.');
                string srokden = srok.Substring(0, k);
                string srokmesyac = (srok.Substring(3, k));
                string srokgod = (srok.Substring(6, 4));
            	int srokden1 = Convert.ToInt32(srokden);
            	int srokmesyac1 = Convert.ToInt32(srokmesyac);
            	DateTime date = new DateTime();
			date = DateTime.Now;
			int mesyac = date.Month;
			int god = date.Year;
			int den = date.Day;
			int denkon1 = srokden1 - den;
			int meskon1 = srokmesyac1 - mesyac;
			string denkon = denkon1 + " дней";
			if(denkon1 <= 0)
			{
				denkon1 = 30-den + srokden1;
				meskon1 = (mesyac - srokmesyac1+1)*(-1);
				denkon = denkon1.ToString();
			}
			int godkon = Convert.ToInt32(srokgod);
			godkon = godkon - god;
			string godkon1 = godkon + " год";
			if(godkon > 0)
			{
				denkon1 = 30-den + srokden1;
				godkon *= (-1);
			}
			else
			{
				godkon1 = "";
			}
			string denstring = denkon1 == 1 ? (denkon1 == 2 || denkon1 == 3 ||denkon1== 4)  ? denkon1 > 4  ? " день" : " дня" : " дней" : " дней";
			denkon = denkon1.ToString() + denstring;
			string mestring = meskon1 == 1 ? (meskon1 == 2 || meskon1 == 3 ||meskon1== 4)  ? meskon1 > 4  ? " месяц" : " месяца" : " месяцев" : " месяцев";
			string meskon= meskon1 + mestring;
			if(meskon1 <= 0)
			{
				meskon= "";
			}
			if(denkon1 <= 0)
			{
				denkon= "";
			}
			if(denkon1 != 0 || meskon1 != 0 || godkon != 0)
			{
			MessageBox.Show("До конца срока годности: " +denkon+" "  +meskon+" "  +godkon1+"","Срок годности",MessageBoxButtons.OK,MessageBoxIcon.Information);
			}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message,"Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}
		public void ProductsForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			var result = MessageBox.Show("Вы действительно хотите закрыть окно?","Подтверждение действия",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);
			if (result == DialogResult.No)
			{
				e.Cancel = true;
			}
			else if (result == DialogResult.Yes)
			{
				AuthorizationForm main = new AuthorizationForm();
				main.Close();
				Dispose();
				Application.Exit();
			}
			else if (result == DialogResult.Cancel)
			{
				e.Cancel = true;
			}
			
		}
		void CheckbuttonClick(object sender, EventArgs e)
		{
		Checkdate();
		}
		void MaskedTextBox1MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
		{
	
		}
		void НастройкиToolStripMenuItemClick(object sender, EventArgs e)
		{
			settings.ShowDialog();
		}
		void AddDataButtonClick(object sender, EventArgs e)
		{
			try{
			using(SqlConnection connection = new SqlConnection(connectionString)){
				connection.Open();
				adapter = new SqlDataAdapter(sql,connection);
				commandBuilder = new SqlCommandBuilder(adapter);
				adapter.InsertCommand = new SqlCommand("INSERT INTO test (Name, Quantity, Srok,Type) VALUES (@name, @quantity, @srok, @type) SET @Id=SCOPE_IDENTITY()", connection);
				adapter.InsertCommand.CommandType = CommandType.Text;
				adapter.InsertCommand.Parameters.Add(new SqlParameter("@name", SqlDbType.NChar,20,"Name"));
				adapter.InsertCommand.Parameters.Add(new SqlParameter("@quantity",SqlDbType.Int,0,"Quantity"));
				adapter.InsertCommand.Parameters.Add(new SqlParameter("@srok", SqlDbType.NChar,0,"Srok"));
				SqlParameter param = adapter.InsertCommand.Parameters.AddWithValue("@type",dataGridView1[0, dataGridView1.Rows.Count - 1].Value);
				
//				int index;
//				SqlCommand cmd = new SqlCommand();
//				for (int i = 0; i < dataGridView1.Rows.Count; i++) {
//				index = Convert.ToInt32(dataGridView1[1, i].Value);
//				cmd = new SqlCommand("UPDATE test SET Type = @type WHERE id = "+ index,connection);
//				SqlParameter parameter = new SqlParameter("@type",dataGridView1[0,i].Value);
//				cmd.Parameters.Add(parameter);
//				cmd.ExecuteNonQuery();
//				}

				SqlParameter idParametr = adapter.InsertCommand.Parameters.Add("@Id",SqlDbType.Int,0, "ID");
				idParametr.Direction = ParameterDirection.Output;
				adapter.Update(ds);
				ds.WriteXml("userdb.xml");
				}
			}
				catch(SqlException ex){
				MessageBox.Show(ex.Message,"Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
				}
			}
		void ChangeDataButtonClick(object sender, EventArgs e)
		{
			DataRow row = ds.Tables[0].NewRow();
			ds.Tables[0].Rows.Add(row);
		}
		void DeleteDataButtonClick(object sender, EventArgs e)
		{
			foreach(DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row);
            }   
		}
		public void RefreshButtonClick(object sender, EventArgs e)
		{
			dataGridView1.DataSource = ds.Tables[0];
			dataGridView1.Update();
		}
}
}