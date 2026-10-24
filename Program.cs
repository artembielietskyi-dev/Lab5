
using System;

namespace Lab05
{
	internal class Program
	{
		static void Main(string[] args)
		{
			
			Console.OutputEncoding = System.Text.Encoding.UTF8;

			// ===== РІВЕНЬ А. Сума ряду 1 + 1/2 + 1/3 + ... + 1/n =====
			Console.Write("Введіть натуральне n: ");
			int n;
			if (!int.TryParse(Console.ReadLine(), out n))
			{
				Console.WriteLine("Помилка: потрібно ввести ціле число.");
				return;
			}

			double sum = 0;       // накопичувач суми
			int exceedTerm = 0;   // номер доданка, після якого сума > 3 (0 = ще ні)

			// Версія 1: цикл for
			for (int i = 1; i <= n; i++)
			{
				sum += 1.0 / i;   // 1.0, щоб ділення не було цілим

				if (i % 5 == 0) { Console.WriteLine($"Крок {i}: проміжна сума = {sum:F4}"); }
				if (sum > 3 && exceedTerm == 0) { exceedTerm = i; }
			}

			if (n < 1)
			{
				Console.WriteLine("Цикл не виконувався: n має бути натуральним.");
			}
			else
			{
				Console.WriteLine($"Сума ряду (for): {sum:F4}");
				if (exceedTerm == 0) { Console.WriteLine("Сума не перевищила 3."); }
				else { Console.WriteLine($"Сума перевищила 3 після доданка 1/{exceedTerm}."); }
			}

			// Версія 2: той самий цикл через while
			sum = 0;
			exceedTerm = 0;
			int k = 1;

			while (k <= n)
			{
				sum += 1.0 / k;

				if (k % 5 == 0) { Console.WriteLine($"Крок {k}: проміжна сума = {sum:F4}"); }
				if (sum > 3 && exceedTerm == 0) { exceedTerm = k; }

				k++;              // крок циклу: без нього цикл був би нескінченним
			}

			if (n >= 1)
			{
				Console.WriteLine($"Сума ряду (while): {sum:F4}");
			}
		}
	}
}
