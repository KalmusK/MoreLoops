using System;

namespace OROperator
{
	class Program
	{
		static void Main(string[] args)
		{
			//programm küsib kasutajal sisestada tunnus ja salasõna
			// kui on "admin" ja salasõnad "admin1234"
			//siis kuvame konsoolis tere tulemast
			//kui ei ole siis konsoolis kuvatakse "vale kasutajatunnus või salasõna. Proovi uuesti!"

			//OR või pipes

			//true II true --> true
			//false II true --> true ikka true kui 1 on olemas
			//false II false --> false

			Console.WriteLine("Sisesta kasutajatunnus");
			string userName = Console.ReadLine();
			Console.WriteLine("Sisesta salasõna");
			string userPassword = Console.ReadLine();


			if (userName != "admin" || userPassword != "admin1234")
			{
				Console.WriteLine("Vale kasutajatunnus või salasõna. Proovi uuesti!");
			}
			else
			{
				Console.WriteLine("Tere tulemast!");
			}



		}
	}
}
