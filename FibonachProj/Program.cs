/*
 * Сделано в SharpDevelop.
 * Пользователь: suvoroda
 * Дата: 06/16/2015
 * Время: 12:40
 */
using System;

namespace FibonachProj
{
	class Program
	{
		public static void Main(string[] args)
		{			
			// TODO: Implement Functionality Here
			int i;
			Console.WriteLine("Введите число");
			if(int.TryParse(Console.ReadLine(),out i))
			{
				if(i<47)
				{
					fr = new FibonachiRaid(i);
					fr.Print();
					Console.WriteLine();
					Console.WriteLine("Наибольшее простое число {0} Наименьшее простое число {1}", MathFunc.CalcMaxSimpleDigit(fr.Riad), MathFunc.CalcMinSimpleDigit(fr.Riad));
				}
				else
					Console.WriteLine("Не обрабатывает числа больше 46");
			}
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		static FibonachiRaid fr;
	}
}