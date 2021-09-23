/*
 * Сделано в SharpDevelop.
 * Пользователь: r.iskhakov
 * Дата: 18.01.2017
 * Время: 14:42
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Utilita
{
	/// <summary>
	/// Description of Inv.
	/// </summary>
	public partial class Inv : Form
	{
		public Inv()
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
			Application.OpenForms["RDform"].Visible = true;
			Close();
		}
		
		void Button1_Click(object sender, EventArgs e)
		{
			RDform.GlobalVars.inv = true;
			
			if (checkBox1.Checked == true)
			{
				RDform.GlobalVars.hard = true;
			}
			if (checkBox2.Checked == true)
			{
				RDform.GlobalVars.soft = true;
			}
			if (checkBox3.Checked == true)
			{
				RDform.GlobalVars.uch = true;
			}
			if (checkBox4.Checked == true)
			{
				RDform.GlobalVars.net = true;
			}
			if (checkBox5.Checked == true)
			{
				RDform.GlobalVars.proizv = true;
			}
			if (checkBox6.Checked == true)
			{
				RDform.GlobalVars.tem = true;
			}
			if (checkBox7.Checked == true)
			{
				RDform.GlobalVars.ev = true;
			}
			if (checkBox8.Checked == true)
			{
				RDform.GlobalVars.process = true;
			}
			if (checkBox9.Checked == true)
			{
				RDform.GlobalVars.service = true;
			}
			if (checkBox10.Checked == true)
			{
				RDform.GlobalVars.product = true;
			}				
			Application.OpenForms["RDform"].Visible = true;			
			Close();
		}
	}
}
