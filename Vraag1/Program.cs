using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vraag1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double bedrag;
            const double korting = 5;
            const int topAmount = 5000;
            double[] factuures = new double[4];

            for(int i = 0; i < factuures.Length; i++) 
            {
                Console.WriteLine($"Enter facture amount: ");
                bedrag = Double.Parse( Console.ReadLine() );
                factuures[i] = bedrag; 
                if(bedrag > topAmount)
                {
                    bedrag -= (factuures[i] * korting)/100;
                    factuures[i] = bedrag;
                }
            }
            foreach( double f in factuures ) 
            {
                Console.WriteLine(f);            
            }

        }
    }
    /*Lees een bedrag in van een factuur.
    Indien het bedrag groter is dan 5000 euro, dan wordt er een korting van 5% toegestaan.
    Toon het uiteindelijke resultaat.*/
}
