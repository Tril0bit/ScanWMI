/*
 * Сделано в SharpDevelop.
 * Пользователь: r.iskhakov
 * Дата: 11.01.2017
 * Время: 10:48
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
	/// Description of ping.
	/// </summary>
	public partial class ping : Form
	{
		public ping()
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
			Loading form = new Loading();
            form.Show();
			this.Visible = false;
			(Application.OpenForms["RDform"].Controls["richTextbox1"] as RichTextBox).Text = "Результат выполнения команды: \n";
			Process proc = new Process()
			{
                	StartInfo = new ProcessStartInfo("cmd.exe", "/c ping " + textBox1.Text) 
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
                textBox1.Invoke(new MethodInvoker(() => {
                (Application.OpenForms["RDform"].Controls["richTextbox1"] as RichTextBox).Text += line + "\n";
                }), null);
            	if ((Application.OpenForms["Loading"].Controls["progressBar1"] as ProgressBar).Value==9)
                	(Application.OpenForms["Loading"].Controls["progressBar1"] as ProgressBar).Value = 9;
                else
                (Application.OpenForms["Loading"].Controls["progressBar1"] as ProgressBar).Value++;
            }
            Application.OpenForms["Loading"].Close();
            Close();
		}
	}
}
