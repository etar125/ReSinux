using System;
using System.Diagnostics;
using System.IO;
using System.Media;
using System.Threading;

namespace resinux
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.Title = "ReSinux";
			Console.ForegroundColor = ConsoleColor.DarkYellow;			
			Console.WriteLine("██████╗░███████╗░██████╗██╗███╗░░██╗██╗░░░██╗██╗░░██╗");
			Console.WriteLine("██╔══██╗██╔════╝██╔════╝██║████╗░██║██║░░░██║╚██╗██╔╝");
			Console.WriteLine("██████╔╝█████╗░░╚█████╗░██║██╔██╗██║██║░░░██║░╚███╔╝░");
			Console.WriteLine("██╔══██╗██╔══╝░░░╚═══██╗██║██║╚████║██║░░░██║░██╔██╗░");
			Console.WriteLine("██║░░██║███████╗██████╔╝██║██║░╚███║╚██████╔╝██╔╝╚██╗");
			Console.WriteLine("╚═╝░░╚═╝╚══════╝╚═════╝░╚═╝╚═╝░░╚══╝░╚═════╝░╚═╝░░╚═╝");
			Random rand = new Random();
			int timer = rand.Next(2500, 7000);
			Thread.Sleep(timer);
			Console.Clear();
			cmd();
		}
		
		public static void cmd()
		{
			Random randc = new Random();
			int nt;
			string com;
			com = Console.ReadLine();
			
			switch (com)
			{
				case "help":
					Console.WriteLine("cls - Очистка текста на экране\nsinfo - Информация о ReSinux\ntext - Вывод текста\nbmini - Мини версия Banshi\nvc - Создатель простого сообщения Windows\nexit - Выход из ReSinux\ngame - Запуск игры(Только .bat!)\nbatm - конструктор ос в бат");
					cmd();
					break;
				default:
					nt = randc.Next(1, 4);
					if (nt == 1)
					{
						Console.WriteLine("Not found command " + com);
					}
					if (nt == 2)
					{
						Console.WriteLine("I dont know command " + com);
					}
					if (nt == 3)
					{
						Console.WriteLine("Command " + com + " is not found");
					}
					cmd();
					break;
				case "cls":
					Console.Clear();
					cmd();
					break;
				case "sinfo":
					Console.WriteLine("Название: ReSinux\nВерсия: b4\nСоздатель: Varinosik");
					cmd();
					break;
				case "text":
					string tt;
					Console.Write("Text: "); tt = Console.ReadLine();
					Console.WriteLine(tt);
					cmd();
					break;
				case "bmini":
					Console.Title = "Banshi Mini"; Console.ForegroundColor = ConsoleColor.White; Console.Clear();
					bmini();
					break;
				case "vc":
					Console.Title = "VCreator Alpha"; Console.ForegroundColor = ConsoleColor.White; Console.Clear();
					vc();
					break;
				case "game":
					Console.Title = "Game Loader"; Console.ForegroundColor = ConsoleColor.White; Console.Clear();
					game();
					break;
				case "exit":
					
					break;
				case "beep":
					Console.Beep();
					cmd();
					break;
				case "batm":
					Console.Title = "BatOS Maker v1"; Console.ForegroundColor = ConsoleColor.White; Console.Clear();
					batm();
					break;
			}
		}
		
		public static void vc()
		{
			string text;
			string name;
			Console.Write("Text: "); text = Console.ReadLine();
			Console.Write("Name: "); name = Console.ReadLine();
			File.WriteAllText(name + ".vbs", "MsgBox\"" + text + "\",vbNone,\"" + name + "\"");
			Process.Start(name + ".vbs");
			Thread.Sleep(5000);
			File.Delete(name + ".vbs");
			Console.ReadKey();
			Console.Title = "ReSinux"; Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Clear();
			cmd();
		}
		
		public static void bmini()
		{
			string com1;
			Console.WriteLine("Banshi Mini\n1 - exit\n2 - BCL\n3 - Information\n4 - BCLR");
			com1 = Console.ReadLine();
			
			switch (com1)
			{
				case "1":
					Console.Title = "ReSinux"; Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Clear();
					cmd();
					break;
				case "2":
					Console.Title = "BCL - Banshi Command Line (Test)"; Console.ForegroundColor = ConsoleColor.Green; Console.Clear();
					bcl();
					break;
				default:
					bmini();
					break;
				case "3":
					Console.Clear(); Console.WriteLine("Version: ma9\nCreator: Varinosik"); Console.ReadKey();
					Console.Title = "Banshi Mini"; Console.ForegroundColor = ConsoleColor.White; Console.Clear();
					bmini();
					break;
				case "4":
					Console.Title = "BCLR - Banshi Command Line Reload (Test)"; Console.ForegroundColor = ConsoleColor.DarkGreen; Console.Clear();
					bclr();
					break;
			}
		}
		
		public static void bcl()
		{
			string com2;
			com2 = Console.ReadLine();
			
			switch (com2)
			{
				case "help":
					Console.WriteLine("exit , info , exitb , loadt");
					bcl();
					break;
				default:
					bcl();
					break;
				case "exit":
					Console.Title = "Banshi Mini"; Console.ForegroundColor = ConsoleColor.White; Console.Clear();
					bmini();
					break;
				case "info":
					Console.WriteLine("Name: Banshi\nVersion: ma9\nAuthor: LIW - Very old Version , J.G. - Old Version , F.G. - Normal version");
					bcl();
					break;
				case "exitb":
					Console.Title = "ReSinux"; Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Clear();
					cmd();
					break;
				case "loadt":
					Random rand1 = new Random();
					Thread.Sleep(rand1.Next(1000, 5000));
					Console.Write("A");
					Thread.Sleep(rand1.Next(1000, 7000));
					Console.Write("H");
					Thread.Sleep(rand1.Next(1000, 7000));
					Console.Write("D");
					Thread.Sleep(rand1.Next(1000, 7000));
					Console.Write("Y");
					Thread.Sleep(rand1.Next(1000, 7000));
					Console.Write("U");
					Thread.Sleep(rand1.Next(5000, 8000));
					Console.WriteLine("Load Test is finish");
					bcl();
					break;
			}
		}
		
		public static void bclr()
		{
			string com3;
			com3 = Console.ReadLine();
			
			switch (com3)
			{
				case "help":
					Console.WriteLine("exit , info , exitb , rc , sinux");
					bclr();
					break;
				default:
					bclr();
					break;
				case "exit":
					Console.Title = "Banshi Mini"; Console.ForegroundColor = ConsoleColor.White; Console.Clear();
					bmini();
					break;
				case "info":
					Console.WriteLine("Name: Banshi\nVersion: ma9\nAuthor: J.G. - Old Version , F.G. - Normal version");
					bclr();
					break;
				case "exitb":
					Console.Title = "ReSinux"; Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Clear();
					cmd();
					break;
				case "rc":
					Console.Clear();
					Console.WriteLine("Code restart...");
					Thread.Sleep(10000);
					Console.Title = "ReSinux"; Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Clear();
					Console.WriteLine("Code was reloaded by BCLR Administrator (OFFICIAL)");
					cmd();
					break;
				case "sinux":
					Console.Title = "Sinux"; Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Clear();
					Console.WriteLine("0000 0000 0000");
					Thread.Sleep(1500);
					Console.WriteLine("00b0 0000 0000");
					Thread.Sleep(1500);
					Console.WriteLine("0000 0000 0000");
					Thread.Sleep(1500);
					Console.WriteLine("0000 0000 n000");
					Thread.Sleep(1500);
					Console.WriteLine("1000 0000 0000");
					Thread.Sleep(1500);
					Console.WriteLine("0000 0000 0000");
					Thread.Sleep(1500);
					Console.WriteLine("0000 0000 0000");
					Thread.Sleep(1500);
					Console.WriteLine("000m 0000 0000");
					Thread.Sleep(1500);
					Console.WriteLine("0000 0000 0000");
					Thread.Sleep(1500);
					Console.WriteLine("5300 0000 0000");
					Thread.Sleep(1500);
					Console.WriteLine("0000 0000 0000");
					Thread.Sleep(1500);
					Console.WriteLine("0000 00b0 0000");
					Thread.Sleep(1500);
					Console.WriteLine("0000 0000 0000");
					Thread.Sleep(1500);
					Console.WriteLine("0000 0000 0000");
					Thread.Sleep(1500);
					Console.WriteLine("b000 0000 0000");
					Thread.Sleep(1500);
					Console.WriteLine("0000 0hh0 0000");
					Thread.Sleep(1500);
					Console.WriteLine("0000 0000 0000");
					Thread.Sleep(15000);
					break;
			}
		}
		
		public static void game()
		{
			string file;
			string game;
			Console.WriteLine("E.g  - game.txt");
			Console.Write("File:"); file = Console.ReadLine();
			
			game = File.ReadAllText(file);
			File.WriteAllText("game.bat", game);
			Process.Start("game.bat");
			Console.Title = "ReSinux"; Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Clear();
			cmd();
		}
		
		public static void batm()
		{
			Random randik = new Random();
			int itme = randik.Next(1000, 5000);
			string os; string ver; string des;
			Console.Write("System name: "); os = Console.ReadLine();
			Console.Write("System version: "); ver = Console.ReadLine();
			Console.Write("System info: "); des = Console.ReadLine();
			Console.Clear(); Console.WriteLine("Creating..."); Thread.Sleep(itme); File.WriteAllText("os.bat", "@echo off\ntitle " + os + "\n:x\ncls\necho info   exit\nset /p ch=\">>\"\nif not defined ch goto x\nif %ch%==info goto i\nif %ch%==exit exit\n:i\ncls\necho System:" + os + "\necho Version: " + ver + "\necho Info: " + des + "\npause\ngoto x");
			Process.Start("os.bat");
			Console.Clear(); Console.WriteLine("Os is create!"); Console.ReadKey();
			Console.Title = "ReSinux"; Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Clear();
			cmd();
		}
	}
}