
using System;
using System.Drawing;
using System.Windows.Forms;

namespace auth
{
	public partial class SettingsForm : Form
	{
		public Button addDataButton;
		public Button deleteDataButton;
		public Button changeDataButton;
		public Button refreshButton;
		
		public SettingsForm()
		{
			InitializeComponent();
			
			onlySaveOption.MouseHover += onlySaveOption_MouseHover;
			manualWithButtonsOption.MouseHover += manualWithButtonsOption_MouseHover;
			autoSaveOption.MouseHover += autoSaveOption_MouseHover;
		}
		
		void onlySaveOption_MouseHover(object sender, EventArgs e)
		{
			RadioButtonTip.Show("При работе в таблице с данной функцией данные будут вводиться напрямую и сохраняться Вами",onlySaveOption,5000);
		}

		void manualWithButtonsOption_MouseHover(object sender, EventArgs e)
		{
			RadioButtonTip.Show("При работе в таблице с данной функцией данные будут вводиться через специальные поля и сохраняться Вами",onlySaveOption,5000);
		}

		void autoSaveOption_MouseHover(object sender, EventArgs e)
		{
			RadioButtonTip.Show("При работе в таблице с данной функцией данные будут вводиться напрямую и сохраняться автоматически",onlySaveOption,5000);
		}
		
		public void onlySaveOptionCheckedChanged(object sender, EventArgs e)
		{
			if(onlySaveOption.Checked){
			ProductsForm.optionId = 1;
			addDataButton.Text = "Сохранить изменения";
			changeDataButton.Text = "Добавить данные";
			refreshButton.Text = "Отменить изменения";
		}
		}

		public void AutoSaveOptionCheckedChanged(object sender, EventArgs e)
		{
			ProductsForm.optionId = 2;
		}
		public void ManualWithButtonsOptionCheckedChanged(object sender, EventArgs e)
		{
			if(manualWithButtonsOption.Checked){
			ProductsForm.optionId = 3;
			addDataButton.Text = "Добавить данные";
			refreshButton.Text = "Обновить данные";
			}
		}
		void SettingsFormLoad(object sender, EventArgs e)
		{
	
		}
	}
}