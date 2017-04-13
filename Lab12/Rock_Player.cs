using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Rock_Player : Player 
    {
        string name; //var for input name.

        public Rock_Player(string n) //identify with nameTwo for Rock_Player.
        {
            name = n;  //need to name = nameTwo.
        } 
        //constructor method above.
        
        public string GenerateRoshambo()
        {
            Roshambo r = new Roshambo();
            string result = r.GetRoshambo(0);
            return result;
        }

        public string GetName()
        {
            return name;
        }
        public void SetName(string n) //with nameTwo we're over-writing NameTwo from Player.cs.
        {
            name = n;  //Here is renaming Name from above in this file.   
        }

    }
}
