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
				int option = 0;
		
				while (!int.TryParse(Console.ReadLine(), out option) && option != 1 && option != 2 && option != 3)
				{
					Console.WriteLine("Nie podałeś prawidłowej opcji, wybierz 1, 2 lub 3");
					
				}
				switch (option)
				{
					case 1:
						Console.WriteLine("Podaj wysokość trójkąta");
						int high = 0;
						while (!int.TryParse(Console.ReadLine(), out high))
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
						int highP, widthP;
						while (!int.TryParse(Console.ReadLine(), out  highP))
						{
							Console.WriteLine("Podałeś niepoprawną wartość. Podaj liczbę naturalną");

						}
						Console.WriteLine("Podaj szerokość prostokąta");
						
						while (!int.TryParse(Console.ReadLine(), out  widthP))
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
