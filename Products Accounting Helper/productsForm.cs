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
		SettingsForm settings = new SettingsForm(null,true);
		DataSet ds;
		SqlDataAdapter adapter;
		SqlCommandBuilder commandBuilder;
		
		public static int optionId;
		public static string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
		
		ChooseForm choose;
		
		public ProductsForm()
		{
			InitializeComponent();
			
			LoadForm();
		}
		
		public ProductsForm(ChooseForm choose){
			InitializeComponent();
			
			this.choose = choose;
			
			LoadForm();
		}

		void LoadForm(){
			FindItems.addDataButton = this.addDataButton;
			
			settings.addDataButton = this.addDataButton;
			settings.deleteDataButton = this.deleteDataButton;
			settings.changeDataButton = this.changeDataButton;
			settings.refreshButton = this.refreshButton;
			
			dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;

			dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			using (SqlConnection connection = new SqlConnection(connectionString)) {
				connection.Open();
				adapter = new SqlDataAdapter("SELECT * FROM test", connection);
				ds = new DataSet();
				adapter.Fill(ds);
				
				dataGridView1.DataSource = ds.Tables[0];
				dataGridView1.Columns["Id"].ReadOnly = true;
				dataGridView1.Columns[0].DisplayIndex = 5;
				dataGridView1.Columns[2].HeaderText = "Имя товара";
				dataGridView1.Columns[3].HeaderText = "Количество";
				dataGridView1.Columns[4].HeaderText = "Срок годности";
				dataGridView1.Columns[5].HeaderText = "Тип продукта";
				dataGridView1.Columns[5].ReadOnly = true;
			}
		}
		
		public void ReLoadSettings(){
						if (optionId == 2) {
				}
				if (optionId == 3) {
					addDataButton.Text = "Добавить данные";
					refreshButton.Text = "Обновить данные";
				} else if (optionId == 1) {
					addDataButton.Text = "Сохранить изменения";
					changeDataButton.Text = "Добавить данные";
					refreshButton.Text = "Отменить изменения";
				}
			}
		
		void ProductsFormLoad(object sender, EventArgs e)
		{
			Height = 290;
			
			settings.onlySaveOptionCheckedChanged(sender, e);
			settings.ManualWithButtonsOptionCheckedChanged(sender, e);
		}
		
		void CheckDate()
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
				if(((int.Parse(datagridDate[0]) - currentDay <= 0 && int.Parse(datagridDate[1]) - currentMonth <= 0) && int.Parse(datagridDate[2]) - currentYear <= 0) || int.Parse(datagridDate[2]) - currentYear < 0){
					string currentID = dataGridView1[1,i].Value.ToString();
					MessageBox.Show("У товара с ID " + currentID + " истек срок годности","Внимание!",MessageBoxButtons.OK,MessageBoxIcon.Error);
					isContainsBadProducts = true;
				}
				}
				if(!isContainsBadProducts){
				MessageBox.Show("Все в порядке","Порядок",MessageBoxButtons.OK,MessageBoxIcon.Information);
			}
		}
		
		public static bool idIsExist = false;
		
		void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
//			uint itemId = Convert.ToUInt32(dataGridView1[1,dataGridView1.CurrentCell.RowIndex].Value);
//			string itemName = dataGridView1[2,dataGridView1.CurrentCell.RowIndex].Value.ToString();
//			uint itemQuantity = Convert.ToUInt32(dataGridView1[3,dataGridView1.CurrentCell.RowIndex].Value);   МЕТОД БЕЗ SQL
//			string itemDate = dataGridView1[4,dataGridView1.CurrentCell.RowIndex].Value.ToString().Substring(0,10);
			if (dataGridView1.CurrentCell is DataGridViewComboBoxCell) {
				return;
			} else {
				using (SqlConnection conn = new SqlConnection(connectionString)) {
					conn.Open();
					try {
						SqlCommand cmd = new SqlCommand("SELECT Id,Name,Quantity,Srok,Type FROM test WHERE Id = " + dataGridView1[1, dataGridView1.CurrentCell.RowIndex].Value + "", conn);
						SqlDataReader reader = cmd.ExecuteReader();
						while (reader.Read()) {
							ItemProperties.itemId = Convert.ToUInt32(reader.GetValue(0));
							ItemProperties.itemName = reader.GetValue(1).ToString();
							ItemProperties.itemQuantity = Convert.ToUInt32(reader.GetValue(2));
							ItemProperties.itemDate = reader.GetValue(3).ToString();
							ItemProperties.itemType = reader.GetString(4);
						}
						reader.Close();
					}
                    catch (Exception)
                    {
						return;
                    }
					}
				idIsExist = CardProperties.IdIsExist(ItemProperties.itemId);
				ProductCard card = new ProductCard(ItemProperties.itemId, ItemProperties.itemName, ItemProperties.itemQuantity, ItemProperties.itemDate, ItemProperties.itemType);
				card.ShowDialog();
			}
		}
		
