using System;

namespace Utils
{
	public class UsefulUtils
	{
		public static readonly double PI = 3.1415926535;

		public delegate void Solve();

		public static void Repeate(Solve method, 
			String exit = "Нажмите ESC для завершения или любую другую клавишу для продолжения"){
				ConsoleKeyInfo myinf;
				do {
					method ();
					Console.WriteLine (exit);
					myinf = Console.ReadKey (true);
				} while(myinf.Key != ConsoleKey.Escape);
		}

		public static void Input<T>(out T variable, string text = "Введите число: ", Func<T, bool> condition = null){
			condition = condition ?? (x => true);
			while (true) {
				try{
					Console.Write(text);
					string str = Console.ReadLine();
					variable = (T)Convert.ChangeType(str, typeof(T));
					if(condition(variable)){
						break;
					} else {
						Console.WriteLine("Введены некорректные данные.");
					}
				} catch(FormatException){
					Console.WriteLine ("Ошибка ввода.");
				}
			}
		}

		public static uint Fact(uint n){
			uint r = 1;
			for (uint i = 1; i <= n; ++i) {
				r *= i;
			}
			return r;
		}

		public static double Pow(double n, int p){
			if (p >= 0) {
				double a = 1;

				double currentPower = n;

				while(p != 0) {
					if(p % 2 == 1)
						a *= currentPower;

					p /= 2;
					currentPower *= currentPower;
				}

				return a;
			} else {
				return 1 / Pow (n, -p);
			}
		}

		public static T Abs<T>(T variable){
			dynamic temp = variable;
			if(temp < 0) return -temp;
			return temp;
		}
	}
}

