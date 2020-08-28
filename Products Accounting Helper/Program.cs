using System;
using System.Windows.Forms;

namespace auth
{
	internal sealed class Program
	{
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new AuthorizationForm());
		}
	}
}
