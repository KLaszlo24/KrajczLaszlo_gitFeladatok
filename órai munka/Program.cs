﻿using System;
using System.Collections.Generic;
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
			int[] szamok = { 12, 14, 15, 20, 45, 88, 98, 35 };

			F01();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Ennyi páros szám van: " + F02(szamok));

			double[] szamok2 = { 2.4, 4.5, 6.7, 4.8, 6.6 };
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine("Az átlag: " + F03(szamok2));
		}

		static void F01()
		{
			
			int[] szam = new int[20];
            Console.WriteLine("Változtatott számok: ");
            for (int i = 0; i < szam.Length; i++)
			{
				int random = rnd.Next(0,55);
				szam[i] += random;
				Console.Write(szam[i] + ",");
            }
        }

		static int F02(int[] tomb2)
		{
			Console.WriteLine("Második feladat:");
			int szamlalo=0;
			for (int i = 0;i < tomb2.Length; i++)
			{
				if (tomb2[i] %2 == 0)
				{
					szamlalo++;
				}
			}
			return szamlalo;
		}
		
		
		static double F03(double[] tomb3)
		{
			Console.WriteLine("Harmadik feladat:");
			double atlag = 0;
			for (int i = 0;i < tomb3.Length; i++)
			{
				atlag += tomb3[i];
			}
			atlag /= tomb3.Length;
			return atlag;
		}
	}

}
