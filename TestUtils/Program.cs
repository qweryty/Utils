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
			Console.WriteLine (UsefulUtils.Abs(a));
			char c;
			UsefulUtils.Input (out c, "Введите букву: ");
			Console.WriteLine (a);
		}

		public static void Main ()
		{
			UsefulUtils.Repeate (Solve);
		}
	}
}
