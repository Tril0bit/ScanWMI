/*
 * Сделано в SharpDevelop.
 * Пользователь: r.iskhakov
 * Дата: 11.01.2017
 * Время: 11:44
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
	/// Description of wifi.
	/// </summary>
	public partial class wifi : Form
	{
		public wifi()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		//Включение
		void Button1_Click(object sender, EventArgs e)
		{
			Process psi = new Process();
			psi.StartInfo.Verb = "runas";
			psi.StartInfo.FileName = "cmd";
			psi.StartInfo.Arguments = @"/k netsh wlan set hostednetwork mode=allow ssid=" + textBox1.Text + " key=" + textBox2.Text + " keyUsage=persistent";
			psi.StartInfo.Arguments = @"/k netsh wlan start hostednetwork";
			psi.Start();
		}
		
		//Отключение
		void Button2_Click(object sender, EventArgs e)
		{
			Process psi = new Process();
			psi.StartInfo.Verb = "runas";
			psi.StartInfo.FileName = "cmd";
			psi.StartInfo.Arguments = @"/k netsh wlan stop hostednetwork";
			psi.Start();
		}
	}
}
