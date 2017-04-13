﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Random_Player : Player
    {
        private string name;
        Random rando;

        public Random_Player(string n, Random r)
        {
            name = n;
            rando = r;
        }

        public string GenerateRoshambo()
        {
            int pick = rando.Next(0, 3);
            Roshambo r = new Roshambo();
            string result = r.GetRoshambo(pick);
            return result;
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string n)
        {
            name = n;
        }

    }
    
}
