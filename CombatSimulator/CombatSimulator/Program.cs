using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to SkyrimV2.0");
            Console.WriteLine();
            Console.WriteLine("You have traveled many many miles just to get to this moment.");
            Console.WriteLine("Face to face with the mighty dragon Elduin theres only one choice.");
            Console.WriteLine("You haven't gotten this far to let this foe end everything you've become.");
            Console.WriteLine();
            Console.WriteLine("Choose your attack with the keys:");
            Console.WriteLine("1: Sword");
            Console.WriteLine("2: Bow");
            Console.WriteLine("3: Magic");
            Console.WriteLine("4: Heal Elixer");
            Console.WriteLine();
            Console.WriteLine("FIGHT!");
            combatSim();
            Console.ReadKey();
        }

        static void combatSim()
        {
            int playerNordHP = 100;
            int dragonElduinHP = 200;
            int dragonAttack = 0;
            int playerAttack = 0;
            Random rng = new Random();
            string userInput = Console.ReadLine();
            bool playing = true;

            while (playing)
            {
                Console.Clear();

                if(dragonElduinHP <= 0 || playerNordHP <= 0)
                {
                    playing = false;
                }
                if (userInput == "1")
                {
                    if (rng.Next(0, 101) > 30)
                    {
                        playerAttack = rng.Next(20, 36);
                        dragonElduinHP -= playerAttack;
                        Console.WriteLine("Your Nord did " + playerAttack + " damage.");
                        Console.WriteLine();
                        Console.WriteLine("Elduin now has " + dragonElduinHP + " hit points left.");
                        userInput = Console.ReadLine();
                    }
                    if (rng.Next(0, 101) > 20)
                        {
                            dragonAttack = rng.Next(5, 15);
                            playerNordHP -= dragonAttack;
                            Console.WriteLine("Elduin did " + dragonAttack + " damage.");
                            Console.WriteLine();
                            Console.WriteLine("Your Nord now has " + playerNordHP + " hit points left.");
                        }
                    
                }

                else if (userInput == "2")
                {
                    if (rng.Next(0, 101) > 35)
                    {
                        playerAttack = rng.Next(5, 21);
                        dragonElduinHP -= playerAttack;
                        Console.WriteLine("Your Nord did " + playerAttack + " damage.");
                        Console.WriteLine();
                        Console.WriteLine("Elduin now has " + dragonElduinHP + " hit points left.");
                        Console.ReadLine();
                    }
                    if (rng.Next(0, 101) > 20)
                    {
                        dragonAttack = rng.Next(5, 15);
                        playerNordHP -= dragonAttack;
                        Console.WriteLine("Elduin did " + dragonAttack + " damage.");
                        Console.WriteLine();
                        Console.WriteLine("Your Nord now has " + playerNordHP + " hit points left.");
                    }
                 }

                else if (userInput == "3")
                {
                    playerAttack = rng.Next(10, 15);
                    dragonElduinHP -= playerAttack;
                    Console.WriteLine("Your Nord did " + playerAttack + " damage");
                    Console.WriteLine();
                    Console.WriteLine("Elduin now has " + dragonElduinHP + " hit points left.");
                    if (rng.Next(0, 101) > 20)
                    {
                        dragonAttack = rng.Next(5, 15);
                        playerNordHP -= dragonAttack;
                        Console.WriteLine("Elduin did " + dragonAttack + " damage.");
                        Console.WriteLine();
                        Console.WriteLine("Your Nord now has " + playerNordHP + " hit points left.");
                    }
                    Console.ReadLine();
                }
                

                else if (userInput == "4")
                {
                    playerAttack = rng.Next(10, 20);
                    playerNordHP+=playerAttack;
                    Console.WriteLine("You have been healed " + playerAttack + " hit points");
                    if (rng.Next(0, 101) > 20)
                    {
                        dragonAttack = rng.Next(5, 15);
                        playerNordHP -= dragonAttack;
                        Console.WriteLine("Elduin did " + dragonAttack + " damage.");
                        Console.WriteLine();
                        Console.WriteLine("Your Nord now has " + playerNordHP + " hit points left.");
                    }
                    Console.ReadLine();

                }
                else
                {
                    Console.WriteLine("Enter a valid Guess.");
                }
                
            }

            while (playing == false)
            {
                if(playerNordHP <= 0) 
                {
                    Console.WriteLine("You lost! You actally kinda suck...");
                    break;
                }
                else
                {
                    Console.WriteLine("You won! You have conquered all of Skyrim!");
                    break;
                }
            }
        }
    }
}
