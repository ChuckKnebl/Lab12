using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Program
    {
        static void Main(string[] args)
        {


            Random rando = new Random();
            Roshambo r = new Roshambo();
            string rock = r.GetRoshambo(0);
            Console.WriteLine(rock);
            string paper = r.GetRoshambo(1);
            Console.WriteLine(paper);
            String scissors = r.GetRoshambo(2);
            Console.WriteLine(scissors);
            Player p = new Rock_Player("Rocky");
            Console.WriteLine(p.GetName() + " throws out" + p.GenerateRoshambo());
            Player p2 = new Random_Player("Vicky", rando);
            Console.WriteLine(p2.GetName() + " throws out " + p2.GenerateRoshambo());

            rando.Next();
            Console.WriteLine(p2.GetName() + "throws oout" + p2.GenerateRoshambo());
            rando.Next();
            Console.WriteLine(p2.GetName() + "throws out" + p2.GenerateRoshambo());
            rando.Next();
            Console.WriteLine(p2.GetName() + "throws out" + p2.GenerateRoshambo());
            rando.Next();
            Console.WriteLine(p2.GetName() + "throws out" + p2.GenerateRoshambo());
            rando.Next();
            Console.WriteLine(p2.GetName() + "throws out" + p2.GenerateRoshambo());
        }

      
      public static Boolean Continue()
        {
            Console.WriteLine("Play again? (y/n)");
            string input4 = Console.ReadLine();
            Boolean run = true;      
            if (input4 == "y")
            {
                run = true;
            }
            else if (input4 == "n")
            {
                run = false;
                Console.WriteLine("Good Bye.");
            }
            else
            {
                Console.WriteLine("Sorry, but I didn't understand your input.  Let's try that again!");
                run = Continue(); 
            }
            return run;
        }
    }
}

