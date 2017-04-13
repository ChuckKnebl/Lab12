using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    //1) Create a class called Roshambo that stores three values: rock, paper, and scissors.And returns them when necessary.

    //2)  Create an interface class named Player that stores a name and a Roshambo value.Thisclass should include a method named 
    //generateRoshambo that allows an inheriting class togenerate and return a Roshambo value.

    //3)  Create and name two player classes(subclasses of Player).o One of these players should always select rock.o 
    //The other player should randomly select rock, paper, or scissors(a 1 in 3 chance of selectingeach).

    // 4) Create a third player class that extends Player and implements the generateRoshambomethod.For this class, generateRoshambo 
    //gets input from the human player and returns thevalue chosen.

    // 5) Create a class called RoshamboApp that allows the user to play against either of your firsttwo player classes.

    // 6) Use a Validator class to validate the user’s entries.As in we only allow the user to input“rock”, “paper”, or “scissors”Remember 
    //Paper beats rock, rock beats scissors, scissors beats paper.

        //Here for Roshambo return either rock paper scissors.  
        //Can use List to return rock paper and scissors.  Use index values to get values.

    class Roshambo
    {


        private List<string> rosh;
        public Roshambo()
        {
            rosh = new List<string>();
            rosh.Add("Rock");
            rosh.Add("Paper");
            rosh.Add("Scissors");
                           
        }

        public string GetRoshambo(int index)
        {
            string ro = rosh[index];
            return ro;
        }
    }
}

