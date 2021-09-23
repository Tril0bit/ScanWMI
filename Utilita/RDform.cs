/*
 * Сделано в SharpDevelop.
 * Пользователь: r.iskhakov
 * Дата: 13.01.2017
 * Время: 14:16
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.Management;
using System.Management.Instrumentation;
using System.IO;
using System.Text;
using System.Threading;
using Microsoft.Win32;

namespace Utilita
{
	/// <summary>
	/// Description of RDform.
	/// </summary>
	public partial class RDform : Form
	{
		public RDform()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		public class GlobalVars
		{
			public static string pstr = string.Empty;
			public static string pinfa = string.Empty;
			public static bool inv = false; //проверка для инвентаризации
			public static int i = 0; //счетчик для массива успешного прозвона
			public static string[] strArr = new string[255]; //массив для передачи успешного прозвона
			
			//Для checkbox'ов на форме инвентаризации
			public static bool hard = false;
			public static bool soft = false;
			public static bool uch = false;
			public static bool net = false;
			public static bool proizv = false;
			public static bool tem = false; //принтеры
			public static bool ev = false;
			public static bool process = false;
			public static bool service = false;
			public static bool product = false;			
		}
		
		//***********Удаленное подключение***********
		void Button4_Click(object sender, EventArgs e)
		{
			richTextBox1.Text = "Установка соединения...";
			try
			{
				string IP = Convert.ToString(textBox1.Text);
				ManagementScope scope = new ManagementScope(string.Format("\\\\" + IP +"\\root\\cimv2"));
				
				ObjectQuery ProcessorQuery = new System.Management.ObjectQuery("select * from Win32_Processor");
				ManagementObjectSearcher ProcessorSearcher = new ManagementObjectSearcher(scope, ProcessorQuery);
				ManagementObjectCollection ProcessorCollection = ProcessorSearcher.Get();
				
				button9.Enabled = true;
				button6.Enabled = true;
				button8.Enabled = true;
				button1.Enabled = true;
				button3.Enabled = true;
				button7.Enabled = true;
				button10.Enabled = true;
				button2.Enabled = true;
				button5.Enabled = true;
				button12.Enabled = true;

				richTextBox1.Text = "Соединение установлено" + "\n";
			}
			catch
			{
				richTextBox1.Text = "Введены неверные данные или на удаленном компьютере не запущены необходимые службы.";
			}			
		}
		
		//***************Учетные записи****************
		void Button8Click(object sender, EventArgs e)
		{
			string IP = Convert.ToString(textBox1.Text);
			ManagementScope scope = new ManagementScope(string.Format("\\\\" + IP +"\\root\\cimv2"));
			
			richTextBox1.Text = "Подождите, формируется список...\n";
			string str = string.Empty;
			string infa = string.Empty;
			string strLine = "___________________________________________________________________\n\n";

			try
			{
				//Учетки сети
				string strUch = "Учетные записи и пользователи домена: "+ "\n";
				infa = infa + strUch;
				ObjectQuery UQuery = new System.Management.ObjectQuery("select * from Win32_UserAccount");
				ManagementObjectSearcher USearcher = new ManagementObjectSearcher(scope, UQuery);
				ManagementObjectCollection UCollection = USearcher.Get();

				foreach (ManagementObject UInfo in UCollection)
				{
					str = UInfo["Caption"].ToString() + "\n"
					+ UInfo["FullName"].ToString() + "\n" + "Статус: " + UInfo["Status"].ToString() + "\n"
					+"-------------------------------------------------------------------\n";
					infa = infa + str;
				}

				infa = infa + strLine;
			}
			catch
			{
				str = "Не удалось получить список.";
			}
			richTextBox1.Text = infa;
		}
		
		//************HARDWARE***************
		void Button9Click(object sender, EventArgs e)
		{
			string IP = Convert.ToString(textBox1.Text);
			ManagementScope scope = new ManagementScope(string.Format("\\\\" + IP +"\\root\\cimv2"));
			
			richTextBox1.Text = "Подождите, формируется список...\n";
			string str = string.Empty;
			string infa = string.Empty;
			string strLine = "___________________________________________________________________\n\n";
			string L3 = string.Empty;
			
			//Процессор
			try
			{
				ObjectQuery ProcessorQuery = new System.Management.ObjectQuery("select * from Win32_Processor");
				ManagementObjectSearcher ProcessorSearcher = new ManagementObjectSearcher(scope, ProcessorQuery);
				ManagementObjectCollection ProcessorCollection = ProcessorSearcher.Get();

				foreach (ManagementObject ProcessorInfo in ProcessorCollection)
				{
					try  //исключение кэша 3-го уровня для старых ПК
					{
						L3 = "Кэш L3:               " + ProcessorInfo["L3CacheSize"].ToString() +" Кб"+ "\n";
					}
					catch
					{
						L3 = "";
					}
					
					str = "Процессор:"+"\n" + ProcessorInfo["Name"].ToString() + "\n"
					+ "Сокет:                " + ProcessorInfo["SocketDesignation"].ToString() + "\n"
					+ "Количество ядер:      " + ProcessorInfo["NumberOfcores"].ToString() + "\n"
					+ "Количество лог. ядер: " + ProcessorInfo["NumberOfLogicalProcessors"].ToString() + "\n"
					+ "Текущая т.ч.:         " + ProcessorInfo["CurrentClockSpeed"].ToString() +" МГц" + "\n"
					+ "Максимальная т.ч.:    " + ProcessorInfo["MaxClockSpeed"].ToString() +" МГц" + "\n"
					+ "Кэш L2:               " + ProcessorInfo["L2CacheSize"].ToString() +" Кб"+ "\n"
					+ L3;
					richTextBox1.Text = "";
					richTextBox1.Text = richTextBox1.Text + str;
				}
			}
			catch
			{
				richTextBox1.Text = richTextBox1.Text + "Ошибка чтения\n";
			}
			richTextBox1.Text = richTextBox1.Text + strLine;

			//Мат.Плата
			try
			{
				ObjectQuery BoardQuery = new System.Management.ObjectQuery("select * from Win32_BaseBoard");
				ManagementObjectSearcher BoardSearcher = new ManagementObjectSearcher(scope, BoardQuery);
				ManagementObjectCollection BoardCollection = BoardSearcher.Get();
				foreach (ManagementObject BoardInfo in BoardCollection)
				{
					str = "Материнская плата:"+"\n"+"Производитель: " + BoardInfo["Manufacturer"].ToString() + "\n"
					+ "Модель:        " + BoardInfo["Product"].ToString() + "\n";
					richTextBox1.Text = richTextBox1.Text + str;
				}
			}
			catch
			{
				richTextBox1.Text = richTextBox1.Text + "Ошибка чтения\n";
			}
			richTextBox1.Text = richTextBox1.Text + strLine;

			//ОЗУ
			richTextBox1.Text = richTextBox1.Text + "ОЗУ: "+ "\n";
			string tip = string.Empty;
			string OZUspeed = string.Empty;
			double RAM = 0;
			try
			{
				ObjectQuery OZUQuery = new System.Management.ObjectQuery("select * from Win32_PhysicalMemory");
				ManagementObjectSearcher OZUSearcher = new ManagementObjectSearcher(scope, OZUQuery);
				ManagementObjectCollection OZUCollection = OZUSearcher.Get();
				foreach (ManagementObject OZUInfo in OZUCollection)
				{
					try //исключение частоты для старых ПК
					{
						OZUspeed = OZUInfo["Speed"].ToString() + " МГц" + "\n";
					}
					catch
					{
						OZUspeed = "";
					}
					str = "Объем: " + Convert.ToDouble(OZUInfo["Capacity"])/1048576 +" МБ"+ "  Частота: "
					+ OZUspeed
					+ "Канал: " + OZUInfo["DataWidth"].ToString() + "\n";
					
					switch (Convert.ToInt16(OZUInfo["MemoryType"]))
					{
							case 0: tip = "Unknown"; break;
							case 1: tip = "Other"; break;
							case 2: tip = "DRAM"; break;
							case 3: tip = "Synchronous DRAM"; break;
							case 4: tip = "Cache"; break;
							case 5: tip = "EDO"; break;
							case 6: tip = "EDRAM"; break;
							case 7: tip = "VRAM"; break;
							case 8: tip = "SRAM"; break;
							case 9: tip = "RAM"; break;
							case 10: tip = "ROM"; break;
							case 11: tip = "Flash"; break;
							case 12: tip = "EEPROM"; break;
							case 13: tip = "FEPROM"; break;
							case 14: tip = "EPROM"; break;
							case 15: tip = "CDRAM"; break;
							case 16: tip = "3DRAM"; break;
							case 17: tip = "SDRAM"; break;
							case 18: tip = "SGRAM"; break;
							case 19: tip = "RDRAM"; break;
							case 20: tip = "DDR"; break;
							case 21: tip = "DDR2"; break;
							case 22: tip = "DDR2 FB-DIMM"; break;
							case 24: tip = "DDR3"; break;
							case 25: tip = "FBD2"; break;
							default: tip = "Неизвестный тип"; break;
					}
					RAM = RAM + Convert.ToDouble(OZUInfo["Capacity"]);					
					richTextBox1.Text = richTextBox1.Text + str + tip + "\n\n";
				}
			}
			catch
			{
				richTextBox1.Text = richTextBox1.Text + "Ошибка чтения\n";
			}
			richTextBox1.Text = richTextBox1.Text + "Всего: " + Math.Round((RAM/1073741824),2) + "ГБ\n" + strLine;

			//Видеокарта
			richTextBox1.Text = richTextBox1.Text + "Видеоконтроллеры: "+ "\n";
			try
			{
				ObjectQuery VideoQuery = new System.Management.ObjectQuery("select * from Win32_VideoController");
				ManagementObjectSearcher VideoSearcher = new ManagementObjectSearcher(scope, VideoQuery);
				ManagementObjectCollection VideoCollection = VideoSearcher.Get();
				foreach (ManagementObject VideoInfo in VideoCollection)
				{
					str = VideoInfo["Name"].ToString() + "\n"
						+"Объем: " + Convert.ToDouble(VideoInfo["AdapterRAM"])/1048576 +" МБ"+ "\n"
						+"Версия драйвера: " + VideoInfo["DriverVersion"].ToString() + "  Дата: " + VideoInfo["DriverDate"].ToString().Remove(8).Insert(4, ".").Insert(7, ".").Insert(10, ".")
						+ "\n\n";
					richTextBox1.Text = richTextBox1.Text + str;
				}
			}
			catch
			{
				richTextBox1.Text = richTextBox1.Text + "Ошибка чтения\n";
			}
			richTextBox1.Text = richTextBox1.Text + strLine;

			//HDD
			richTextBox1.Text = richTextBox1.Text + "Устройства хранения: "+ "\n";
			try
			{
				ObjectQuery DDiskQuery = new System.Management.ObjectQuery("select * from Win32_DiskDrive");
				ManagementObjectSearcher DDiskSearcher = new ManagementObjectSearcher(scope, DDiskQuery);
				ManagementObjectCollection DDiskCollection = DDiskSearcher.Get();

				foreach (ManagementObject DDiskInfo in DDiskCollection)
				{
					
					str = "Имя диска: " + DDiskInfo["Caption"].ToString() + "\n" +
					"Объем:     " + Math.Round((Convert.ToDouble(DDiskInfo["Size"])/1073741824),2)+ " Гб" + "\n\n";
					richTextBox1.Text = richTextBox1.Text + str;
				}
			}
			catch
			{
				richTextBox1.Text = richTextBox1.Text + "Ошибка чтения\n";
			}
			richTextBox1.Text = richTextBox1.Text + strLine;
			
			//SMART
			richTextBox1.Text = richTextBox1.Text + "Состояние S.M.A.R.T. (поврежден, если true)"+ "\n";
			try
			{
				ManagementObjectSearcher SmartSearcher = new ManagementObjectSearcher("\\\\" + IP +"\\root\\wmi", "SELECT * FROM MSStorageDriver_FailurePredictStatus");
				ManagementObjectCollection SmartCollection = SmartSearcher.Get();
				
				foreach (ManagementObject SmartInfo in SmartCollection)				
				{					
					str = "" + SmartInfo["InstanceName"] + ": " + SmartInfo["PredictFailure"] + "\n";
					richTextBox1.Text = richTextBox1.Text + str;
				}
			}
			catch
			{				
				richTextBox1.Text = richTextBox1.Text + "Ошибка чтения\n";
			}
			richTextBox1.Text = richTextBox1.Text + strLine;

			//Звуковые устройства
			richTextBox1.Text = richTextBox1.Text + "Звуковые устройства: "+ "\n";
			try
			{
				ObjectQuery SoundQuery = new System.Management.ObjectQuery("select * from Win32_SoundDevice");
				ManagementObjectSearcher SoundSearcher = new ManagementObjectSearcher(scope, SoundQuery);
				ManagementObjectCollection SoundCollection = SoundSearcher.Get();

				foreach (ManagementObject SoundInfo in SoundCollection)
				{
					
					str = SoundInfo["Name"].ToString() + "\n";
					richTextBox1.Text = richTextBox1.Text + str;
				}
			}
			catch
			{
				richTextBox1.Text = richTextBox1.Text + "Ошибка чтения\n";
			}
			richTextBox1.Text = richTextBox1.Text + strLine;

			//Монитор
			try
			{
				ObjectQuery MonQuery = new System.Management.ObjectQuery("select * from Win32_DesktopMonitor");
				ManagementObjectSearcher MonSearcher = new ManagementObjectSearcher(scope, MonQuery);
				ManagementObjectCollection MonCollection = MonSearcher.Get();
				foreach (ManagementObject MonInfo in MonCollection)
				{
					str = "Монитор:"+"\n" + MonInfo["Caption"].ToString() + "\n"
					+ "ID: " + MonInfo["PNPDeviceID"].ToString() 
					+ "\nРазрешение: " + MonInfo["ScreenWidth"].ToString() + "х" + MonInfo["ScreenHeight"].ToString() + "\n";
					richTextBox1.Text = richTextBox1.Text + str;
				}
			}
			catch
			{
				richTextBox1.Text = richTextBox1.Text + "\nОшибка чтения информации о мониторе\n";
			}
			richTextBox1.Text = richTextBox1.Text + strLine;

		}

		//***********Настройки сети**************
		void Button1Click(object sender, EventArgs e)
		{
			string IP = Convert.ToString(textBox1.Text);
			ManagementScope scope = new ManagementScope(string.Format("\\\\" + IP +"\\root\\cimv2"));
			
			richTextBox1.Text = "";
			string strLine = "___________________________________________________________________\n\n";
			string str = string.Empty;
			string infa = string.Empty;
			string Sstr = string.Empty; //запись для вывода
			string[] IPstr; 	//массив IP адреса
			string[] Substr;	//массив маски подсети
			string[] Ostr;		//массив основного шлюза
			string[] DNSstr;	//массив DNS сервера
			try
			{
				ObjectQuery IPQuery = new System.Management.ObjectQuery("select * from Win32_NetworkAdapterConfiguration WHERE IPEnabled = True");
				ManagementObjectSearcher IPSearcher = new ManagementObjectSearcher(scope, IPQuery);
				ManagementObjectCollection IPCollection = IPSearcher.Get();

				foreach (ManagementObject IPInfo in IPCollection)
				{
					Sstr = "Сетевой адаптер: " + "\n\n" + IPInfo["Description"] + "\n\n";
					IPstr = (string[])(IPInfo["IPAddress"]);
					Substr = (string[])(IPInfo["IPSubnet"]);
					Ostr =	(string[])(IPInfo["DefaultIPGateway"]);
					DNSstr = (string[])(IPInfo["DNSServerSearchOrder"]);
					
					try
					{
						foreach (String arrValue in IPstr)
						{
							Sstr = Sstr + "IP Адрес: " + arrValue + "\n";
						}
						
						foreach (String arrValue in Substr)
						{
							Sstr = Sstr + "Маска подсети: " + arrValue + "\n";
						}
						
						foreach (String arrValue in Ostr)
						{
							Sstr = Sstr + "Основной шлюз: " + arrValue + "\n";
						}
						
						foreach (String arrValue in DNSstr)
						{
							Sstr = Sstr + "DNS Сервер: " + arrValue + "\n";
						}
					}
					catch
					{
						Sstr = "Ошибка чтения.\n";
					}
				}
			}
			catch
			{
				richTextBox1.Text = "Ошибка чтения.\n";
			}


			//Раб группа
			try
			{
				ObjectQuery CSQuery = new System.Management.ObjectQuery("select * from Win32_ComputerSystem");
				ManagementObjectSearcher CSSearcher = new ManagementObjectSearcher(scope, CSQuery);
				ManagementObjectCollection CSCollection = CSSearcher.Get();
				foreach (ManagementObject CSInfo in CSCollection)
				{
					str = "Компьютер в сети: "+ "\n"
					+ "Имя пользователя: " + CSInfo["UserName"].ToString() + "\n"
					+ "Имя компьютера: " + CSInfo["Name"]+ "\n"
					+ "Рабочая группа: " + CSInfo["Domain"].ToString()	+ "\n";
					richTextBox1.Text = richTextBox1.Text + str + strLine;
				}

			}
			catch
			{
				richTextBox1.Text = "Ошибка чтения\n";
			}

			//Сетевые диски
			try
			{
				richTextBox1.Text = richTextBox1.Text + "Cетевые диски: \n\n";
				ObjectQuery CSDQuery = new System.Management.ObjectQuery("select * from Win32_NetworkConnection");
				ManagementObjectSearcher CSDSearcher = new ManagementObjectSearcher(scope, CSDQuery);
				ManagementObjectCollection CSDCollection = CSDSearcher.Get();
				foreach (ManagementObject CSDInfo in CSDCollection)
				{
					str = "Метка: " + CSDInfo["LocalName"].ToString()
						+ "Удаленное имя: " + CSDInfo["RemoteName"].ToString()	+ "\n";
					richTextBox1.Text = richTextBox1.Text + str + "\n";
				}
			}
			catch
			{
				richTextBox1.Text = "Ошибка чтения";
			}
			richTextBox1.Text = richTextBox1.Text + strLine + Sstr + strLine;
		}

		//***********Оценка производительности**************
		void Button3_Click(object sender, EventArgs e)
		{
			string IP = Convert.ToString(textBox1.Text);
			ManagementScope scope = new ManagementScope(string.Format("\\\\" + IP +"\\root\\cimv2"));
			
			richTextBox1.Text = "";
			string str = string.Empty;
			string infa = string.Empty;
			try
			{
				ObjectQuery TestQuery = new System.Management.ObjectQuery("select * from Win32_WinSAT");
				ManagementObjectSearcher TestSearcher = new ManagementObjectSearcher(scope, TestQuery);
				ManagementObjectCollection TestCollection = TestSearcher.Get();
				
				foreach (ManagementObject TestInfo in TestCollection)
				{
					str = "Оценка производительности \n(Win Vista: 1.0-5.9 || Win 7: 1.0-7.9 || Win 8 и 10:  1.0-10.0): "+ "\n\n"
					+ "CPU:              " + TestInfo["CPUScore"].ToString() + "\n"
					+ "3D-графика:       " + TestInfo["D3DScore"].ToString() + "\n"
					+ "HDD/SSD:          " + TestInfo["DiskScore"].ToString()	+ "\n"
					+ "Графика Win-Aero: " + TestInfo["GraphicsScore"].ToString()	+ "\n"
					+ "ОЗУ:              " + TestInfo["MemoryScore"].ToString()	+ "\n\n"
					+ "Итог:             " + TestInfo["WinSPRLevel"].ToString()	+ "\n\n";					
					richTextBox1.Text = richTextBox1.Text + str;
				}
			}
			catch
			{
				richTextBox1.Text = "Не удалось прочитать информацию о производительности.";
			}
		}
		
		//***********SOFTWARE*************
		void Button6_Click(object sender, EventArgs e)
		{
			string IP = Convert.ToString(textBox1.Text);
			ManagementScope scope = new ManagementScope(string.Format("\\\\" + IP +"\\root\\cimv2"));
			
			richTextBox1.Text = "Подождите, формируется список...\n";
			string str = string.Empty;
			string infa = string.Empty;
			string strLine = "___________________________________________________________________\n\n";
			string OSArch = string.Empty;

			//Операционная система
			try
			{
				ObjectQuery OSQuery = new System.Management.ObjectQuery("select * from Win32_OperatingSystem");
				ManagementObjectSearcher OSSearcher = new ManagementObjectSearcher(scope, OSQuery);
				ManagementObjectCollection OSCollection = OSSearcher.Get();

				foreach (ManagementObject OSInfo in OSCollection)
				{
					try //исключение битности ОС для старых систем
					{
						OSArch = OSInfo["OSArchitecture"].ToString();
					}
					catch
					{
						OSArch = "";
					}
					str = "Операционная система: "+ "\n"
					+ OSInfo["Caption"].ToString() + " " + OSArch + "\n"
					+ "Дополнения:       " + OSInfo["CSDVersion"] + "\n"
					+ "№ сборки:         " + OSInfo["BuildNumber"].ToString()	+ "\n"
					+ "Серийный номер:   " + OSInfo["SerialNumber"].ToString() + "\n"
					+ "Дата установки:   " + OSInfo["InstallDate"].ToString().Remove(12).Insert(4, ".").Insert(7, ".").Insert(10, ".") + "\n"
					+ "Последний запуск: " + OSInfo["LastBootUpTime"].ToString().Remove(12).Insert(4, ".").Insert(7, ".").Insert(10, ".") + "\n";
					richTextBox1.Text = "";
					richTextBox1.Text = richTextBox1.Text + str;
				}
			}
			catch
			{
				richTextBox1.Text = richTextBox1.Text + "Ошибка чтения\n";
			}
			richTextBox1.Text = richTextBox1.Text + strLine;			

			//BIOS
			try
			{
				ObjectQuery BIOSQuery = new System.Management.ObjectQuery("select * from Win32_BIOS");
				ManagementObjectSearcher BIOSSearcher = new ManagementObjectSearcher(scope, BIOSQuery);
				ManagementObjectCollection BIOSCollection = BIOSSearcher.Get();
				foreach (ManagementObject BIOSInfo in BIOSCollection)
				{
					str = "BIOS: "+ "\n" + BIOSInfo["Name"].ToString() + "\n" + "Версия: "+ BIOSInfo["Version"].ToString() + "\n"
					+ "Дата выхода: " + BIOSInfo["ReleaseDate"].ToString().Remove(8).Insert(4, ".").Insert(7, ".").Insert(10, ".");
					richTextBox1.Text = richTextBox1.Text + str;
				}
			}
			catch
			{
				richTextBox1.Text = richTextBox1.Text + "Ошибка чтения\n";
			}
			richTextBox1.Text = richTextBox1.Text + strLine;

			//Локальные диски
			richTextBox1.Text = richTextBox1.Text + "Локальные диски: "+ "\n";
			try
			{
				ObjectQuery DiskQuery = new System.Management.ObjectQuery("select * from Win32_LogicalDisk where DriveType = 3");
				ManagementObjectSearcher DiskSearcher = new ManagementObjectSearcher(scope, DiskQuery);
				ManagementObjectCollection DiskCollection = DiskSearcher.Get();

				foreach (ManagementObject DiskInfo in DiskCollection)
				{
					
					str = "Имя диска:          " + DiskInfo["Name"].ToString() + " (" + DiskInfo["VolumeName"]+")"+ "\n"
					+ "Файловая система: " + DiskInfo["FileSystem"].ToString() + "\n"
					+ "Размер диска:     " + Math.Round((Convert.ToDouble(DiskInfo["Size"])/1073741824),2)+ " Гб" +"\n"
					+ "Свободное место:  " + Math.Round((Convert.ToDouble(DiskInfo["FreeSpace"])/1073741824),2)+ " Гб"+"\n\n";
					richTextBox1.Text = richTextBox1.Text + str;
				}
			}
			catch
			{
				richTextBox1.Text = richTextBox1.Text + "Ошибка чтения\n";
			}
			richTextBox1.Text = richTextBox1.Text + strLine;

			//Файлы подкачки
			richTextBox1.Text = richTextBox1.Text + "Файлы подкачки: "+ "\n";
			try
			{
				ObjectQuery PageQuery = new System.Management.ObjectQuery("select * from Win32_PageFile");
				ManagementObjectSearcher PageSearcher = new ManagementObjectSearcher(scope, PageQuery);
				ManagementObjectCollection PageCollection = PageSearcher.Get();

				foreach (ManagementObject PageInfo in PageCollection)
				{
					
					str = PageInfo["Caption"].ToString() + "\n" +
					"Размер: " + PageInfo["InitialSize"].ToString() + " Мб" + " - " + PageInfo["MaximumSize"].ToString() + "Мб" + "\n\n";
					richTextBox1.Text = richTextBox1.Text + str;
				}
			}
			catch
			{
				richTextBox1.Text = richTextBox1.Text + "Ошибка чтения\n";
			}
			richTextBox1.Text = richTextBox1.Text + strLine;

			//Автозапуск
			richTextBox1.Text = richTextBox1.Text +  "Автозапуск: "+ "\n";;
			try
			{
				ObjectQuery AQuery = new System.Management.ObjectQuery("select * from Win32_StartupCommand");
				ManagementObjectSearcher ASearcher = new ManagementObjectSearcher(scope, AQuery);
				ManagementObjectCollection ACollection = ASearcher.Get();

				foreach (ManagementObject AInfo in ACollection)
				{
					str = "\n" + AInfo["Name"].ToString() + "\n"
					+ "Путь: " + AInfo["Command"].ToString() + "\n";
					richTextBox1.Text = richTextBox1.Text + str;
				}
			}
			catch
			{
				richTextBox1.Text = richTextBox1.Text + "Ошибка чтения\n";
			}
			richTextBox1.Text = richTextBox1.Text + strLine;
			
			//Обновления Windows
			try
			{
				richTextBox1.Text = richTextBox1.Text + "Обновления Windows: "+ "\n";
				ObjectQuery UOSQuery = new System.Management.ObjectQuery("select * from Win32_QuickFixEngineering");
				ManagementObjectSearcher UOSSearcher = new ManagementObjectSearcher(scope, UOSQuery);
				ManagementObjectCollection UOSCollection = UOSSearcher.Get();

				foreach (ManagementObject UOSInfo in UOSCollection)
				{
					str = UOSInfo["HotFixID"].ToString()
					+ "   Дата: " + UOSInfo["InstalledOn"].ToString() + "\n";
					richTextBox1.Text = richTextBox1.Text + str;
				}
			}
			catch
			{
				richTextBox1.Text = richTextBox1.Text + "Ошибка чтения\n";
			}
			richTextBox1.Text = richTextBox1.Text + strLine;
			
			//Время			
			ObjectQuery TimeQuery = new System.Management.ObjectQuery("select * from Win32_LocalTime");
			ManagementObjectSearcher TimeSearcher = new ManagementObjectSearcher(scope, TimeQuery);
			ManagementObjectCollection TimeCollection = TimeSearcher.Get();

			foreach (ManagementObject TimeInfo in TimeCollection)
			{				
				str = "Время на удаленном компьютере: " + TimeInfo["Hour"].ToString() + "ч" +
				":" + TimeInfo["Minute"].ToString() + "мин" + "   " + TimeInfo["Day"].ToString() +
				"." + TimeInfo["Month"].ToString() + "." + TimeInfo["Year"].ToString();				
				richTextBox1.Text = richTextBox1.Text + str + "\n";
			}
			
			ObjectQuery LTimeQuery = new System.Management.ObjectQuery("select * from Win32_LocalTime");
			ManagementObjectSearcher LTimeSearcher = new ManagementObjectSearcher(LTimeQuery);
			ManagementObjectCollection LTimeCollection = LTimeSearcher.Get();

			foreach (ManagementObject LTimeInfo in LTimeCollection)
			{				
				str = "Время на локальном компьютере: " + LTimeInfo["Hour"].ToString() + "ч" +
				":" + LTimeInfo["Minute"].ToString() + "мин" + "   " + LTimeInfo["Day"].ToString() +
				"." + LTimeInfo["Month"].ToString() + "." + LTimeInfo["Year"].ToString();				
				richTextBox1.Text = richTextBox1.Text + str + "\n" + strLine;
			}

		}

		//*****************Принтеры*********************
		void Button7Click(object sender, EventArgs e)
		{
			string IP = Convert.ToString(textBox1.Text);
			ManagementScope scope = new ManagementScope(string.Format("\\\\" + IP +"\\root\\cimv2"));
			
			richTextBox1.Text = "Подождите, формируется список...\n";
			string str = string.Empty;
			string infa = string.Empty;
			string strLine = "___________________________________________________________________\n\n";
			try
			{
				//Принтеры
				string strUs = "Принтеры: "+ "\n";
				infa = infa + strUs;
				ObjectQuery UsQuery = new System.Management.ObjectQuery("select * from Win32_Printer");
				ManagementObjectSearcher UsSearcher = new ManagementObjectSearcher(scope, UsQuery);
				ManagementObjectCollection UsCollection = UsSearcher.Get();

				foreach (ManagementObject UsInfo in UsCollection)
				{
					str = UsInfo["Name"].ToString() + "\n" + "Порт: " + UsInfo["PortName"].ToString() + "\n"
					+ "Драйвер: " +UsInfo["DriverName"].ToString() 
					+ "\n-------------------------------------------------------------------\n";
					infa = infa + str;
				}
				
				infa = infa + strLine;
			}
			catch
			{
				infa = "Не удалось получить список.";
			}

			try
			{
				//Расшаренные принтеры
				string strUss = "Расшаренные принтеры: "+ "\n";
				infa = infa + strUss;
				ObjectQuery UssQuery = new System.Management.ObjectQuery("select * from Win32_Printer Where Shared = true");
				ManagementObjectSearcher UssSearcher = new ManagementObjectSearcher(scope, UssQuery);
				ManagementObjectCollection UssCollection = UssSearcher.Get();

				foreach (ManagementObject UssInfo in UssCollection)
				{
					str = "Принтер: " + UssInfo["Name"].ToString() + "\n" 
					+ "Сетевое имя: " + UssInfo["ShareName"].ToString() + "\n\n";
					infa = infa + str;
				}

				infa = infa + strLine;
			}
			catch
			{
				str = "Не удалось получить список.";
			}

			try
			{
				//Очередь печати
				string strJob = "Очередь печати: "+ "\n";
				infa = infa + strJob;
				ObjectQuery JobQuery = new System.Management.ObjectQuery("select * from Win32_PrintJob");
				ManagementObjectSearcher JobSearcher = new ManagementObjectSearcher(scope, JobQuery);
				ManagementObjectCollection JobCollection = JobSearcher.Get();

				foreach (ManagementObject JobInfo in JobCollection)
				{
					str = "Принтер: " + JobInfo["Caption"] + "\n" + "Документ: " + JobInfo["Document"] +
					"\nХост: " + JobInfo["HostPrintQueue"] + "\nВладелец: " + JobInfo["Owner"] + "\nРазмер: " + Convert.ToDouble(JobInfo["Size"])/1024 + " Кб" +
					"\nВремя отправки: " + JobInfo["TimeSubmitted"]  + "\nСтатус: " + JobInfo["JobStatus"] + "\n\n";
					infa = infa + str;
				}

				infa = infa + strLine;
			}
			catch
			{
				str = "Не удалось получить список.";
			}
			richTextBox1.Text = infa;
		}
		
		//***События журнала Windows, ошибки***
		void Button10_Click(object sender, EventArgs e)
		{
			richTextBox1.Text = "Подождите, формируется список...\n";
			string IP = Convert.ToString(textBox1.Text);
			ManagementScope scope = new ManagementScope(string.Format("\\\\" + IP +"\\root\\cimv2"));
			
			string str = string.Empty;
			string infa = string.Empty;
			ObjectQuery ErrQuery = new System.Management.ObjectQuery("select * from Win32_NTLogEvent WHERE EventType = 1");
			ManagementObjectSearcher ErrSearcher = new ManagementObjectSearcher(scope, ErrQuery);
			ManagementObjectCollection ErrCollection = ErrSearcher.Get();
			try
			{
				foreach (ManagementObject ErrInfo in ErrCollection)
				{
					str = ErrInfo["Type"].ToString() + " " 
					+ ErrInfo["EventCode"].ToString()+ "     " 
					+ ErrInfo["TimeWritten"].ToString().Remove(12).Insert(4, ".").Insert(7, ".").Insert(10, ".") +"\n" 
					+ ErrInfo["Message"].ToString()+ "\nИсточник: " +  ErrInfo["SourceName"].ToString()  + "\n\n";
					infa = infa + str + "___________________________________________________________________";
				}
			}
			catch
			{
				str = "Ошибка чтения";
			}
			richTextBox1.Text = infa;
		}
		
		//******Процессы******
		void Button2_Click(object sender, EventArgs e)
		{
			string IP = Convert.ToString(textBox1.Text);
			ManagementScope scope = new ManagementScope(string.Format("\\\\" + IP +"\\root\\cimv2"));
			
			richTextBox1.Text = "Подождите, формируется список...";
			string str = string.Empty;
			string infa = string.Empty;
			double mem = 0;
			string strLine = "\n___________________________________________________________________\n";
			
			string strVideo = "Запущенные процессы: "+ "\n";
			infa = infa + strVideo;
			ObjectQuery PQuery = new System.Management.ObjectQuery("select * from Win32_Process");
			ManagementObjectSearcher PSearcher = new ManagementObjectSearcher(scope, PQuery);
			ManagementObjectCollection PCollection = PSearcher.Get();
			
			int y = 0;
			int i = 0;			
			int ystr = 3;
			bool sch = true;
			string[,] strArray = new string[PCollection.Count, ystr];
			string tmp = string.Empty;
			double cur;
			double next;
			int lenArr = 0;	
			
			foreach (ManagementObject PInfo in PCollection)
			{
				try
				{	//заполнение массива процессов
					while (sch == true)
					{
						strArray[i,0] = PInfo["Name"].ToString();
						strArray[i,1] = Convert.ToString(Math.Round((Convert.ToDouble(PInfo["WorkingSetsize"])/1048576),1));
						strArray[i,2] = " Мб" + "\nЗапущен: " + PInfo["CreationDate"].ToString().Remove(12).Insert(4, ".").Insert(7, ".").Insert(10, ".") + "\n" + Convert.ToString(PInfo["ExecutablePath"]) + strLine;
						sch = false;
					}					
					
					i++;
					sch = true;					
					mem = mem + Convert.ToDouble(PInfo["WorkingSetsize"]);					
				}				
				catch
				{
					
				}
			}			
			lenArr = i;
			
			//фильтрация массива процессов по убыванию
			for (int k=0; k<=lenArr; k++)
			{
				for (i=1; i<lenArr; i++)
				{					
					cur = Convert.ToDouble(strArray[i-1,1]);
					next = Convert.ToDouble(strArray[i,1]);
					if (cur < next)
					{
						for (y=0; y<3; y++)
						{
							tmp = strArray[i-1,y];
							strArray[i-1,y] = strArray[i,y];
							strArray[i,y] = tmp;
						}
					}
				}				
			}
			//вывод отфильтрованного списка процессов
			for (i=0; i<lenArr; i++)
			{
				str = str + strArray[i,0];
				str = str + strArray[i,1].PadLeft(63-(strArray[i,0]).Length); //выравнивание
				str = str + strArray[i,2];
			}		
			
			//Объем ОЗУ
			ObjectQuery OZUQuery = new System.Management.ObjectQuery("select * from Win32_PhysicalMemory");
			ManagementObjectSearcher OZUSearcher = new ManagementObjectSearcher(scope,OZUQuery);
			ManagementObjectCollection OZUCollection = OZUSearcher.Get();
			double RAM = 0;
			foreach (ManagementObject OZUInfo in OZUCollection)
			{
				RAM = RAM + Convert.ToDouble(OZUInfo["Capacity"]);
			}
			double procent = Math.Round((100/RAM*mem),2);
			richTextBox1.Text = "******* Занято памяти: " + Math.Round((mem/1073741824),2) + " ГБ из " + Math.Round((RAM/1073741824),2) + " ГБ (" + procent + "%) *******\n\n" + str;		
		}
		

		//*******Службы*******
		void Button12_Click(object sender, EventArgs e)
		{
			string IP = Convert.ToString(textBox1.Text);
			ManagementScope scope = new ManagementScope(string.Format("\\\\" + IP +"\\root\\cimv2"));
			
			richTextBox1.Text = "Подождите, формируется список...";
			string str = string.Empty;
			string infa = string.Empty;
			string strLine = "___________________________________________________________________\n\n";

			string strProc = "Список служб: "+ "\n";
			infa = infa + strProc;
			ObjectQuery PQuery = new System.Management.ObjectQuery("select * from Win32_Service");
			ManagementObjectSearcher PSearcher = new ManagementObjectSearcher(scope, PQuery);
			ManagementObjectCollection PCollection = PSearcher.Get();

			foreach (ManagementObject PInfo in PCollection)
			{
				try
				{
					str = PInfo["Name"].ToString() + "\n" +
					PInfo["Caption"].ToString() + "\n" +
					PInfo["PathName"].ToString() + "\n" +
					"Статус: " + PInfo["State"].ToString() + "\n" +
					"Режим запуска: " + PInfo["StartMode"].ToString() + "\n" +
					PInfo["Description"].ToString() + "\n";
					infa = infa + str + strLine;
				}
				catch
				{
					str = "Нет данных";
				}
			}
			richTextBox1.Text = infa;
		}

		//*******Программы и компоненты********
		void Button5_Click(object sender, EventArgs e)
		{
			string IP = Convert.ToString(textBox1.Text);
			ManagementScope scope = new ManagementScope(string.Format("\\\\" + IP +"\\root\\cimv2"));
			
			richTextBox1.Text = "Подождите, формируется список...";
			string str = string.Empty;
			string infa = string.Empty;
			string strLine = "___________________________________________________________________\n\n";

			string strPr = "Установленные программы: "+ "\n";
			infa = infa + strPr;
			ObjectQuery PrQuery = new System.Management.ObjectQuery("select * from Win32_Product");
			ManagementObjectSearcher PrSearcher = new ManagementObjectSearcher(scope, PrQuery);
			ManagementObjectCollection PrCollection = PrSearcher.Get();
		try
		{
			foreach (ManagementObject PrInfo in PrCollection)
			{
				try
				{
					str = PrInfo["Name"].ToString()  + "\nВерсия: " + PrInfo["Version"].ToString() + "\n" +
					"Путь: " + PrInfo["InstallLocation"] + "\n" +
					"Установлен: " + PrInfo["InstallDate"].ToString().Insert(4, ".").Insert(7,".") + "\n";
					infa = infa + str + strLine;
				}
				catch
				{
					str = "Ошибка чтения";
				}
			}
		}
		catch
		{
			infa = infa + "Ошибка чтения\n";
		}
			richTextBox1.Text = infa;
		}
		
		//***Контекстное меню***
		void КопироватьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.Copy();
		}
		
		void ВставитьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.Paste();
		}
		
		
		void ВырезатьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.Cut();
		}
		
		void УдалитьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectedText = string.Empty;
		}
		
		//Блокировка кнопок
		void TextBox1_TextChanged(object sender, EventArgs e)
		{
			button9.Enabled = false;
			button6.Enabled = false;
			button8.Enabled = false;
			button1.Enabled = false;
			button3.Enabled = false;
			button7.Enabled = false;
			button10.Enabled = false;
			button2.Enabled = false;
			button5.Enabled = false;
			button12.Enabled = false;
		}	
		

		//***Выход***
		void Button11_Click(object sender, EventArgs e)
		{	
			Close();
		}
		
		//*****Файл, сохранение*****
		void СохранитьВсеВОтчетToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "Текстовый документ (*.txt)|*.txt|Все файлы (*.*)|*.*";
			
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);
				button9.PerformClick();
				streamWriter.WriteLine(richTextBox1.Text, Encoding.GetEncoding("utf-8"));
				button6.PerformClick();
				streamWriter.WriteLine(richTextBox1.Text, Encoding.GetEncoding("utf-8"));
				button8.PerformClick();
				streamWriter.WriteLine(richTextBox1.Text, Encoding.GetEncoding("utf-8"));
				button1.PerformClick();
				streamWriter.WriteLine(richTextBox1.Text, Encoding.GetEncoding("utf-8"));
				button3.PerformClick();
				streamWriter.WriteLine(richTextBox1.Text, Encoding.GetEncoding("utf-8"));
				button7.PerformClick();
				streamWriter.WriteLine(richTextBox1.Text, Encoding.GetEncoding("utf-8"));
				button10.PerformClick();
				streamWriter.WriteLine(richTextBox1.Text);
				button2.PerformClick();
				streamWriter.WriteLine(richTextBox1.Text);
				button12.PerformClick();
				streamWriter.WriteLine(richTextBox1.Text);
				button5.PerformClick();
				streamWriter.WriteLine(richTextBox1.Text);
				streamWriter.Close();
				
				richTextBox1.Text = "Файл сохранен";
			}
		}
		
		void СохранитьОтчетToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "Текстовый документ (*.txt)|*.txt|Все файлы (*.*)|*.*";
			
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);
				streamWriter.WriteLine(richTextBox1.Text);
				streamWriter.Close();
			}
		}
		
		void ВыходToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Close();
		}
		//*******Прозвон сети********
		private void Button13_Click(object sender, EventArgs e)
		{
			Thread mythread = new Thread(stream);
			mythread.IsBackground = true;  //завершает поток при закрытии программы
			mythread.Start();
		}
		//Прозвон в отдельном потоке, чтобы форма не зависала
		private void stream()
		{
			button13.Text = "Выполняется...";
			int all = 0;
			int con  = 0;
			string Address = string.Empty;
			
			Process proc = new Process();
			proc.StartInfo.FileName = "cmd";
			proc.StartInfo.Arguments = "/C net view";
			proc.StartInfo.RedirectStandardOutput = true;
			proc.StartInfo.UseShellExecute = false;
			proc.StartInfo.CreateNoWindow = false;
			proc.Start();
			string data = proc.StandardOutput.ReadToEnd();
			int start = 0;
			int stop = 0;
			
			while (true)
			{
				start = data.IndexOf('\\', start);
				if (start == -1)
					break;
				stop = data.IndexOf(' ', start);
				Address = (data.Substring(start, stop - start));
				Address = Address.Substring(2);
				try
				{	//Проверка доступности класса ОС
					ManagementScope scope = new ManagementScope(string.Format("\\\\" + Address +"\\root\\cimv2"));
					ObjectQuery OSQuery = new System.Management.ObjectQuery("select * from Win32_OperatingSystem");
					ManagementObjectSearcher OSSearcher = new ManagementObjectSearcher(scope, OSQuery);					
					ManagementObjectCollection OSCollection = OSSearcher.Get();
					
					richTextBox1.Text = richTextBox1.Text + Address + "  Соединение установлено" + "\n";
					con++;
					RDform.GlobalVars.strArr[RDform.GlobalVars.i] = Address; //запись массива компьютеров с успешным соединением
					RDform.GlobalVars.i++;
				}
				catch
				{
					richTextBox1.Text = richTextBox1.Text + Address + "  Недоступно" + "\n";
				}
				
				start = stop;
				all++;
				label5.Text = "Всего в сети: " + all;
				label6.Text = "Доступно: " + con;				
			}
			button13.Text = "Прозвон сети";
		}
		//********Инвентаризация*********
		
		void RDform_Load(object sender, EventArgs e)
		{
			button4.PerformClick();
		}
		
		//инвентаризация
		void inv()
		{
			string invAll = richTextBox1.Text;
			string Address = string.Empty;
			Process proc = new Process();
			proc.StartInfo.FileName = "cmd";
			proc.StartInfo.Arguments = "/C net view";
			proc.StartInfo.RedirectStandardOutput = true;
			proc.StartInfo.UseShellExecute = false;
			proc.StartInfo.CreateNoWindow = false;
			proc.Start();
			string data = proc.StandardOutput.ReadToEnd();
			int i = 0;
			stream(); //вызов прозвона сети
			while (i<RDform.GlobalVars.i)
			{
				//инвентаризация компьютеров с успешным соединением
				textBox1.Text = RDform.GlobalVars.strArr[i];
				invAll = invAll + "\n*************" + RDform.GlobalVars.strArr[i] + "*************\n";
				i++;
				//разблокировка кнопок на каждой итерации
				button9.Enabled = true;
				button6.Enabled = true;
				button8.Enabled = true;
				button1.Enabled = true;
				button3.Enabled = true;
				button7.Enabled = true;
				button10.Enabled = true;
				button2.Enabled = true;
				button12.Enabled = true;
				button5.Enabled = true;				
				
				try //проверка условий сканирования с формы Inv
				{					
					if (RDform.GlobalVars.hard == true)
					{
						button9.PerformClick();
						invAll = invAll + "\nHARDWARE\n" +  richTextBox1.Text;
					}
					
					if (RDform.GlobalVars.soft == true)
					{
						button6.PerformClick();
						invAll = invAll + "\nSOFTWARE\n" + richTextBox1.Text;
					}
					
					if (RDform.GlobalVars.uch == true)
					{
						button8.PerformClick();
						invAll = invAll + "\nУЧЕТНЫЕ ЗАПИСИ\n" +richTextBox1.Text;
					}
					
					if (RDform.GlobalVars.net == true)
					{
						button1.PerformClick();
						invAll = invAll + "\nСЕТЕВЫЕ НАСТРОЙКИ\n" + richTextBox1.Text;
					}
					
					if (RDform.GlobalVars.proizv == true)
					{
						button3.PerformClick();
						invAll = invAll + "\nПРОИЗВОДИТЕЛЬНОСТЬ\n" + richTextBox1.Text;
					}

					if (RDform.GlobalVars.tem == true)
					{
						button7.PerformClick();
						invAll = invAll + "\nПРИНТЕРЫ\n" + richTextBox1.Text;
					}

					if (RDform.GlobalVars.ev == true)
					{
						button10.PerformClick();
						invAll = invAll + "\nОШИБКИ ИЗ ЖУРНАЛА СОБЫТИЙ\n" + richTextBox1.Text;
					}

					if (RDform.GlobalVars.process == true)
					{
						button2.PerformClick();
						invAll = invAll + "\nПРОЦЕССЫ\n" + richTextBox1.Text;
					}

					if (RDform.GlobalVars.service == true)
					{
						button12.PerformClick();
						invAll = invAll + "\nСЛУЖБЫ\n" + richTextBox1.Text;
					}

					if (RDform.GlobalVars.product == true)
					{
						button5.PerformClick();
						invAll = invAll + "\nУСТАНОВЛЕННЫЕ ПРОГРАММЫ\n" + richTextBox1.Text;
					}
				}
				catch
				{ 
					invAll = invAll + richTextBox1.Text + "\nОшибка чтения\n"; 
				}
				invAll = invAll + "\n///////////////////////////////////////////////////////////////////" +
								  "\n///////////////////////////////////////////////////////////////////\n";
				
			}
			//очистка переменных условий для возможности повторной инвентаризации в течение сеанса
			richTextBox1.Text = invAll;
			RDform.GlobalVars.i = 0;
			Array.Clear(RDform.GlobalVars.strArr, 0 , RDform.GlobalVars.strArr.Length);
			RDform.GlobalVars.inv = false;
			RDform.GlobalVars.hard = false;
			RDform.GlobalVars.soft = false;
			RDform.GlobalVars.uch = false;
			RDform.GlobalVars.net = false;
			RDform.GlobalVars.proizv = false;
			RDform.GlobalVars.tem = false;
			RDform.GlobalVars.ev = false;
			RDform.GlobalVars.process = false;
			RDform.GlobalVars.service = false;
			RDform.GlobalVars.product = false;
			MessageBox.Show("Операция завершена");			
		}
		
		//***Поиск по тексту***
		void Button14_Click(object sender, EventArgs e)
		{
			f(richTextBox1.SelectionStart + textBox5.Text.Length);
		}
		
		private void f(int i)
		{
			string s = richTextBox1.Text, s2 = textBox5.Text;
			s = s.ToLower();
			s2 = s2.ToLower();
			
			
			if (s.Contains(s2))
			{
				i = s.IndexOf(s2, i);
				if (i == -1)
					i = s.IndexOf(s2, 0);
				
				richTextBox1.Select(i, s2.Length);
				richTextBox1.Focus();
			}
		}	
		
		//***Дополнительно***
		void ОценкаПроизводительностиWindowsToolStripMenuItem_Click(object sender, EventArgs e)
		{				
			button3.PerformClick();	
		}
		
		//***Картинка рабочего стола***
		void WallpaperToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string IP = Convert.ToString(textBox1.Text);
			ManagementScope scope = new ManagementScope(string.Format("\\\\" + IP +"\\root\\cimv2"));
			ObjectQuery WalQuery = new System.Management.ObjectQuery("SELECT * FROM Win32_Desktop");
			ManagementObjectSearcher WalSearcher = new ManagementObjectSearcher(scope, WalQuery);
			ManagementObjectCollection WalCollection = WalSearcher.Get();
			
			foreach (ManagementObject WalInfo in WalCollection)
				{
					richTextBox1.Text = richTextBox1.Text + "\n" + WalInfo["Wallpaper"];
				}
		}
		
				//************Команды cmd**************
				
		//ping
		void PingToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ping form = new ping();
			form.Show();
		}
		
		//Точка доступа wi-fi
		void WifiToolStripMenuItem_Click(object sender, EventArgs e)
		{
			wifi form = new wifi();
			form.Show();
		}
		
		//Ассоциации типов с программами
		void AssocToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.Text = "Ассоциация типов с программами по умолчанию: \n";
			Process proc = new Process()
			{
				StartInfo = new ProcessStartInfo("cmd.exe", "/c assoc")
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
			
			while (!sr.EndOfStream) 
			{
				line = sr.ReadLine();
				richTextBox1.Invoke(new MethodInvoker(() => 
				{
				richTextBox1.Text += line + "\n";
				}), null);
			}
		}
		
		//netstat
		void NetstatToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.Text = "Netstat \n";
			Loading form = new Loading();
			form.Show();
			Process proc = new Process()
			{
				StartInfo = new ProcessStartInfo("cmd.exe", "/c netstat")
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
			
			while (!sr.EndOfStream) 
			{
				line = sr.ReadLine();
				richTextBox1.Invoke(new MethodInvoker(() => 
				{
				richTextBox1.Text += line + "\n";
				}), null);
			}
			Application.OpenForms["Loading"].Close();
		}
		
		//tracert
		void TracertToolStripMenuItem_Click(object sender, EventArgs e)
		{
			tracert form = new tracert();
			form.Show();
		}
		
		//pathping
		void PathpingToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Pathping form = new Pathping();
			form.Show();
		}
		
		//Автовыключение на удаленке
		void ShutdownдляУдаленкиToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Shutdown form = new Shutdown();
			form.Show();
		}
		
		//Net user domain
		void NetUserdomainToolStripMenuItem_Click(object sender, EventArgs e)
		{
			NetUser form = new NetUser();
			form.Show();
		}
		
		//Добавление WMI в исключение брандмауэра
		void НастройкаWMIToolStripMenuItem_Click(object sender, EventArgs e)
		{
			WMI form = new WMI();
			form.Show();
		}		
		
		//Net view
		void NetViewToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.Text = "Устройства в сети: \n";
			Process proc = new Process()
			{
				StartInfo = new ProcessStartInfo("cmd.exe", "/c net view")
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
				richTextBox1.Invoke(new MethodInvoker(() => 
				{
				richTextBox1.Text += line + "\n";
				}), null);
			}
		}
		
		void ShutdownToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form2 form = new Form2();
			form.Show();
		}
		
		//***Вызов формы инвентаризации***
		void Button15_Click(object sender, EventArgs e)
		{
			this.Visible = false;
			Inv form = new Inv();
			form.Show();			
		}		
		
		void RDform_VisibleChanged(object sender, EventArgs e)
		{
			//проверка на необходимость инвентаризации при загрузке
			if (RDform.GlobalVars.inv == true)
			{
				Thread mythread = new Thread(inv);
				mythread.Start();
				//разблокировка кнопок
				button9.Enabled = true;
				button6.Enabled = true;
				button8.Enabled = true;
				button1.Enabled = true;
				button3.Enabled = true;
				button7.Enabled = true;
				button10.Enabled = true;
				button2.Enabled = true;
				button12.Enabled = true;
				button5.Enabled = true;
			}
		}		
	}
}