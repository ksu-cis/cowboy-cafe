using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public partial class Entree
    {
        /// <summary>
        /// backing variables
        /// </summary>
        private double price;
        private int calories;
        private List<string> special = new List<string>();


        /// <summary>
        /// public getters and private setters
        /// </summary>
        double Price {
            public get => price;
            private set;
        }
        int Calories {
            public get => calories;
            private set; }
        List<string> SpecialInstructions {
            public get => special;
            private set;
        }

    }
}
