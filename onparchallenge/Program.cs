using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onparchallenge
{
    class Program
    {
        static void Main(string[] args)
        { //ask user for 1 number
            string playAgain = null;
            do
            {
                Console.WriteLine("Pick a number");
                int num = int.Parse(Console.ReadLine());
                //write number and sum
                Console.WriteLine("sum {0}", num);

                //do you want another number
                Console.WriteLine("Do you want another number?" );
    

               string playAgain = Console.ReadLine().ToUpper();
                Console.Clear(); ;

                if playAgain = no
                {
                    Console.WriteLine("GoodBye')
                }



                while (playAgain == "YES") ;
            }




        }
    }
}
