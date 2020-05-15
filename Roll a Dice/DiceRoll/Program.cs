using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using  static  System.Console;

namespace DiceRoll
{
    class Program
    { 
        static void Main(string[] args)
        {
            int diceAdd;
            int Total = 0;
            int Mod = 0;
      
                RandomGenerator generator = new RandomGenerator();

                while ((Mod != 10)) 

            {
                    int aNumber = generator.RandomNumber(1, 6);


                    int bNumber = generator.RandomNumber(1, 6);


                    int cNumber = generator.RandomNumber(1, 6);
                    WriteLine($"Dice one: {aNumber}");
                    WriteLine($"Dice two: {bNumber}");
                    WriteLine($"Dice three: {cNumber}");

                    diceAdd = aNumber + bNumber + cNumber;
                    Total +=  diceAdd;
                    WriteLine($"Total: {Total}");
                    Mod = Total % 100;
                    WriteLine($"Mod: {Mod}");
                    if (Mod == 0)
                    {
                        WriteLine($"Winner finally");
                        break;
                    }
                else if ((Mod > 10) || Total > 10)
                    {
                        Total = 0;
                        WriteLine($"Whole number:{Total}");
                    }
            }
            // Console.WriteLine($"Total of the dice {Mod}"); 

            Console.WriteLine("Hello World!");
            ReadKey(); 
        }

       private class RandomGenerator
       {
           public int RandomNumber(int min, int max)
           {
               Random random = new Random();
               return random.Next(min, max);
           }
       }

        //static int ValueDice(int[] diceInts)
        //{

        //    throw new NotImplementedException();
        //}

    }
}
//do
//{
//    RandomGenerator generator = new RandomGenerator();
//int aNumber = generator.RandomNumber(1, 6);
//WriteLine($"Dice one: {aNumber}");

//int bNumber = generator.RandomNumber(1, 6);
//WriteLine($"Dice two: {bNumber}");

//int cNumber= generator.RandomNumber(1, 6);
//WriteLine($"Dice three: {cNumber}");


//     diceAdd = aNumber + bNumber + cNumber;
//     Total += diceAdd;
//     Mod = Total % 100;

//     if (Total > 100)
//     {
//         Total = Mod;
//         WriteLine($"WHole {Total}");
//     }
//} while ();