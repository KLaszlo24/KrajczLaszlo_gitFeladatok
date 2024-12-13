using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace órai_munka
{
	internal class Program
	{

		static Random rnd = new Random();
		static void Main(string[] args)
		{


			

		}

		static void F01(int[] tomb)
		{
            Console.WriteLine("Első feladat: ");

            Console.WriteLine("Változtatott számok: ");
            for (int i = 0; i < tomb.Length; i++)
			{
				int random = rnd.Next(0,55);
				tomb[i] += random;
				Console.Write(tomb[i] + ",");
            }
        }

		static int F02(int[] tomb)
		{
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Második feladat:");
			int szamlalo=0;
			for (int i = 0;i < tomb.Length; i++)
			{
				if (tomb[i] %2 == 0)
				{
					szamlalo++;
				}
			}
			return szamlalo;
		}
		
		
		static double F03(int[] tomb)
		{
            Console.WriteLine();
            Console.WriteLine("Harmadik feladat:");
			double atlag = 0;
			for (int i = 0;i < tomb.Length; i++)
			{
				atlag += tomb[i];
			}
			atlag /= tomb.Length;
			return atlag;
		}



		static int[] F04(int[] tomb)
		{
            Console.WriteLine();
            Console.WriteLine("Negyedik feladat:");
            int[] paratlanok=new int[tomb.Length];
			for (int i = 0;i<tomb.Length ; i++)
			{
				
					if (tomb[i] % 2 == 0)
					{
						paratlanok[i] += tomb[i]+1;
					}
					else
					{
						paratlanok[i]+=tomb[i];
					}
				}
			return paratlanok;
		}



		static void F05(int[] tomb)
		{
			Console.WriteLine("Ennyi db pozití egész szám van a tömbben: " + F02(tomb));
			Console.WriteLine("Ennyi az átlag: " + F03(tomb));
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("A tömbből alkotott páratlan számok: ");
			int[] paratlanok = F04(tomb);
			foreach (int szam in paratlanok)
			{
				Console.Write(szam + ", ");
			}
        }
	}

}
