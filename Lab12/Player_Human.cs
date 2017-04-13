using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Player_Human : Player
    {
        

        string name;

        public Player_Human(string nameTwo)
        {
            name = nameTwo;
        }

        //Continue loop inside GenerateRoshambo.
        
        public string GenerateRoshambo()
        {
            Boolean run = true;
            while (run == true)
            {
                Console.WriteLine("Welcome to Rock Paper Scissors!");
                Console.WriteLine("Do you choose rock, paper or scissors? (r/p/s");
                string input3 = Console.ReadLine();
                Roshambo r = new Roshambo();


                if (input3 == "r")
                {
                    return r.GetRoshambo(0);
                }
                else if (input3 == "p")
                {
                    return r.GetRoshambo(1);
                }
                else if (input3 == "s")
                {
                    return r.GetRoshambo(2);
                }
                else if (!input3.Equals("r" + "p" + "s"))
                {
                    Console.WriteLine("I'm sorry, I don't understand.  Let's try again.");
                    run = Continue();
                }
                                    
                //finish else statement if user puts in something other than r, p, s.
            }
            return name;

        }

        private bool Continue()
        {
            throw new NotImplementedException();
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
           this.name = name;
        }

    }

}
