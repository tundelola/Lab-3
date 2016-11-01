using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tableOfPower
{
    //This Program displays a table of powers
    class Program
    {
        static void Main(string[] args)
        {
                       
                
                printTableOfPower();//call to printTableOfPower method

              
            
        }
        //Method calculates the squares and the cubes of user's input
        static void printTableOfPower()
        {
          
            int squarResult;
            int cubeResult;
            Boolean cubSqure = true;
            while (cubSqure)
            {
                Console.WriteLine("Please enter an integer Number");//gets input from the user
                int max = int.Parse(Console.ReadLine());// Reads user's input
                Console.WriteLine(String.Format("{0,-10} {1,-10} {2,-10}", "Number", "Squared", "Cubed"));
                Console.WriteLine(String.Format("{0,-10} {1,-10} {2,-10}", "=======", "=======", "======="));

                int i;
                for (i = 1; i <= max; i++)
                {
                    squarResult = i * i;
                    cubeResult = i * i * i;
                    Console.WriteLine(String.Format("{0,-10} {1,-10} {2,-10}", i, squarResult, cubeResult));
                }
                Console.WriteLine("Do you want to continue ");//Ask if users wants to continue
                string userInput = Console.ReadLine();
                if (userInput == "Y" || userInput == "y")
                {
                    cubSqure = true;

                }
                else
                {
                    cubSqure = false;
                    break;
                }

            }

        }

    }

}







