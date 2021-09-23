/*
 * Сделано в SharpDevelop.
 * Пользователь: User
 * Дата: 26.12.2016
 * Время: 21:11
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
namespace Utilita
{
	partial class Form2
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label10 = new System.Windows.Forms.Label();
			this.button7 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.trackBar1 = new System.Windows.Forms.TrackBar();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
			this.SuspendLayout();
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(15, 19);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(118, 23);
			this.label10.TabIndex = 40;
			this.label10.Text = "Автовыключение, ч";
			// 
			// button7
			// 
			this.button7.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button7.Location = new System.Drawing.Point(182, 140);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(109, 23);
			this.button7.TabIndex = 39;
			this.button7.Text = "Отмена таймера";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.Button7Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(15, 140);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(116, 23);
			this.button4.TabIndex = 27;
			this.button4.Text = "Запустить таймер";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// trackBar1
			// 
			this.trackBar1.Location = new System.Drawing.Point(9, 45);
			this.trackBar1.Maximum = 24;
			this.trackBar1.Minimum = 1;
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Size = new System.Drawing.Size(450, 45);
			this.trackBar1.TabIndex = 28;
			this.trackBar1.Value = 12;
			this.trackBar1.ValueChanged += new System.EventHandler(this.TrackBar1_ValueChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(34, 79);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(13, 23);
			this.label1.TabIndex = 41;
			this.label1.Text = "1";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(72, 79);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(13, 23);
			this.label2.TabIndex = 42;
			this.label2.Text = "2";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(108, 79);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(13, 23);
			this.label3.TabIndex = 43;
			this.label3.Text = "3";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(145, 79);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(13, 23);
			this.label4.TabIndex = 44;
			this.label4.Text = "4";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(182, 79);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(13, 23);
			this.label5.TabIndex = 45;
			this.label5.Text = "5";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(218, 79);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(13, 23);
			this.label6.TabIndex = 46;
			this.label6.Text = "6";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(255, 79);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(13, 23);
			this.label7.TabIndex = 47;
			this.label7.Text = "7";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(292, 79);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(13, 23);
			this.label8.TabIndex = 48;
			this.label8.Text = "8";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(328, 79);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(13, 23);
			this.label9.TabIndex = 49;
			this.label9.Text = "9";
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(364, 79);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(20, 23);
			this.label11.TabIndex = 50;
			this.label11.Text = "10";
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(403, 79);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(20, 23);
			this.label12.TabIndex = 51;
			this.label12.Text = "11";
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(436, 79);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(23, 23);
			this.label13.TabIndex = 52;
			this.label13.Text = "12";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(222, 105);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(119, 20);
			this.textBox1.TabIndex = 53;
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(116, 105);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(100, 23);
			this.label14.TabIndex = 54;
			this.label14.Text = "Ручной ввод, сек";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(345, 140);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(111, 23);
			this.button1.TabIndex = 55;
			this.button1.Text = "Выйти";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1_Click);
			// 
			// Form2
			// 
			this.AcceptButton = this.button4;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.button7;
			this.ClientSize = new System.Drawing.Size(468, 185);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.trackBar1);
			this.Controls.Add(this.button4);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "Form2";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Автовыключение";
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.TrackBar trackBar1;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Label label10;
	}
}
