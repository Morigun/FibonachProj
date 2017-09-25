/*
 * Сделано в SharpDevelop.
 * Пользователь: suvoroda
 * Дата: 06/16/2015
 * Время: 12:52
 */
using System;

namespace FibonachProj
{
	/// <summary>
	/// Класс для создания ряда фибоначи
	/// </summary>
	public class FibonachiRaid
	{
		#region constructors
		/// <summary>
		/// Конструктор по умолчанию до 5
		/// </summary>
		public FibonachiRaid()
		{
			this.EndVal = 5;
			this.Riad = new int[this.EndVal];
			this.SetZero();
			this.CalcRiad();
		}
		/// <summary>
		/// Конструктор массива чисел фибоначи
		/// </summary>
		/// <param name="r">Количество чисел</param>
		public FibonachiRaid(int r)
		{
			this.EndVal = r;
			this.Riad = new int[this.EndVal];
			this.SetZero();
			this.CalcRiad();
		}
		#endregion
		#region private param
		/// <summary>
		/// Максимальный элемент
		/// </summary>
		private int _endVal;
		/// <summary>
		/// Массив
		/// </summary>
		private int[] _riad;
		#endregion
		#region public field
		/// <summary>
		/// Максимальный элемент
		/// </summary>
		public int EndVal
		{
			get { return this._endVal; }
			set { this._endVal = value; }
		}
		/// <summary>
		/// Массив
		/// </summary>
		public int[] Riad
		{
			get { return this._riad; }
			set { this._riad = value; }
		}
		#endregion
		#region private procedure
		/// <summary>
		/// Заполнение массива 0
		/// </summary>
		void SetZero()
		{
			for(int x = 0; x < this.EndVal; x++)
				this.Riad[x] = 0;
		}
		/// <summary>
		/// Заполнение массива рядом фибоначи
		/// </summary>
		void CalcRiad()
		{
			for(int x = 0; x < this.EndVal; x++)
				if (x != 0 && x != 1)
					this.Riad[x] = this.Riad[x-2] + this.Riad[x-1];
				else
					this.Riad[x] = x;
		}
		#endregion
		#region public procedure
		/// <summary>
		/// Печать ряда фибоначи
		/// </summary>
		public void Print()
		{
			for(int x = 0; x < this.EndVal; x++)
				Console.Write(this.Riad[x] + " ");
		}
		#endregion
	}
}
