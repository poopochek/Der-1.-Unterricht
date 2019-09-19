using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    { 
        static void Main(string[] args)
        {
            string message = "Hello World!";
            int ganzeZahl = 16557;
            double gleitkommaZahl = 168.246;
            char Zeichen = 'J';
            bool wahrheitswert = true;

            Console.WriteLine(message+Environment.NewLine+ganzeZahl);
            //Console.WriteLine(ganzeZahl);
            //Console.WriteLine(gleitkommaZahl);
            //Console.WriteLine(Zeichen);
            //Console.WriteLine(wahrheitswert);


            //(for(int i=1; i<=10; i++)
            //{
            //   Console.Write(i+" ");
            //}
            int zahl1;
            int zahl2;
            int produkt;
            Console.WriteLine("Eine ganze Zahl eingeben:");
            zahl1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Noch eine ganze Zahl eingeben:");
            zahl2 = Convert.ToInt32(Console.ReadLine());
            produkt = zahl1 * zahl2;
            Console.WriteLine("Der Produkt ist: " + produkt);


        }
    }
}
