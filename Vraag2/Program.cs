using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Vraag2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lettersNumbers = { "A", "a", "B", "b", "C", "c", "D", "d", "E", "e", "F", "f","G","g","H","h","I","i",
                                        "J","j","K","k","L","l","M","m","N","n","O","o","P","p","Q","q","R","r","S","s","T","t",
                                        "U","u","V","v","W","w","X","x","Y","y","Z","z","0","1","2","3","4","5","6","7","8","9"};
            string[] password = new string[5];            
            int ran;


            Random random = new Random();
            for (int i = 0; i < password.Length; i++)
            {
                ran = random.Next(lettersNumbers.Length - 1);                
                password[i] = lettersNumbers[ran];
            }
            foreach (string p in password)
            {
                Console.Write(p);
            }



        }       

    }
    /*Maak een paswoordgenerator.Deze generator maakt een willekeurig paswoord aan
    van 5 willekeurige karakters(letters en/of cijfers).
    Breng eerst in een array de letters van het alfabet(kleine letters en hoofdletters) alsook de cijfers.
    Haal vervolgens 5 karakters uit deze array en breng deze onder in een nieuwe array.
    Geef vervolgens het paswoord op het scherm.
    Vraag aan de gebruiker of er nog een paswoord moet gegenereerd worden met ja of neen.
    Bij neen, stopt het programma.*/
}
