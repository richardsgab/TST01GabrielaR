using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Vraag4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nummers = { 10, 20, 13, 20, 7 };
            int num = 0;
            int aux = 0;
            

            //Het som
            for (int i = 0; i < nummers.Length; i++)
            {
                nummers[i] += num;
                num = nummers[i];
            }
            /*Console.WriteLine(num);*/


            //Het grootste

            for (int i = 0; i < nummers.Length; i++)
            {
                if (nummers[i] > aux)
                {
                    aux = nummers[i];
                    if (nummers[i] > nummers[i + 1])
                    {
                        aux = nummers[i];
                    }
                }
                else
                {
                    continue;
                }
                Console.WriteLine($"{i}  {aux}");
            }
            


        }
    }
    /*Maak een array genaamd nummers en initialiseren deze met vijf willekeurige
    gehele getallen tussen 1 en 100. 
    Schrijf code om de som van alle getallen in de nummers array te berekenen
    en druk deze som af op het scherm.    
    Vind het grootste getal in de nummers array en druk dit af.
    Pas uw code aan om ook de index van het grootste getal in de nummers array 
    af te drukken.Let op: als het grootste getal meer dan één keer in de array voorkomt, 
    druk dan de index van de eerste voorkomen af.*/
}
