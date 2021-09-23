/*
 * Сделано в SharpDevelop.
 * Пользователь: r.iskhakov
 * Дата: 12.01.2017
 * Время: 9:36
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.ComponentModel;
using System.Diagnostics;
//using System.Linq;
using System.Security.Principal;
using System.Windows.Forms;

namespace Utilita
{
	/// <summary>
	/// Description of Shutdown.
	/// </summary>
	public partial class Shutdown : Form
	{
		public Shutdown()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		string check = string.Empty;
		
		void TrackBar1_ValueChanged(object sender, EventArgs e)
		{
			switch (trackBar1.Value)
			{
				case 1:
					{textBox1.Text = "1800"; break;}
				case 2:
					{textBox1.Text = "3600"; break;}
				case 3:
					{textBox1.Text = "5400"; break;}
				case 4:
					{textBox1.Text = "7200"; break;}
				case 5:
					{textBox1.Text = "9000"; break;}
				case 6:
					{textBox1.Text = "10800"; break;}
				case 7:
					{textBox1.Text = "12600"; break;}
				case 8:
					{textBox1.Text = "14400"; break;}
				case 9:
					{textBox1.Text = "16200"; break;}
				case 10:
					{textBox1.Text = "18000"; break;}
				case 11:
					{textBox1.Text = "19800"; break;}
				case 12:
					{textBox1.Text = "21600"; break;}
				case 13:
					{textBox1.Text = "23400"; break;}
				case 14:
					{textBox1.Text = "25200"; break;}
				case 15:
					{textBox1.Text = "27000"; break;}
				case 16:
					{textBox1.Text = "28800"; break;}
				case 17:
					{textBox1.Text = "30600"; break;}
				case 18:
					{textBox1.Text = "32400"; break;}
				case 19:
					{textBox1.Text = "34200"; break;}
				case 20:
					{textBox1.Text = "36000"; break;}
				case 21:
					{textBox1.Text = "37800"; break;}
				case 22:
					{textBox1.Text = "39600"; break;}
				case 23:
					{textBox1.Text = "41400"; break;}
				case 24:
					{textBox1.Text = "43200"; break;}
			}
		}
		
		//запуск
		void Button4_Click(object sender, EventArgs e)
		{
			if (radioButton1.Checked == true)
			{
				check = "/s"; //параметр завершения работы
			}
			else
			{
				check = "/r"; //параметр перезагрузки
			}
			
			Process psi = new Process();
			psi.StartInfo.Verb = "runas";
			psi.StartInfo.FileName = "cmd";
			psi.StartInfo.Arguments = @"/c shutdown " + check + " /f /t " + textBox1.Text + " /m " + textBox3.Text + textBox2.Text;
			psi.Start();
		}
		
		//отмена shutdown
		void Button7_Click(object sender, EventArgs e)
		{
			Process psi = new Process();
			psi.StartInfo.Verb = "runas";
			psi.StartInfo.FileName = "cmd";
			psi.StartInfo.Arguments = @"/c shutdown /a /m " + textBox3.Text + textBox2.Text;
			psi.Start();
		}
		
		void Button1_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
