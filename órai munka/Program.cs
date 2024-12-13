using System;
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
			F01();
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
	}
}
