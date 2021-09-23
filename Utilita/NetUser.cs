/*
 * Сделано в SharpDevelop.
 * Пользователь: r.iskhakov
 * Дата: 12.01.2017
 * Время: 14:38
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.IO;
using System.Text;

namespace Utilita
{
	/// <summary>
	/// Description of NetUser.
	/// </summary>
	public partial class NetUser : Form
	{
		public NetUser()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button2_Click(object sender, EventArgs e)
		{
			Close();
		}
		
		void Button1_Click(object sender, EventArgs e)
		{
			(Application.OpenForms["RDform"].Controls["richTextbox1"] as RichTextBox).Text = "Результат выполнения команды: \n";
			Process proc = new Process()
			{
				StartInfo = new ProcessStartInfo("cmd.exe", "/c net user " + textBox1.Text + " /domain")
				{
					StandardOutputEncoding = Encoding.GetEncoding(866),
					RedirectStandardOutput = true,
					UseShellExecute = false,
					CreateNoWindow = true,
					WindowStyle = ProcessWindowStyle.Hidden
				}
			};
			
			proc.Start();
			
			if (!proc.StartInfo.RedirectStandardOutput)
				return;
			
			string line;
			StreamReader sr = proc.StandardOutput;
			while (!sr.EndOfStream) {
				line = sr.ReadLine();
				textBox1.Invoke(new MethodInvoker(() => 
				{
				(Application.OpenForms["RDform"].Controls["richTextbox1"] as RichTextBox).Text += line + "\n";
				}), null);
			}
			Close();
		}
	}
}
