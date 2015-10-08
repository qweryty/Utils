// Дисциплина: "Программирование"
// Группа: БПИ151(2)
// Студент: Морозов Сергей Алексеевич
// Задача:
// Дата: 29.09.2015

using System;
using Utils;

namespace TestUtils
{
	class MainClass
	{
		public static void Solve (){
			//UselessUtils.Matrix ();
			Console.WriteLine ("Hello World!");

			int a;
			UsefulUtils.Input (out a, condition: (x => x < 10));

			Console.WriteLine ("Модуль числа: " + UsefulUtils.Abs(a));

			Console.Write("Степени числа от -5 до 10: ");
			for (int i = -5; i <= 10; i++)
				Console.Write(UsefulUtils.Pow(a, i) + " ");
			Console.WriteLine();

			char c;
			UsefulUtils.Input (out c, "Введите букву: ");
			Console.WriteLine (c);
		}

		public static void Main ()
		{
			UsefulUtils.Repeate (Solve);
		}
	}
}
