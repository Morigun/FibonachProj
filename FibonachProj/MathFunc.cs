/*
 * Сделано в SharpDevelop.
 * Пользователь: suvoroda
 * Дата: 06/16/2015
 * Время: 16:09
 */
using System;

namespace FibonachProj
{
	/// <summary>
	/// Класс с математическими функциями
	/// </summary>
	public class MathFunc
	{
		public MathFunc()
		{
		}
		#region math function
		/// <summary>
		/// Вычисляет наибольшее простое число из массива int
		/// </summary>
		/// <param name="mas">Массив чисел int</param>
		/// <returns>Наибольшее простое число</returns>
		public static int CalcMaxSimpleDigit(int[] mas)
		{
			int simple = 0;
			bool bSimple = true;
			foreach(int i in mas)
			{
				bSimple = true;
				if(i != 0)
				{
					for(int x = 1; x <= i; x++)
					{
						if(i%x == 0 && x != i && x != 1)
						{
							bSimple = false;
							break;
						}
					}
					if(bSimple)
						simple = i;
				}
			}
			return simple;
		}
		/// <summary>
		/// Вычисляет наименьшее простое число из массива int
		/// </summary>
		/// <param name="mas">Массив</param>
		/// <returns>Наименьшее простое число</returns>
		public static int CalcMinSimpleDigit(int[] mas)
		{
			int simple = 0;
			bool bSimple = true;
			foreach(int i in mas)
			{
				bSimple = true;
				if(i != 0)
				{
					for(int x = 1; x <= i; x++)
					{
						if(i%x == 0 && x != i && x != 1)
						{
							bSimple = false;
							break;
						}
					}
					if(bSimple)
					{						
						simple = i;
						break;
					}
				}
			}
			return simple;
		}
		#endregion
	}
}
