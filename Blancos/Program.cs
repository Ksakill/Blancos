using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blancos
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // all the ints below are the numbers given from the document Å6 being alterd as it was told to be the end of it is Å11
            int Å1 = 175134;
            int Å2 = 175388;
            int Å3 = 172818;
            int Å4 = 142709;
            int Å5 = 151437;
            int Å6 = 188052;
            int Å7 = 150979;
            int Å8 = 152210;
            int Å9 = 149450;
            int Å10 = 154398;
            int Å11 = 150160;
            // the array that contains the numbers given with the help of the int i made above
            int[] ÅR = { Å1, Å2, Å3, Å4, Å5, Å6, Å7, Å8, Å9, Å10, Å11 };

            // the max stars the program can use
            int maxStars = 10; 

            // what the current maxValue is equal too
            int maxValue = 0;
            foreach (int value in ÅR) // a foreach that says that foreach Int value in the ÅR do what is whein the {}
            {
                if (value > maxValue) // and if that says if the value is bigger then the max value do what is below
                {
                    maxValue = value; // the max value is the value
                }
            }

            for (int i = 0; i < ÅR.Length; i++) // int i is 0 so long as i is smaller then År add 1 to it
            {
                int MyValue = ÅR[i] * maxStars / maxValue; //the formula showed in the document

                Console.Write($"Å{i + 1} ({ÅR[i]}): "); // write what is within the "" 
                PrintAsterisks(MyValue); // constols the number of the * that are created
                Console.WriteLine(); // creates new line moveing the moves the cursor
            }
        }

        private static void PrintAsterisks(int count)
        {
            for (int j = 0; j < count; j++) // int is j and j is 0 so long as j is smaller then count add 1 to it
            {
                Console.Write("*"); // write *
            }
        }
    }
}

// small steps i did make some on my own but needed a bit of online help
