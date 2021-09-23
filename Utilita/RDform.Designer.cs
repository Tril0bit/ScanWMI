/*
 * Сделано в SharpDevelop.
 * Пользователь: r.iskhakov
 * Дата: 13.01.2017
 * Время: 14:16
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
namespace Utilita
{
	partial class RDform
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
			this.components = new System.ComponentModel.Container();
			this.button3 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.button4 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.button10 = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.button7 = new System.Windows.Forms.Button();
			this.вставитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.вырезатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.button6 = new System.Windows.Forms.Button();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.button9 = new System.Windows.Forms.Button();
			this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.сохранитьОтчетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.сохранитьВсеВОтчетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.командыCmdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.shutdownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.shutdownдляУдаленкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.assocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.netstatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tracertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pathpingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.netUserdomainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.netViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.wifiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.настройкаWMIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.дополнительноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.оценкаПроизводительностиWindowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.button1 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button11 = new System.Windows.Forms.Button();
			this.button12 = new System.Windows.Forms.Button();
			this.button13 = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.button15 = new System.Windows.Forms.Button();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.button14 = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// button3
			// 
			this.button3.Enabled = false;
			this.button3.Location = new System.Drawing.Point(12, 332);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(0, 0);
			this.button3.TabIndex = 10;
			this.button3.Text = "Производительность";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3_Click);
			// 
			// textBox1
			// 
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox1.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox1.Location = new System.Drawing.Point(12, 30);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(156, 19);
			this.textBox1.TabIndex = 2;
			this.textBox1.Text = ".";
			this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(69, 76);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 20);
			this.textBox2.TabIndex = 2;
			this.textBox2.Visible = false;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(12, 56);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(156, 23);
			this.button4.TabIndex = 3;
			this.button4.Text = "Подключиться";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4_Click);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(69, 79);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(55, 21);
			this.label4.TabIndex = 39;
			this.label4.Text = "Домен:";
			this.label4.Visible = false;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(69, 73);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(55, 23);
			this.label3.TabIndex = 38;
			this.label3.Text = "Пароль:";
			this.label3.Visible = false;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(68, 77);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 22);
			this.label2.TabIndex = 37;
			this.label2.Text = "Учетка:";
			this.label2.Visible = false;
			// 
			// button10
			// 
			this.button10.Enabled = false;
			this.button10.Location = new System.Drawing.Point(11, 384);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(157, 23);
			this.button10.TabIndex = 12;
			this.button10.Text = "Журнал ошибок";
			this.button10.UseVisualStyleBackColor = true;
			this.button10.Click += new System.EventHandler(this.Button10_Click);
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.button4);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.textBox1);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.textBox2);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.textBox3);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.textBox4);
			this.panel1.Location = new System.Drawing.Point(-1, 27);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(186, 98);
			this.panel1.TabIndex = 1;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(68, 74);
			this.textBox3.Name = "textBox3";
			this.textBox3.PasswordChar = '*';
			this.textBox3.Size = new System.Drawing.Size(100, 20);
			this.textBox3.TabIndex = 3;
			this.textBox3.Visible = false;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(166, 20);
			this.label1.TabIndex = 36;
			this.label1.Text = "IP Адрес или имя компьютера:";
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(68, 74);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(100, 20);
			this.textBox4.TabIndex = 4;
			this.textBox4.Visible = false;
			// 
			// button7
			// 
			this.button7.Enabled = false;
			this.button7.Location = new System.Drawing.Point(11, 354);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(157, 23);
			this.button7.TabIndex = 11;
			this.button7.Text = "Принтеры";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.Button7Click);
			// 
			// вставитьToolStripMenuItem
			// 
			this.вставитьToolStripMenuItem.Name = "вставитьToolStripMenuItem";
			this.вставитьToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
			this.вставитьToolStripMenuItem.Text = "Вставить";
			this.вставитьToolStripMenuItem.Click += new System.EventHandler(this.ВставитьToolStripMenuItem_Click);
			// 
			// вырезатьToolStripMenuItem
			// 
			this.вырезатьToolStripMenuItem.Name = "вырезатьToolStripMenuItem";
			this.вырезатьToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
			this.вырезатьToolStripMenuItem.Text = "Вырезать";
			this.вырезатьToolStripMenuItem.Click += new System.EventHandler(this.ВырезатьToolStripMenuItem_Click);
			// 
			// удалитьToolStripMenuItem
			// 
			this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
			this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
			this.удалитьToolStripMenuItem.Text = "Удалить";
			this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.УдалитьToolStripMenuItem_Click);
			// 
			// копироватьToolStripMenuItem
			// 
			this.копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
			this.копироватьToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
			this.копироватьToolStripMenuItem.Text = "Копировать";
			this.копироватьToolStripMenuItem.Click += new System.EventHandler(this.КопироватьToolStripMenuItem_Click);
			// 
			// button6
			// 
			this.button6.Enabled = false;
			this.button6.Location = new System.Drawing.Point(11, 267);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(157, 23);
			this.button6.TabIndex = 7;
			this.button6.Text = "Сведения о системе";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.Button6_Click);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.копироватьToolStripMenuItem,
									this.вырезатьToolStripMenuItem,
									this.вставитьToolStripMenuItem,
									this.удалитьToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(140, 92);
			// 
			// richTextBox1
			// 
			this.richTextBox1.ContextMenuStrip = this.contextMenuStrip1;
			this.richTextBox1.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.richTextBox1.Location = new System.Drawing.Point(184, 27);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(493, 508);
			this.richTextBox1.TabIndex = 19;
			this.richTextBox1.Text = "";
			// 
			// button9
			// 
			this.button9.Enabled = false;
			this.button9.Location = new System.Drawing.Point(11, 238);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(157, 23);
			this.button9.TabIndex = 6;
			this.button9.Text = "Комплектующие";
			this.button9.UseVisualStyleBackColor = true;
			this.button9.Click += new System.EventHandler(this.Button9Click);
			// 
			// выходToolStripMenuItem
			// 
			this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
			this.выходToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
			this.выходToolStripMenuItem.Text = "Выход";
			this.выходToolStripMenuItem.Click += new System.EventHandler(this.ВыходToolStripMenuItem_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripMenuItem1,
									this.командыCmdToolStripMenuItem,
									this.дополнительноToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(681, 24);
			this.menuStrip1.TabIndex = 50;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.сохранитьОтчетToolStripMenuItem,
									this.сохранитьВсеВОтчетToolStripMenuItem,
									this.выходToolStripMenuItem});
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(48, 20);
			this.toolStripMenuItem1.Text = "Файл";
			// 
			// сохранитьОтчетToolStripMenuItem
			// 
			this.сохранитьОтчетToolStripMenuItem.Name = "сохранитьОтчетToolStripMenuItem";
			this.сохранитьОтчетToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
			this.сохранитьОтчетToolStripMenuItem.Text = "Сохранить отчет";
			this.сохранитьОтчетToolStripMenuItem.Click += new System.EventHandler(this.СохранитьОтчетToolStripMenuItem_Click);
			// 
			// сохранитьВсеВОтчетToolStripMenuItem
			// 
			this.сохранитьВсеВОтчетToolStripMenuItem.Name = "сохранитьВсеВОтчетToolStripMenuItem";
			this.сохранитьВсеВОтчетToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
			this.сохранитьВсеВОтчетToolStripMenuItem.Text = "Сохранить все в отчет";
			this.сохранитьВсеВОтчетToolStripMenuItem.Click += new System.EventHandler(this.СохранитьВсеВОтчетToolStripMenuItem_Click);
			// 
			// командыCmdToolStripMenuItem
			// 
			this.командыCmdToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.shutdownToolStripMenuItem,
									this.shutdownдляУдаленкиToolStripMenuItem,
									this.pingToolStripMenuItem,
									this.assocToolStripMenuItem,
									this.netstatToolStripMenuItem,
									this.tracertToolStripMenuItem,
									this.pathpingToolStripMenuItem,
									this.netUserdomainToolStripMenuItem,
									this.netViewToolStripMenuItem,
									this.wifiToolStripMenuItem,
									this.настройкаWMIToolStripMenuItem});
			this.командыCmdToolStripMenuItem.Name = "командыCmdToolStripMenuItem";
			this.командыCmdToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
			this.командыCmdToolStripMenuItem.Text = "Команды CMD";
			this.командыCmdToolStripMenuItem.ToolTipText = "Настройка для возможности удаленного доступа";
			// 
			// shutdownToolStripMenuItem
			// 
			this.shutdownToolStripMenuItem.Name = "shutdownToolStripMenuItem";
			this.shutdownToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
			this.shutdownToolStripMenuItem.Text = "Shutdown";
			this.shutdownToolStripMenuItem.ToolTipText = "Автовыключение";
			this.shutdownToolStripMenuItem.Click += new System.EventHandler(this.ShutdownToolStripMenuItem_Click);
			// 
			// shutdownдляУдаленкиToolStripMenuItem
			// 
			this.shutdownдляУдаленкиToolStripMenuItem.Name = "shutdownдляУдаленкиToolStripMenuItem";
			this.shutdownдляУдаленкиToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
			this.shutdownдляУдаленкиToolStripMenuItem.Text = "Shutdown (удаленный компьютер)";
			this.shutdownдляУдаленкиToolStripMenuItem.ToolTipText = "Автовыключение удаленного компьютера";
			this.shutdownдляУдаленкиToolStripMenuItem.Click += new System.EventHandler(this.ShutdownдляУдаленкиToolStripMenuItem_Click);
			// 
			// pingToolStripMenuItem
			// 
			this.pingToolStripMenuItem.Name = "pingToolStripMenuItem";
			this.pingToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
			this.pingToolStripMenuItem.Text = "Ping";
			this.pingToolStripMenuItem.ToolTipText = "Информация по прохождению пакетов до узла";
			this.pingToolStripMenuItem.Click += new System.EventHandler(this.PingToolStripMenuItem_Click);
			// 
			// assocToolStripMenuItem
			// 
			this.assocToolStripMenuItem.Name = "assocToolStripMenuItem";
			this.assocToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
			this.assocToolStripMenuItem.Text = "Assoc";
			this.assocToolStripMenuItem.ToolTipText = "Ассоциация типов с программами по умолчанию";
			this.assocToolStripMenuItem.Click += new System.EventHandler(this.AssocToolStripMenuItem_Click);
			// 
			// netstatToolStripMenuItem
			// 
			this.netstatToolStripMenuItem.Name = "netstatToolStripMenuItem";
			this.netstatToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
			this.netstatToolStripMenuItem.Text = "Netstat";
			this.netstatToolStripMenuItem.ToolTipText = "Выводит список активных подключений";
			this.netstatToolStripMenuItem.Click += new System.EventHandler(this.NetstatToolStripMenuItem_Click);
			// 
			// tracertToolStripMenuItem
			// 
			this.tracertToolStripMenuItem.Name = "tracertToolStripMenuItem";
			this.tracertToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
			this.tracertToolStripMenuItem.Text = "Tracert";
			this.tracertToolStripMenuItem.ToolTipText = "Показывает маршрут до узла";
			this.tracertToolStripMenuItem.Click += new System.EventHandler(this.TracertToolStripMenuItem_Click);
			// 
			// pathpingToolStripMenuItem
			// 
			this.pathpingToolStripMenuItem.Name = "pathpingToolStripMenuItem";
			this.pathpingToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
			this.pathpingToolStripMenuItem.Text = "Pathping";
			this.pathpingToolStripMenuItem.ToolTipText = "Показывает подробный отчет о прохождении пакетов на всех узлах по пути до конечно" +
			"го";
			this.pathpingToolStripMenuItem.Click += new System.EventHandler(this.PathpingToolStripMenuItem_Click);
			// 
			// netUserdomainToolStripMenuItem
			// 
			this.netUserdomainToolStripMenuItem.Name = "netUserdomainToolStripMenuItem";
			this.netUserdomainToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
			this.netUserdomainToolStripMenuItem.Text = "Net user.../domain";
			this.netUserdomainToolStripMenuItem.ToolTipText = "Выводит всю информацию о пользователе в домене";
			this.netUserdomainToolStripMenuItem.Click += new System.EventHandler(this.NetUserdomainToolStripMenuItem_Click);
			// 
			// netViewToolStripMenuItem
			// 
			this.netViewToolStripMenuItem.Name = "netViewToolStripMenuItem";
			this.netViewToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
			this.netViewToolStripMenuItem.Text = "Net view";
			this.netViewToolStripMenuItem.ToolTipText = "Выводит информацию об активных устройствах в сети";
			this.netViewToolStripMenuItem.Click += new System.EventHandler(this.NetViewToolStripMenuItem_Click);
			// 
			// wifiToolStripMenuItem
			// 
			this.wifiToolStripMenuItem.Name = "wifiToolStripMenuItem";
			this.wifiToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
			this.wifiToolStripMenuItem.Text = "Точка доступа wi-fi";
			this.wifiToolStripMenuItem.ToolTipText = "Создает точку тоступа WI-FI";
			this.wifiToolStripMenuItem.Click += new System.EventHandler(this.WifiToolStripMenuItem_Click);
			// 
			// настройкаWMIToolStripMenuItem
			// 
			this.настройкаWMIToolStripMenuItem.Name = "настройкаWMIToolStripMenuItem";
			this.настройкаWMIToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
			this.настройкаWMIToolStripMenuItem.Text = "Настройка WMI";
			this.настройкаWMIToolStripMenuItem.ToolTipText = "Добавление WMI в исключения брандмауэра";
			this.настройкаWMIToolStripMenuItem.Click += new System.EventHandler(this.НастройкаWMIToolStripMenuItem_Click);
			// 
			// дополнительноToolStripMenuItem
			// 
			this.дополнительноToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.оценкаПроизводительностиWindowsToolStripMenuItem});
			this.дополнительноToolStripMenuItem.Name = "дополнительноToolStripMenuItem";
			this.дополнительноToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
			this.дополнительноToolStripMenuItem.Text = "Дополнительно";
			// 
			// оценкаПроизводительностиWindowsToolStripMenuItem
			// 
			this.оценкаПроизводительностиWindowsToolStripMenuItem.Name = "оценкаПроизводительностиWindowsToolStripMenuItem";
			this.оценкаПроизводительностиWindowsToolStripMenuItem.Size = new System.Drawing.Size(285, 22);
			this.оценкаПроизводительностиWindowsToolStripMenuItem.Text = "Оценка производительности Windows";
			this.оценкаПроизводительностиWindowsToolStripMenuItem.Click += new System.EventHandler(this.ОценкаПроизводительностиWindowsToolStripMenuItem_Click);
			// 
			// button1
			// 
			this.button1.Enabled = false;
			this.button1.Location = new System.Drawing.Point(11, 325);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(157, 23);
			this.button1.TabIndex = 9;
			this.button1.Text = "Сетевые настройки";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button8
			// 
			this.button8.Enabled = false;
			this.button8.Location = new System.Drawing.Point(11, 296);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(157, 23);
			this.button8.TabIndex = 8;
			this.button8.Text = "Учетные записи";
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.Button8Click);
			// 
			// button2
			// 
			this.button2.Enabled = false;
			this.button2.Location = new System.Drawing.Point(11, 414);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(157, 23);
			this.button2.TabIndex = 13;
			this.button2.Text = "Процессы";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2_Click);
			// 
			// button5
			// 
			this.button5.Enabled = false;
			this.button5.Location = new System.Drawing.Point(11, 473);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(157, 23);
			this.button5.TabIndex = 15;
			this.button5.Text = "Программы и компоненты";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.Button5_Click);
			// 
			// button11
			// 
			this.button11.Location = new System.Drawing.Point(12, 512);
			this.button11.Name = "button11";
			this.button11.Size = new System.Drawing.Size(156, 23);
			this.button11.TabIndex = 18;
			this.button11.Text = "<<< Выход <<<";
			this.button11.UseVisualStyleBackColor = true;
			this.button11.Click += new System.EventHandler(this.Button11_Click);
			// 
			// button12
			// 
			this.button12.Enabled = false;
			this.button12.Location = new System.Drawing.Point(11, 444);
			this.button12.Name = "button12";
			this.button12.Size = new System.Drawing.Size(157, 23);
			this.button12.TabIndex = 14;
			this.button12.Text = "Службы";
			this.button12.UseVisualStyleBackColor = true;
			this.button12.Click += new System.EventHandler(this.Button12_Click);
			// 
			// button13
			// 
			this.button13.Location = new System.Drawing.Point(12, 40);
			this.button13.Name = "button13";
			this.button13.Size = new System.Drawing.Size(156, 23);
			this.button13.TabIndex = 5;
			this.button13.Text = "Прозвон сети";
			this.button13.UseVisualStyleBackColor = true;
			this.button13.Click += new System.EventHandler(this.Button13_Click);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(12, 66);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 14);
			this.label5.TabIndex = 55;
			this.label5.Text = "Всего в сети:";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(12, 80);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 12);
			this.label6.TabIndex = 56;
			this.label6.Text = "Доступно:";
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.button15);
			this.panel2.Controls.Add(this.button13);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Location = new System.Drawing.Point(-1, 124);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(186, 100);
			this.panel2.TabIndex = 4;
			// 
			// button15
			// 
			this.button15.Location = new System.Drawing.Point(12, 12);
			this.button15.Name = "button15";
			this.button15.Size = new System.Drawing.Size(156, 23);
			this.button15.TabIndex = 57;
			this.button15.Text = "Учет ВТ";
			this.button15.UseVisualStyleBackColor = true;
			this.button15.Click += new System.EventHandler(this.Button15_Click);
			// 
			// textBox5
			// 
			this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox5.Location = new System.Drawing.Point(555, 4);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(100, 20);
			this.textBox5.TabIndex = 16;
			// 
			// button14
			// 
			this.button14.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
			this.button14.Location = new System.Drawing.Point(657, 4);
			this.button14.Name = "button14";
			this.button14.Size = new System.Drawing.Size(20, 20);
			this.button14.TabIndex = 17;
			this.button14.Text = ">";
			this.button14.UseVisualStyleBackColor = true;
			this.button14.Click += new System.EventHandler(this.Button14_Click);
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.SystemColors.Control;
			this.label7.Location = new System.Drawing.Point(510, 4);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(42, 17);
			this.label7.TabIndex = 61;
			this.label7.Text = "Поиск:";
			// 
			// RDform
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(681, 539);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.button14);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.button12);
			this.Controls.Add(this.button11);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button10);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.button9);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.button8);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "RDform";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Load += new System.EventHandler(this.RDform_Load);
			this.VisibleChanged += new System.EventHandler(this.RDform_VisibleChanged);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.contextMenuStrip1.ResumeLayout(false);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button15;
		private System.Windows.Forms.ToolStripMenuItem настройкаWMIToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem wifiToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem netViewToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem netUserdomainToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pathpingToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tracertToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem netstatToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem assocToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pingToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem shutdownдляУдаленкиToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem shutdownToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem командыCmdToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem оценкаПроизводительностиWindowsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem дополнительноToolStripMenuItem;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button button14;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button button13;
		private System.Windows.Forms.Button button12;
		private System.Windows.Forms.Button button11;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ToolStripMenuItem сохранитьВсеВОтчетToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem сохранитьОтчетToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
		private System.Windows.Forms.Button button9;
		public System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem вырезатьToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem вставитьToolStripMenuItem;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button3;
		
		
	}
}
