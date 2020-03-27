/*
 * Mohamed Khalil
 * 01/31/2020
 * Angry Chicken
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class AngryChicken : Entree, INotifyPropertyChanged
    {
        private bool bread = true;
        /// <summary>
        /// If chicken has Bread
        /// </summary>
        public bool Bread { 
            get 
            { 
                return bread; 
            } 
            set
            {
                bread = value;
                NotifyPropertyChange("Bread");
                NotifyPropertyChange("SpecialInstructions");
            } 
        }

        private bool pickle = true;
        /// <summary>
        /// If chicken has Pickle
        /// </summary>
        public bool Pickle { 
            get 
            {
                return pickle;
            } 
            set 
            {
                pickle = value;
                NotifyPropertyChange("Pickle");
                NotifyPropertyChange("SpecialInstructions");
            } 
        }

        /// <summary>
        /// The price of the Chicken
        /// </summary>
        public override double Price
        {
            get
            {
                return 5.99;
            }
        }

        /// <summary>
        /// The calories of the Chicken
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 190;
            }
        }

        /// <summary>
        /// Special instructions for the preparation of the chicken
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!Bread) instructions.Add("hold bread");
                if (!Pickle) instructions.Add("hold Pickle");        
                return instructions;
            }
        }

        /// <summary>
        /// Overrides to string method in order control
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Angry Chicken";
        }
    }
}
