using System;

namespace DiceGame
{
	class Program
	{
		static void Main(string[] args)
		{
			//Mängus osaleb kaks mängijat arvuti ning kasutaja cpu n user
			//mõlemad viskavad täringuid 
			//programm kontrollib kumba suurema summa
			//kes võidab
			//*täringuid visatakse kolm korda
			//programm kuulutab võitja


			Random rnd = new Random();

			int i = 0;

			while (i < 3)
			{
				//arvuti vise
				int cpuRandom = rnd.Next(1, 7);

				//mängija vise
				int userRandom = rnd.Next(1, 7);


				int cpuScore = 0;
				int userScore = 0;



				Console.WriteLine($"Arvuti viskas {cpuRandom}. Kasutaja viskas {userRandom}.");

				if (cpuRandom < userRandom)
				{
					Console.WriteLine("Kasutaja võitis!");
					userScore = userScore + 1;
					break;
				}
				else if (cpuRandom > userRandom)
				{
					Console.WriteLine("Arvuti võitis!");
					cpuScore = cpuScore + 1;
				}

				else
				{
					Console.WriteLine("Viik!");
				}
			}
		}
	}
}
