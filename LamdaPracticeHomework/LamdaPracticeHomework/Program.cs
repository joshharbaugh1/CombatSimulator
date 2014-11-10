using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamdaPracticeHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> products = new List<string>() {"Basketball", "Baseball", "Tennis Raquet", "Running Shoes", "Wrestling Shoes", 
                "Soccer Ball", "Football", "Shoulder Pads", 
                "Trail Running Shoes", "Cycling Shoes", "Kayak", "Kayak Paddles"};


            //declare a variable kayakProducts and set it equal to all products that contain the word "Kayak"
            List<string> kayakProducts = products.Where(x => x.Contains("Kayak")).ToList();
            //print the kayakProducts to the console using a foreach loop.
            foreach (string product in kayakProducts)
            {
                Console.WriteLine(product);
            }
            //declare a variable shoeProducts and set it equal to all products that contain the word "Shoes"
            List<string> shoeProducts = products.Where(x => x.Contains("Shoes")).ToList();
            //print the shoeProducts to the console using a foreach loop or string.Join().
            foreach (string product in shoeProducts)
            {
                Console.WriteLine(product);
            }
            //declare a variable ballProducts and set it equal to all the products that have ball in the name.
            List<string> ballProducts = products.Where(x => x.ToLower().Contains("ball")).ToList();
            //print the ballProducts to the console using a foreach loop or string.Join().
            foreach (string product in ballProducts)
            {
                Console.WriteLine(product);
            }
            //sort ballProducts alphabetically and print them to the console.
            Console.WriteLine(string.Join(", ", ballProducts.OrderBy(x => x)));
            //add six more items to the products list using .add().
            products.Add("Gat");
            products.Add("Prison Shank");
            products.Add("Prison Chum");
            products.Add("Soap");
            products.Add("****meat Sandwich");
            products.Add("Cavity Drugs");
            products.Add("Toilet Wine");
            //print the product with the longest name to the console using the .First() extension.
            Console.WriteLine(products.OrderBy(x => x.Length).Last());
            //print the product with the shortest name to the console using OrderByDesceding() and the .First() extension.
            Console.WriteLine(products.OrderByDescending(x => x.Length).Last());
            //print the product with the 4th shortest name to the console using an index or Skip/Take (you must convert the results to a list using .ToList()).
            Console.WriteLine(products.OrderByDescending(x => x.Length).Skip(3).First());
            //print the ballProduct with the 2nd longest name to the console using an index or Skip/Take (you must convert the results to a list using .ToList()).
            Console.WriteLine(products.OrderBy(x => x.Length).Skip(1).Last());
            //declare a variable reversedProducts and set it equal to all products ordered by the longest word first. (use the OrderByDescending() extension).
            List<string> reversedProducts = products.OrderByDescending(x => x.Length).ToList();
            //print out the reversedProducts to the console using a foreach loop.
            foreach (string product in reversedProducts)
            {
                Console.WriteLine(product);
            }
            //print out all the products ordered by the longest word first using the OrderByDecending() extension and a foreach loop.
            foreach (string product in reversedProducts.OrderByDescending(x => x.Length))
            {
                Console.WriteLine(product);
            }
            //Note: you will not use a variable to store your list

            Console.ReadKey();
        }
    }
}
