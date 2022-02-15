using System;

namespace LoginValidation
{
	class Program
	{
		static void Main(string[] args)
		{
			//programm küsib kasutajal sisestada tunnus ja salasõna
			// kui on "admin" ja salasõnad "admin1234"
			//siis kuvame konsoolis tere tulemast
			//kui ei ole siis konsoolis kuvatakse "vale kasutajatunnus või salasõna. Proovi uuesti!"
			//kasutajal kolm katset

			int i = 0;

			while (i < 3)
			{

				Console.WriteLine("Sisesta kasutajatunnus");
				string userName = Console.ReadLine();
				Console.WriteLine("Sisesta salasõna");
				string userPassword = Console.ReadLine();


				//AND
				//"admin" AND ja "admin1234" on true
				// muidu on false
				//kui parool on vale, siis samuti false



				if (userName == "admin" && userPassword == "admin1234")
				{
					Console.WriteLine("Tere tulemast!");
					break;
				}
				else
				{
					i++;
					Console.WriteLine($"Vale kasutajatunnus või salasõna. {3 - i} katset on jäänud.");
				}

			}
		}
	}
}
