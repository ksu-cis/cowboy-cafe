using System;

namespace CowboyCafe.DataObjects
{
    /// <summary>
    /// A class representing an entree of Franks n' Beans
    /// </summary>
    public class FranksAndBeans
    {
        public double Price
        {
            get
            {
                return 6.0;
            }
        }

        public int Calories
        {
            get
            {
                return 356;
            }
        }

        public string[] Ingredients
        {
            get
            {
                return new string[]
                {
                    "beef",
                    "chicken",
                    "pork",
                    "navy beans",
                    "molasses",
                    "butter",
                    "onion",
                    "brown sugar",
                    "mustard",
                    "celery",
                    "salt"
                };
            }
        }


    }
}
