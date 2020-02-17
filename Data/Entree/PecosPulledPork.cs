﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class PecosPulledPork : Entree
    {
        private bool bread = true;
        private bool pickle = true;

        /// <summary>
        /// Is it really a sammich if it doesn't have bread?
        /// </summary>
        public bool Bread
        {
            get { return bread; }
            set { bread = value; }
        }

        /// <summary>
        /// chic-fil-a doesn't let them touch. Do you?
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set { pickle = value; }
        }

        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> s = new List<string>();

                if (!bread) s.Add("hold bread");
                if (!pickle) s.Add("hold pickle");

                return s;
            }
        }

        public PecosPulledPork()
        {
            price = 5.88;
            calories = 528;
        }
    }
}
