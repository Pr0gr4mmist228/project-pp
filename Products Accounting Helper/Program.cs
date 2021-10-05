using System;
using System.IO;
using System.Windows.Forms;

namespace auth
{
	internal sealed class Program
	{
		[STAThread]
		private static void Main(string[] args)
		{
			File.Copy($@"{Directory.GetCurrentDirectory()}\pah.mdf", $@"C:\Users\{Environment.UserName}\pah.mdf");
			File.Copy($@"{Directory.GetCurrentDirectory()}\pah_log.ldf", $@"C:\Users\{Environment.UserName}\pah_log.ldf");
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new AuthorizationForm());
		}
	}
}
