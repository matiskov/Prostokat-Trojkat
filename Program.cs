using System;

namespace Prostokat_Trojkat
{
	class Program
	{
		static void Main(string[] args)
		{
			while (true)
			{
				
				Console.WriteLine("Wpisz 1. aby narysować trójkąt, wpisz 2. aby narysować prostokąt, wpisz 3. by wyjść");
				bool test = int.TryParse(Console.ReadLine(), out int option);
				while (!test && option != 1 && option != 2 && option != 3)
				{
					Console.WriteLine("Nie podałeś prawidłowej opcji, wybierz 1, 2 lub 3");
					
				}
				switch (option)
				{
					case 1:
						Console.WriteLine("Podaj wysokość trójkąta");
						test = int.TryParse(Console.ReadLine(), out int high);
						while (!test)
						{
							Console.WriteLine("Podałeś niepoprawną wartość. Podaj liczbę naturalną");

						}
						for (int i = 0; i < 2*high; i=i+2)
						{
							
							for (int x = 0; x <= 2*high - i; x=x+2)
							{
								//Console.WriteLine(x);
								Console.Write(" ");
							}
							for (int x = high; x >= high - i; x--)
							{
								
								Console.Write("*");
							}
							Console.WriteLine("");
						}
						break;
					case 2:
						Console.WriteLine("Podaj wysokość prostokąta");
						bool test2 = int.TryParse(Console.ReadLine(), out int highP);
						while (!test2)
						{
							Console.WriteLine("Podałeś niepoprawną wartość. Podaj liczbę naturalną");

						}
						Console.WriteLine("Podaj szerokość prostokąta");
						bool test3 = int.TryParse(Console.ReadLine(), out int widthP);
						while (!test3)
						{
							Console.WriteLine("Podałeś niepoprawną wartość. Podaj liczbę naturalną");

						}
						

						for (int i = 0; i <= highP; i++)
						{

							for (int x = 0; x <= widthP; x++)
							{
								//Console.WriteLine(x);
								Console.Write("*");
							}

							Console.WriteLine("");
						}
						break;
				}
				if (option == 3) break;
			}
			Console.WriteLine("Naciśnij dowolny klawisz, aby wyjść");
			Console.ReadKey();
		}
	}
}
