using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_while_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Check if your favorite player finished in the top 5 in Batting Average.");
            Console.WriteLine("Please enter a player's first and last name: ");
            string name = Console.ReadLine();
            bool isTopFive = name == "Mookie Betts" || name == "J.D. Martinez" || name == "Christian Yelich" || name == "Jose Altuve" || name == "Mike Trout";

            do
            {
                switch (name)
                {
                    case "Scooter Gennet":
                        Console.WriteLine("Scooter Gennet was top 10 in Batting Average, but not in the top 5.");
                        Console.WriteLine("Please enter a player's first and last name: ");
                        name = Console.ReadLine();
                        break;
                    case "Freddie Freeman":
                        Console.WriteLine("Freddie Freeman was top 10 in Batting Average, but not in the top 5.");
                        Console.WriteLine("Please enter a player's first and last name: ");
                        name = Console.ReadLine();
                        break;
                    case "Michael Brantley":
                        Console.WriteLine("Michael Brantley was top 10 in Batting Average, but not in the top 5.");
                        Console.WriteLine("Please enter a player's first and last name: ");
                        name = Console.ReadLine();
                        break;
                    case "Anthony Rendon":
                        Console.WriteLine("Anthony Rendon was top 10 in Batting Average, but not in the top 5.");
                        Console.WriteLine("Please enter a player's first and last name: ");
                        name = Console.ReadLine();
                        break;
                    case "Lorenzo Cain":
                        Console.WriteLine("Lorenzo Cain was top 10 in Batting Average, but not in the top 5.");
                        Console.WriteLine("Please enter a player's first and last name: ");
                        name = Console.ReadLine();
                        break;
                    case "Mookie Betts":
                        Console.WriteLine("Mookie Betts finished 1st in the MLB with a .346 Batting Average.");
                        isTopFive = true;
                        break;
                    case "J.D. Martinez":
                        Console.WriteLine("J.D. Martinez finished 2nd in the MLB with a .330 Batting Average.");
                        isTopFive = true;
                        break;
                    case "Christian Yelich":
                        Console.WriteLine("Christian Yelich finished 3rd in the MLB with a .326 Batting Average.");
                        isTopFive = true;
                        break;
                    case "Jose Altuve":
                        Console.WriteLine("Jose Altuve finished 4th in the MLB with a .316 Batting Average.");
                        isTopFive = true;
                        break;
                    case "Mike Trout":
                        Console.WriteLine("Mike Trout finished 5th in the MLB with a .312 Batting Average.");
                        isTopFive = true;
                        break;
                    default:
                        Console.WriteLine("This player was not in the top 5 in Batting Average");
                        Console.WriteLine("Please enter a player's first and last name:");
                        name = Console.ReadLine();
                        break;

                }
            }
            while (!isTopFive);

            Console.Read();

        }
    }
}
