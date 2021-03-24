using System;
using System.Numerics;

namespace Substrings
{
    class Substrings
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string with letters and digits: "); //Input string
            string setString = Console.ReadLine();
            BigInteger sum = 0; //BigInteger because the sum might get big

            for (int i = 0; i < setString.Length - 1; i++)
            {
                if (!int.TryParse(setString[i].ToString(), out _)) 
                {
                    continue;
                }

                for (int a = i + 1; a < setString.Length; a++)
                {
                    if (!int.TryParse(setString[a].ToString(), out _))
                    {
                        break;
                    }
                    if (setString[i] == setString[a])
                    {
                       
                        string digit = "";
                        for (int j = i; j <= a; j++)
                        {
                            digit += setString[j];
                        }
                        
                        sum += long.Parse(digit); //Calculates the substrings

                        for (var s = 0; s < setString.Length; s++)
                        {
                            //Print the marked substrings in color Magenta & the others in white
                            Console.ForegroundColor = s >= i && s <= a ? ConsoleColor.Magenta : ConsoleColor.White; 
                            Console.Write(setString[s]);
                            Console.ResetColor(); //Reset colors
                        }
                        //Puts every string on a new line
                        Console.WriteLine(); 
                        break;
                    }
                }
            }
            Console.WriteLine(" "); //Just a blank line
            Console.WriteLine("Total sum of substrings: " + sum.ToString()); //Output the total sum of substrings
        }
    }
}
