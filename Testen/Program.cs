using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nummers = { 10, 24, 33, 20, 88 };
            int num = 0;


            /*for (int i = 0; i < nummers.Length; i++)
            {
                nummers[i] += num;
                num = nummers[i];
            }   
                Console.WriteLine(num);*/

            /*for (int i = 0; i < nummers.Length; i++)
            {
                if (nummers[i] > num)
                { 
                    num = nummers[i]; 
                }
                else 
                {
                    continue;
                }
            }
            Console.WriteLine(num);*/


            string[] lettersNumbers = { "A", "a", "B", "b", "C", "c", "D", "d", "E", "e", "F", "f","G","g","H","h","I","i",
                                        "J","j","K","k","L","l","M","m","N","n","O","o","P","p","Q","q","R","r","S","s","T","t",
                                        "U","u","V","v","W","w","X","x","Y","y","Z","z","0","1","2","3","4","5","6","7","8","9"};
            string[] password = new string[5];
            

            

                Random random = new Random();
            for(int i = 0; i < password.Length; i++)
            {
                int ran = random.Next(lettersNumbers.Length-1);
                Console.WriteLine(ran);
                password[i] = lettersNumbers[ran];
            }
            /*foreach(string p in password)
            {
                Console.WriteLine(p);
            }*/


        }
    }
}
