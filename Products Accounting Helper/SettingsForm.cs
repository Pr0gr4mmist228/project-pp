
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
		
		bool isDialog;
		
		ChooseForm choose;
		
		public static bool isOptionChanged;
		
		public SettingsForm(ChooseForm choose = null,bool isDialog = false)
		{
			InitializeComponent();
			
			onlySaveOption.MouseHover += onlySaveOption_MouseHover;
			manualWithButtonsOption.MouseHover += manualWithButtonsOption_MouseHover;
			autoSaveOption.MouseHover += autoSaveOption_MouseHover;
			
			this.isDialog = isDialog;
			
			this.choose = choose;
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
							isOptionChanged = true;
			ProductsForm.optionId = 1;
				new ProductsForm().ReLoadSettings();
		}
		}

		public void AutoSaveOptionCheckedChanged(object sender, EventArgs e)
		{
			ProductsForm.optionId = 2;
						isOptionChanged = true;
			new ProductsForm().ReLoadSettings();
		}
		public void ManualWithButtonsOptionCheckedChanged(object sender, EventArgs e)
		{
			if(manualWithButtonsOption.Checked){
						isOptionChanged = true;
				ProductsForm.optionId = 3;
				new ProductsForm().ReLoadSettings();
			}
		}
		void SettingsFormLoad(object sender, EventArgs e)
		{
	
		}
		void GoToHomeButtonClick(object sender, EventArgs e)
		{
			Visible = false;
			choose.Visible = true;
		}
		void SettingsFormClosing(object sender, FormClosingEventArgs e)
		{
			if (!isDialog) {
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
}