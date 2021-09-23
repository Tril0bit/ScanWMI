/*
 * Сделано в SharpDevelop.
 * Пользователь: r.iskhakov
 * Дата: 17.01.2017
 * Время: 10:09
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
	/// Description of WMI.
	/// </summary>
	public partial class WMI : Form
	{
		public WMI()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button5_Click(object sender, EventArgs e)
		{
			Close();
		}
		
		//Добавление исключения в брандмауэр Windows XP
		void Button1_Click(object sender, EventArgs e)
		{
			Process psi = new Process();
			psi.StartInfo.Verb = "runas";
			psi.StartInfo.FileName = "cmd";
			psi.StartInfo.Arguments = @"/k netsh firewall set service RemoteAdmin enable";
			psi.Start();
		}
		//Отключение
		void Button2_Click(object sender, EventArgs e)
		{
			Process psi = new Process();
			psi.StartInfo.Verb = "runas";
			psi.StartInfo.FileName = "cmd";
			psi.StartInfo.Arguments = @"/k netsh firewall set service RemoteAdmin disable";
			psi.Start();
		}
		//Добавление исключения в брандмауэр Windows Vista и старше
		void Button4_Click(object sender, EventArgs e)
		{
			string wmi = "\"Инструментарий управления windows (wmi)\"";
			Process psi = new Process();
			psi.StartInfo.Verb = "runas";
			psi.StartInfo.FileName = "cmd";
			psi.StartInfo.Arguments = @"/k netsh advfirewall firewall set rule group=" + wmi +" new enable=yes";
			psi.Start();
		}
		//Отключение
		void Button3_Click(object sender, EventArgs e)
		{
			string wmi = "\"Инструментарий управления windows (wmi)\"";
			Process psi = new Process();
			psi.StartInfo.Verb = "runas";
			psi.StartInfo.FileName = "cmd";
			psi.StartInfo.Arguments = @"/k netsh advfirewall firewall set rule group=" + wmi +" new enable=no";
			psi.Start();
		}
	}
}
