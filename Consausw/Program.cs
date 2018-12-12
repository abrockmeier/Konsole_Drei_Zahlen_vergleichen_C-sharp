using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consausw
{
	class Program
	{
		static void Main(string[] args)
		{
			// --> VARIABLEN
			int zahl1 = 0, zahl2 = 0, zahl3 = 0;
			//double zahl3 = 2.5;
			string eingabe;

			// --> EINGABE
			Console.WriteLine("Bitte eine Zahl eingeben:");
			eingabe = Console.ReadLine();
			//zahl1 = Convert.ToInt32(eingabe);
			if (int.TryParse(eingabe, out zahl1))
			{
				Console.WriteLine("Die erste Zahl ist: " + zahl1, Environment.NewLine);
				
				Console.WriteLine("Bitte zweite Zahl eingeben:");
				eingabe = Console.ReadLine();
				if (int.TryParse(eingabe, out zahl2))
				{
					Console.WriteLine("Die zweite Zahl" +
					" ist: " + zahl2, Environment.NewLine);
					
					// --> Verarbeitung
					
					//dritte Zahl
					Console.WriteLine("Bitte dritte Zahl eingeben:");
					eingabe = Console.ReadLine();
					if (int.TryParse(eingabe, out zahl3))
					{
						Console.WriteLine("Die dritte Zahl" +
						" ist: " + zahl3, Environment.NewLine);
						Console.WriteLine("----------------------------------------" +
						"----------");
						
						// --> Verarbeitung

			if ((zahl3 > zahl2) && (zahl3 > zahl1))
			{
				Console.WriteLine("Zahl 3 mit Wert {0} ist MaximumC.", zahl3);
				if (zahl2 > zahl1)
				{
					Console.WriteLine("Zahl 1 mit Wert {0} ist MinimumA.", zahl1);
				}
				else
				{
				Console.WriteLine("Zahl 2 mit Wert {0} ist MinimumB.", zahl2);
				}
			}
			else if ((zahl2 > zahl3) && (zahl3 > zahl1))
			{
				Console.WriteLine("Zahl 2 mit Wert {0} ist MaximumD.", zahl2);
				Console.WriteLine("Zahl 1 mit Wert {0} ist MinimumE.", zahl1);
			}
			else
			{
				Console.WriteLine("Zahl 1 mit Wert {0} ist MaximumF.", zahl1);
				if (zahl2 > zahl3)
				{
					Console.WriteLine("Zahl 3 mit Wert {0} ist MinimumG.", zahl3);
				}
				else
				{
					Console.WriteLine("Zahl 2 mit Wert {0} ist MinimumH.", zahl2);
				}
			}
					}
					else Console.WriteLine("bitte eine gültige 3.Zahl eingeben!!!");	
				}
				else Console.WriteLine("bitte eine gültige 2.Zahl eingeben!!!");	
			}
			else Console.WriteLine("bitte eine gültige 1.Zahl eingeben!!!");
			
			Console.WriteLine("--------------------------------------------------");    
			Console.ReadKey();
			// --> AUSGABE (hier oben direkt erfolgt...)
		}
	}
}
