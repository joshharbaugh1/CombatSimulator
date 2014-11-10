using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatSimulator2
{
    class Program
    {
        static void Main(string[] args)
        {

            //making the story line and instructing the player
            Console.WriteLine("Welcome to SkyrimV2.0");
            Console.WriteLine();
            Console.WriteLine("You have traveled many many miles just to get to this moment.");
            Console.WriteLine("Face to face with the mighty dragon Alduin theres only one choice.");
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
            //defining the variables to keep track of
            int playerNordHP = 100;
            int dragonAlduinHP = 200;
            int dragonAttack = 0;
            int playerAttack = 0;
            int playerHeal = 0;
            Random rng = new Random();
            string userInput = Console.ReadLine();
            bool playing = true;

            while (playing)
            {
                Console.Clear();
                //if the dragon or player reach 0 HP the game will end
                if (dragonAlduinHP <= 0 || playerNordHP <= 0)
                {
                    playing = false;
                    break;
                }
                
                //making the user input controls from here down
                if (userInput == "1")
                {
                    if (rng.Next(0, 101) > 30 )
                    {
                        playerAttack = rng.Next(20, 36);
                        dragonAlduinHP -= playerAttack;
                        Console.WriteLine("Your Nord did " + playerAttack + " damage.");
                        Console.WriteLine();
                        Console.WriteLine("Alduin now has " + dragonAlduinHP + " hit points left.");
                        userInput = Console.ReadLine();
                    }
                    //making the dragon attack the player after the player enters an input
                    if (rng.Next(0, 101) > 20)
                    {
                        dragonAttack = rng.Next(5, 16);
                        playerNordHP -= dragonAttack;
                        Console.WriteLine("Alduin did " + dragonAttack + " damage.");
                        Console.WriteLine();
                        Console.WriteLine("Your Nord now has " + playerNordHP + " hit points left.");
                    }
                }

                else if (userInput == "2")
                {
                    if (rng.Next(0, 101) > 35)
                    {
                        playerAttack = rng.Next(5, 21);
                        dragonAlduinHP -= playerAttack;
                        Console.WriteLine("Your Nord did " + playerAttack + " damage.");
                        Console.WriteLine();
                        Console.WriteLine("Alduin now has " + dragonAlduinHP + " hit points left.");
                        userInput = Console.ReadLine();
                    }
                    if (rng.Next(0, 101) > 20)
                    {
                        dragonAttack = rng.Next(5, 16);
                        playerNordHP -= dragonAttack;
                        Console.WriteLine("Alduin did " + dragonAttack + " damage.");
                        Console.WriteLine();
                        Console.WriteLine("Your Nord now has " + playerNordHP + " hit points left.");
                    }
                }

                else if (userInput == "3")
                {
                    playerAttack = rng.Next(10, 16);
                    dragonAlduinHP -= playerAttack;
                    Console.WriteLine("Your Nord did " + playerAttack + " damage.");
                    Console.WriteLine();
                    Console.WriteLine("Alduin now has " + dragonAlduinHP + " hit points left.");
                    if (rng.Next(0, 101) > 20)
                    {
                        dragonAttack = rng.Next(5, 16);
                        playerNordHP -= dragonAttack;
                        Console.WriteLine("Alduin did " + dragonAttack + " damage.");
                        Console.WriteLine();
                        Console.WriteLine("Your Nord now has " + playerNordHP + " hit points left.");
                    }
                    userInput = Console.ReadLine();
                }

                //the heal player part of the game
                else if (userInput == "4")
                {
                    playerHeal = rng.Next(10, 21);
                    playerNordHP += playerHeal;
                    Console.WriteLine("You have been healed " + playerHeal + " hit points.");
                    if (rng.Next(0, 101) > 20)
                    {
                        dragonAttack = rng.Next(0, 16);
                        playerNordHP -= dragonAttack;
                        Console.WriteLine("Alduin did " + dragonAttack + " damage.");
                        Console.WriteLine();
                        Console.WriteLine("Your Nord now has " + playerNordHP + " hit points left.");
                    }
                    userInput = Console.ReadLine();
                }
                //if the user does not enter a number 1-4 it will say to enter a valid input
                else
                {
                    Console.WriteLine("Enter a valid attack.");
                    userInput = Console.ReadLine();
                }
            }
            //when either one reaches 0 it will either tell the player if they won or lost
            while (playing == false)
            {
                if (playerNordHP <= 0)
                {
                    Console.WriteLine("You lost! You actually kinda suck...");
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