//		void Button1Click(object sender, EventArgs e)
//		{
//			try {
//				string connString = "Server=localhost\\MSSQLSERVER01;Database=main;Trusted_Connection=True;";
//				SqlConnection con = new SqlConnection(connString);
//				con.Open();
//				SqlCommand cmd = con.CreateCommand();
//				cmd.CommandType = CommandType.Text;
//				cmd.CommandText = "insert into [test] values ('" + textBox1.Text + "', '" + numericUpDown1.Text + "', '" + maskedTextBox1.Text + "')";
//				cmd.ExecuteNonQuery();
//				con.Close();
//				MessageBox.Show("Данные успешно добавленны", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
//				Checksrokgod();
//				textBox1.Clear();
//				maskedTextBox1.Clear();
//				numericUpDown1.Text = "0";
//				dataGridView1.DataSource = GetEmployeesList();
//			} catch (Exception ex) {
//				MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
//			}
//		}
		
//		void Button2Click(object sender, EventArgs e)
//		{
//			try {
//				string connString = "Server=localhost\\MSSQLSERVER01;Database=main;Trusted_Connection=True;";
//				SqlConnection con = new SqlConnection(connString);
//				int selectedIndex = dataGridView1.SelectedRows[0].Index;
//				int rowID = int.Parse(dataGridView1[0, selectedIndex].Value.ToString());
//				con.Open();
//				SqlCommand cmd = con.CreateCommand();
//				cmd.CommandType = CommandType.Text;
//				cmd.CommandText = "delete from [test] where [id]='" + rowID + "'";
//				cmd.ExecuteNonQuery();
//				con.Close();
//				MessageBox.Show("Данные успешно удалены", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
//				dataGridView1.DataSource = GetEmployeesList();
//			} catch (Exception ex) {
//				MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
//			}
//		}
		void Button3Click(object sender, EventArgs e)
		{
			dataGridView1.DataSource = ds.Tables[0];
		}
		
		bool status = false;
		
		void Button4Click(object sender, EventArgs e)
		{
			if (!status) {
				Height = 349;
				status = true;
			} else {
				Height = 290;
				status = false;
			}
		}	
		
		void CheckbuttonClick(object sender, EventArgs e)
		{
			CheckDate();
		}
		void НастройкиToolStripMenuItemClick(object sender, EventArgs e)
		{
			settings.ShowDialog();
		}
		void AddDataButtonClick(object sender, EventArgs e)
		{
			try {
				using (SqlConnection connection = new SqlConnection(connectionString)) {
					connection.Open();
					adapter = new SqlDataAdapter("SELECT * FROM test", connection);
					commandBuilder = new SqlCommandBuilder(adapter);
					adapter.InsertCommand = new SqlCommand("INSERT INTO test (Name, Quantity, Srok,Type) VALUES (@name, @quantity, @srok, @type) SET @Id=SCOPE_IDENTITY()", connection);
					adapter.InsertCommand.CommandType = CommandType.Text;
					adapter.InsertCommand.Parameters.Add(new SqlParameter("@name", SqlDbType.NChar, 20, "Name"));
					adapter.InsertCommand.Parameters.Add(new SqlParameter("@quantity", SqlDbType.Int, 0, "Quantity"));
					adapter.InsertCommand.Parameters.Add(new SqlParameter("@srok", SqlDbType.NChar, 0, "Srok"));
					SqlParameter param = adapter.InsertCommand.Parameters.AddWithValue("@type", dataGridView1[0, dataGridView1.Rows.Count - 1].Value);
				
//				int index;
//				SqlCommand cmd = new SqlCommand();
//				for (int i = 0; i < dataGridView1.Rows.Count; i++) {
//				index = Convert.ToInt32(dataGridView1[1, i].Value);
//				cmd = new SqlCommand("UPDATE test SET Type = @type WHERE id = "+ index,connection);
//				SqlParameter parameter = new SqlParameter("@type",dataGridView1[0,i].Value);
//				cmd.Parameters.Add(parameter);
//				cmd.ExecuteNonQuery();
//				}

					SqlParameter idParametr = adapter.InsertCommand.Parameters.Add("@Id", SqlDbType.Int, 0, "ID");
					idParametr.Direction = ParameterDirection.Output;
					adapter.Update(ds);
					ds.WriteXml("userdb.xml");
				}
			} catch (SqlException ex) {
				MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		void ChangeDataButtonClick(object sender, EventArgs e)
		{
			DataRow row = ds.Tables[0].NewRow();
			ds.Tables[0].Rows.Add(row);
		}

		void DeleteDataButtonClick(object sender, EventArgs e)
		{
			foreach (DataGridViewRow row in dataGridView1.SelectedRows) {
				dataGridView1.Rows.Remove(row);
			}   
		}
		public void RefreshButtonClick(object sender, EventArgs e)
		{
			SqlDataAdapter adap = new SqlDataAdapter("SELECT * FROM test", connectionString);
			ds = new DataSet();
			adap.Fill(ds);
			dataGridView1.DataSource = ds.Tables[0];
		}
		void FindItemButtonClick(object sender, EventArgs e)
		{
			addDataButton.Enabled = false;
			new FindItems().Show();
		}
		
		bool isShowingBadProducts = false;
		
		void ShowOnlyBadItemsButtonClick(object sender, EventArgs e)
		{
			if (isShowingBadProducts) {
				RefreshButtonClick(sender, e);
				this.isShowingBadProducts = false;
				showOnlyBadProducts.Text = "Показать только просроченные продукты";
				addDataButton.Enabled = true;
			} else if (!isShowingBadProducts) {
				this.addDataButton.Enabled = false;
				isShowingBadProducts = true;
				showOnlyBadProducts.Text = "Показать все продукты";
				DateTime CurrentData = DateTime.Now;
				int currentMonth = CurrentData.Month;
				int currentYear = CurrentData.Year;
				int currentDay = CurrentData.Day;
				string[] datagridDate = new string[2];
				int rowsCount = dataGridView1.Rows.Count;
				for (int i = 0; i < dataGridView1.Rows.Count; i++) {
					datagridDate = dataGridView1[4, i].Value.ToString().Split('.');
					datagridDate[2] = datagridDate[2].Substring(0, 4);
				
					if (!(((int.Parse(datagridDate[0]) - currentDay <= 0 && int.Parse(datagridDate[1]) - currentMonth <= 0) && int.Parse(datagridDate[2]) - currentYear <= 0) || int.Parse(datagridDate[2]) - currentYear < 0)) {
						DataGridViewRow row = dataGridView1.Rows[i];
						dataGridView1.Rows.Remove(row);
					}
				}
			}
		}
		void GoToHomeButtonClick(object sender, EventArgs e)
		{
			Visible = false;
			choose.Visible = true;
		}
		void ProductsFormClosing(object sender, FormClosingEventArgs e)
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
		void Button2Click(object sender, EventArgs e)
		{
			DateTime CurrentData = DateTime.Now;
			int currentMonth = CurrentData.Month;
			int currentYear = CurrentData.Year;
			int currentDay = CurrentData.Day;
			string[] datagridDate = new string[2];
			int currentRow = dataGridView1.CurrentRow.Index;
			datagridDate = dataGridView1[4, currentRow].Value.ToString().Split('.');
			datagridDate[2] = datagridDate[2].Substring(0, 4);
				
			int day = int.Parse(datagridDate[0]) - currentDay;
			int mouth = int.Parse(datagridDate[1]) - currentMonth;
			int year = int.Parse(datagridDate[2]) - currentYear;
				
				if(year > 0){
				if (day < 0 && mouth < 0)
				{
					MessageBox.Show("До конца срока годности " + day * -1 + " дней " + mouth*-1 + " месяцев " + year + " лет");
				}
				else if (mouth < 0)
				{
					MessageBox.Show("До конца срока годности " + day + " дней " + mouth*-1 + " месяцев " + year + " лет");
				}
				else if(day < 0)
                {
					MessageBox.Show("До конца срока годности " + day*-1 + " дней " + mouth + " месяцев " + year + " лет");
				}
				}
				else if (day >= 0 && mouth >= 0)
				{
					
				}
				else MessageBox.Show("Продукт просрочен");
		}

        void резервнаяКопияToolStripMenuItem_Click(object sender, EventArgs e)
        {
			var DialogResult = MessageBox.Show("Хотите ли вы восстановить резервную копию?","Подтвердите действие",MessageBoxButtons.YesNo);
			if(DialogResult == DialogResult.Yes)
            {
				ds.ReadXml("userdb.xml");
				MessageBox.Show("Успешно");
            }
        }
    }
}