using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CowboyCafe.Data
{
    public static class Menu
    {
        public static IEnumerable<IOrderItem> All = CompleteMenu();
        public static IEnumerable<IOrderItem> Sides = Side();
        public static IEnumerable<IOrderItem> Entrees = Entree();
        public static IEnumerable<IOrderItem> Drinks = Drink();
        public static IEnumerable<string> flavors = JerkedSodaFlavors();

        /// <summary>
        /// All types of items in the menu
        /// </summary>
        public static string[] TypeOfItems
        {
            get => new string[]
            {
                "Entrees",
                "Sides",
                "Drinks"
            };
        }

        /// <summary>
        /// Gets all of the entrees in the menu
        /// </summary>
        /// <returns>All entrees at the Cowboy-Cafe</returns>
        public static IEnumerable<IOrderItem> Entree()
        {
            List<IOrderItem> entrees = new List<IOrderItem>();

            /* Add all of the entrees */
            entrees.Add(new AngryChicken());
            entrees.Add(new CowpokeChili());
            entrees.Add(new DakotaDoubleBurger());
            entrees.Add(new PecosPulledPork());
            entrees.Add(new RustlersRibs());
            entrees.Add(new TexasTripleBurger());
            entrees.Add(new TrailBurger());

            return entrees;
        }

        /// <summary>
        /// Get all the sides in the menu
        /// </summary>
        /// <returns>All Sides at the Cowboy-Cafe</returns>
        public static IEnumerable<IOrderItem> Side()
        {
            List<IOrderItem> sides = new List<IOrderItem>();
            List<IOrderItem> Fullsides = new List<IOrderItem>();

            /* Add all of the sides */
            sides.Add(new BakedBeans());            
            sides.Add(new ChiliCheeseFries());           
            sides.Add(new PanDeCampo());           
            sides.Add(new CornDodgers());
            
            foreach(IOrderItem item in sides)
            {
                var itemA = item;
                var itemB = item;
                var itemC = item;

                itemA.Size = Size.Small;
                itemB.Size = Size.Medium;
                itemC.Size = Size.Large;

                Fullsides.Add(itemA);
                Fullsides.Add(itemB);
                Fullsides.Add(itemC);
            }
            return Fullsides;
        }

        /// <summary>
        /// Get all the drinks in the menu
        /// </summary>
        /// <returns>All drinks at the Cowboy-Cafe</returns>
        public static IEnumerable<IOrderItem> Drink()
        {
            List<IOrderItem> drinks = new List<IOrderItem>();
            List<IOrderItem> Fulldrinks = new List<IOrderItem>();

            /* Add all of the sides */
            drinks.Add(new Water());
            drinks.Add(new TexasTea());
            drinks.Add(new JerkedSoda());
            drinks.Add(new CowboyCoffee());

            foreach (IOrderItem item in drinks)
            {
                var itemA = item;
                var itemB = item;
                var itemC = item;

                itemA.Size = Size.Small;
                itemB.Size = Size.Medium;
                itemC.Size = Size.Large;

                Fulldrinks.Add(itemA);
                Fulldrinks.Add(itemB);
                Fulldrinks.Add(itemC);
            }
            return Fulldrinks;
        }

        /// <summary>
        /// Compile the entire menu using the above 3 methods
        /// </summary>
        /// <returns>The complete Cowboy-Cafe Menu</returns>
        public static IEnumerable<IOrderItem> CompleteMenu()
        {
            List<IOrderItem> completeMenu = new List<IOrderItem>();

            /* The AddRange Method concats 2 list objects together */
            completeMenu.AddRange(Entree());
            completeMenu.AddRange(Side());
            completeMenu.AddRange(Drink());

            return completeMenu;
        }

        /// <summary>
        /// This is the functionality for the search bar in the website
        /// </summary>
        /// <param name="menu">The full menu</param>
        /// <param name="terms">The search key to filter by</param>
        /// <returns>An updated list with the filtered items</returns>
        public static IEnumerable<IOrderItem> Search(IEnumerable<IOrderItem> menu, string terms)
        {
            /* See if terms are null, if so no need to go further */
            if (terms == null) return menu;

            /* Cast the menu to something you can work with */
            List<IOrderItem> results = new List<IOrderItem>();

            /* Filter through the entire menu looking for the substring "terms" 
                    If substring is found in the name then it is added to results list */
            foreach (IOrderItem item in menu)
                if (item.ToString().Contains(terms, System.StringComparison.InvariantCultureIgnoreCase))
                    results.Add(item);

            return results;
        }

        /// <summary>
        /// Filters by the categories of the IOrderItems
        /// </summary>
        /// <param name="menu">The current filtered menu</param>
        /// <param name="cat">The list of categories to filter by</param>
        /// <returns>An updated list with the filtered items</returns>
        public static IEnumerable<IOrderItem> FilterByCategory(IEnumerable<IOrderItem> menu, IEnumerable<string> cat)
        {
            List<IOrderItem> results = new List<IOrderItem>();

            /* Create some boolean values so I only have to traverse list once */
            bool filterInEntrees = ((List<string>)cat).Contains("Entrees");
            bool filterInSides = ((List<string>)cat).Contains("Sides");
            bool filterInDrinks = ((List<string>)cat).Contains("Drinks");

            foreach (IOrderItem i in menu)
            {
                /* Check type of item */
                if (i is Entree e)
                {
                    /* Check if we include item */
                    if (filterInEntrees)
                        results.Add(e);
                }

                else if (i is Drink d)
                {
                    if (filterInDrinks)
                        results.Add(d);
                }

                else if (i is Side)
                {
                    if (filterInSides)
                        results.Add(i);
                }
            }

            /* Return the update search */
            return results;
        }

        /// <summary>
        /// Filters by the calories of the items
        /// </summary>
        /// <param name="menu">The current menu</param>
        /// <param name="min">The minimum number of calories that must be in the item</param>
        /// <param name="max">The maximum number of calories that must be in the item</param>
        /// <returns>An updated list with the filtered items</returns>
        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> menu, uint? min, uint? max)
        {
            /* Return the entire menu, we don't need to filter */
            if (min == null && max == null) return menu;

            /* Create results list that we can populate */
            List<IOrderItem> results = new List<IOrderItem>();

            /* Filter by the max */
            if (min == null)
            {
                foreach (IOrderItem i in menu)
                    if (i.Calories <= max)
                        results.Add(i);
            }

            /* Filter by the min */
            else if (max == null)
            {
                foreach (IOrderItem i in menu)
                    if (i.Calories >= min)
                        results.Add(i);
            }

            /* Min and max are both not null */
            else
            {
                foreach (IOrderItem i in menu)
                    if (i.Calories >= min && i.Calories <= max)
                        results.Add(i);
            }

            /* Return the updated search */
            return results;
        }

        /// <summary>
        /// Filters by the price of the entree
        /// </summary>
        /// <param name="menu">The current filtered menu</param>
        /// <param name="min">The minimum price of the entree to filter by</param>
        /// <param name="max">The maximum price of the entree to filter by</param>
        /// <returns>An updated list with the filtered items</returns>
        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> menu, double? min, double? max)
        {
            /* Nothing to filter, return here */
            if (min == null && max == null) return menu;

            /* Create results list that we can populate */
            List<IOrderItem> results = new List<IOrderItem>();

            /* Filter by the max */
            if (min == null)
            {
                foreach (IOrderItem i in menu)
                    if (i.Price <= max)
                        results.Add(i);
            }

            /* Filter by the min */
            else if (max == null)
            {
                foreach (IOrderItem i in menu)
                    if (i.Price >= min)
                        results.Add(i);
            }

            /* Min and max are both not null */
            else
            {
                foreach (IOrderItem i in menu)
                    if (i.Price >= min && i.Price <= max)
                        results.Add(i);
            }

            /* Return the updated search */
            return results;
        }

        public static IEnumerable<string> JerkedSodaFlavors()
        {
            List<string> s = new List<string>();
            s.Add("CreamSoda");
            s.Add("OrangeSoda");
            s.Add("Sarsparilla");
            s.Add("BirchBeer");
            s.Add("RootBeer");
            return s;
        }
    }


}

