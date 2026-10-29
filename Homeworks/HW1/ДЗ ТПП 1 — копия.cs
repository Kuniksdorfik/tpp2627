using System;
using System.Collections.Generic;

class Program
{
	static void ShowBalance(decimal balance, string val = "P")
	{
		 Console.WriteLine($"Баланс: {balance} {val}");
	}
		
    static void Plata(ref decimal balance, List<string> history)
	{
		Console.WriteLine("Сумма пополнения: ");
			decimal summ = decimal.Parse(Console.ReadLine());
			balance += summ;
			history.Add($"Пополнение:  + {summ}");
	}

	static void Trata(ref decimal balance, List<string> history)
	{
		Console.WriteLine("Сумма снятия: ");
		decimal summ = decimal.Parse(Console.ReadLine());
		balance -= summ;
		history.Add($"Снятие:  -{summ}");
	}

	static void Showhistory(List<string> history)
	{
		for (int i = 0; i < history.Count; i++)
		{
			Console.WriteLine(history[i]);
		}
	}
	
	
	
	static void Main()
	{
		Console.WriteLine("Введите начальный балланс: ");
		decimal balance = decimal.Parse(Console.ReadLine());

		var history = new List<string>();

		while(true)
		{
			Console.WriteLine("1 - Показать баланс");
			Console.WriteLine("2 - Пополнить счёт");
			Console.WriteLine("3 - Снять деньги");
			Console.WriteLine("4 - Показать историю операций");
			Console.WriteLine("0 - Выйти");

			string choice = Console.ReadLine();

			if(choice == "1")
			{
				 ShowBalance(balance);
			}
			else if(choice == "2")
			{
				  Plata(ref balance, history);
			}
			else if(choice == "3")
			{
				 Trata(ref balance, history);
			}
			else if(choice == "4")
			{
				 Showhistory(history);
			}
			else if(choice == 0)
			{
				break;
			}
		}
	}
}