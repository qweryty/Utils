// Дисциплина: "Программирование"
// Группа: БПИ151(2)
// Студент: Морозов Сергей Алексеевич
// Задача:
// Дата: 06.10.2015
using System;

namespace Utils
{
	public class UselessUtils
	{
		public static void Matrix(){
			Random r = new Random();
			const int NumberOfLines = 50;
			const int MaxLength = 10;
			const int MinLength = 3;
			int[] x = new int[NumberOfLines];
			int[] y = new int[NumberOfLines];
			int[] l = new int[NumberOfLines];
			Console.BackgroundColor = ConsoleColor.Black;
			Console.ForegroundColor = ConsoleColor.Green;
			Console.CursorVisible = false;
			for (int i = 0; i < Console.WindowHeight - 1; ++i) {
				for (int j = 0; j < Console.WindowWidth; ++j) {
					Console.Write (' ');
				}
				Console.WriteLine ();
			}
			for (int j = 0; j < Console.WindowWidth; ++j) {
				Console.Write (' ');
			}
			for (int i = 0; i < NumberOfLines; ++i) {
				x [i] = r.Next (0, Console.WindowWidth);
				l [i] = r.Next (MinLength, MaxLength);
				y [i] = -l[i] - r.Next(0, 30);
			}
			while (true) {
				System.Threading.Thread.Sleep(100);
				for (int i = 0; i < NumberOfLines; ++i) {
					if (y [i] >= 0) {
						Console.SetCursorPosition(x[i], y[i]);
						Console.Write (' ');
					}
					++y [i];
					if (y [i] == Console.WindowHeight) {
						x [i] = r.Next (0, Console.WindowWidth);
						l [i] = r.Next (MinLength, MaxLength);
						y [i] = -l[i];
					}
					for(int j = y[i]; j < y[i] + l[i]; ++j){
						if ((j >= 0) && (j < Console.WindowHeight)) {
							Console.SetCursorPosition(x[i], j);
							Console.Write((char)r.Next(33, 127));
						}
					}
				}
			}
		}
	}
}

