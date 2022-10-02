using System;

namespace homework2
{
	class Program
	{
		static bool CheckNumber(string s) //Функция для проверки строки на содержание символов(для преобразования в число)
		{
			foreach (char item in s) //Цикл для поочередного обращения к элементам строки
			{
				if (item != ',')
				{
					if (char.IsDigit(item) == false) // IsDigit функция определяет относится ли символ к категории чисел
					{
						return true;
					}
				}
			}
			return false;
		}
		static double chast1(double x)
		{
			double y = -3.5;
			return y;
		}
		static double chast2(double x)
		{
			double y = y = 0.6*x + 1.7999999999999998;
			return y;
		}
		static double chast3(double x, double R)
		{
			double y = -Math.Sqrt(Math.Pow(R,2)-Math.Pow(x, 2));
			return y;
		}
		static double chast4(double x)
		{
			double y = x - 3;
			return y;
		}
		static double chast5(double x)
		{
			double y = 3;
			return y;
		}
		static void Main(string[] args)
		{
			Console.Write("Введите радиус: ");
			string r = Console.ReadLine();
			while (CheckNumber(r))
			{
				Console.Write("\nОшибка. Введите число: ");
				r = Console.ReadLine();
			}
			Console.Write("\n");
			double R = Convert.ToDouble(r);

			for (double x = -10; x <= 8; x += 0.2)
			{
				x = Math.Round(x, 2);
				if (x >= -10 && x < -8)
				{
					Console.WriteLine("y({0:0.00})={1:0.00}", x, chast1(x));
					
				}
				else if (x >= -8 && x < -3)
				{
					Console.WriteLine("y({0:0.00}) = {1:0.00}", x, chast2(x));
				}
				else if (x >= -3 && x < 3)
				{
					if (Convert.ToString(chast3(x, R)) == "не число")
					{
						Console.Write("y({0:0.00}) = Функция не определена\n", x);
					}
					else
					{
						Console.WriteLine("y({0:0.00}) = {1:0.00}", x, chast3(x, R));
					}
				}
				else if (x >= 3 && x <= 5)
				{
					Console.WriteLine("y({0:0.00}) = {1:0.00}", x, chast4(x));
				}
				if (x >= 5 && x <= 8)
				{
					Console.WriteLine("y({0:0.00}) = {1:0.00}", x, chast5(x));
				}
			}
			Console.WriteLine("Начало бесконечного цикла:\n");
			double i = 0;
			while(i<10) 
			{
				Console.Write("Введите x: ");
				double x;

				while (!double.TryParse(Console.ReadLine(), out x))
				{
					Console.WriteLine(" Ошибка. Введите число.");
					Console.Write("Введите x: ");
				}
				if(x < -10 || x > 8)
                {
					Console.WriteLine("Ошибка! X не входит в ОДЗ. ");
                }
				if (x >= -10 && x < -8)
				{
					Console.WriteLine("y({0:0.00})={1:0.00}", x, chast1(x));

				}
				else if (x >= -8 && x < -3)
				{
					Console.WriteLine("y({0:0.00}) = {1:0.00}", x, chast2(x));
				}
				else if (x >= -3 && x < 3)
				{
					if (Convert.ToString(chast3(x, R)) == "не число")
					{
						Console.Write("y({0:0.00}) = Функция не определена\n", x);
					}
					else
					{
						Console.WriteLine("y({0:0.00}) = {1:0.00}", x, chast3(x, R));
					}
				}
				else if (x >= 3 && x <= 5)
				{
					Console.WriteLine("y({0:0.00}) = {1:0.00}", x, chast4(x));
				}
				if (x >= 5 && x <= 8)
				{
					Console.WriteLine("y({0:0.00}) = {1:0.00}", x, chast5(x));
				}
			}
			
		}
	}
}