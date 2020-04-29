using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CowboyCafe.Data
{
    public static class Menu
    {
        /// <summary>
        /// Private backing variable 
        /// </summary>
        private static List<IOrderItem> items = new List<IOrderItem>();

        static Menu()
        {
            IEnumerable<IOrderItem> e = Entree();
            IEnumerable<IOrderItem> s = Side();
            IEnumerable<IOrderItem> d = Drink();

            foreach (IOrderItem item in e)
            {
                items.Add(item);
            }

            foreach (IOrderItem item in s)
            {
                items.Add(item);
            }

            foreach (IOrderItem item in d)
            {
                items.Add(item);
            }
        }

        /// <summary>
        /// Contains all menu items
        /// </summary>
        public static IEnumerable<IOrderItem> All { get { return items.ToArray(); } }

        /// <summary>
        /// Contrains all entree items
        /// </summary>
        public static IEnumerable<IOrderItem> Entrees { get { var e = Entree(); return e.ToArray(); } }

        /// <summary>
        /// Contains all side items
        /// </summary>
        public static IEnumerable<IOrderItem> Sides { get { var s = Side(); return s.ToArray(); } }

        /// <summary>
        /// Contains all drink items
        /// </summary>
        public static IEnumerable<IOrderItem> Drinks { get { var d = Drink(); return d.ToArray(); } }


        /// <summary>
        /// Returns all entree items
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Entree()
        {
            List<IOrderItem> e = new List<IOrderItem>();
            e.Add(new CowpokeChili());
            e.Add(new AngryChicken());
            e.Add(new PecosPulledPork());
            e.Add(new RustlersRibs());
            e.Add(new DakotaDoubleBurger());
            e.Add(new TrailBurger());
            e.Add(new TexasTripleBurger());
            IEnumerable<IOrderItem> et = e.ToArray();
            return et;
        }

        /// <summary>
        /// Returns all side items
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Side()
        {
            List<IOrderItem> side = new List<IOrderItem>();
            side.Add(new BakedBeans());
            side.Add(new ChiliCheeseFries());
            side.Add(new CornDodgers());
            side.Add(new PanDeCampo());
            IEnumerable<IOrderItem> se = side.ToArray();
            return se;
        }

        /// <summary>
        /// Returns all drinks
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Drink()
        {
            List<IOrderItem> drink = new List<IOrderItem>();
            drink.Add(new Water());
            drink.Add(new CowboyCoffee());
            drink.Add(new TexasTea());
            drink.Add(new JerkedSoda());
            IEnumerable<IOrderItem> dr = drink.ToArray();
            return dr;
        }

        /// <summary>
        /// Returns all menu items
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> MenuItems()
        {
            List<IOrderItem> menu = new List<IOrderItem>();
            IEnumerable<IOrderItem> entree = Entree();
            IEnumerable<IOrderItem> side = Side();
            IEnumerable<IOrderItem> drink = Drink();

            foreach (IOrderItem item in entree)
            {
                menu.Add(item);
            }

            foreach (IOrderItem item in side)
            {
                menu.Add(item);
            }

            foreach (IOrderItem item in drink)
            {
                menu.Add(item);
            }

            IEnumerable<IOrderItem> m = menu.ToArray();
            return m;
        }

        /// <summary>
        /// Searches thru menu and returns user searched items
        /// </summary>
        /// <param name="terms"></param>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Search(string terms)
        {
            List<IOrderItem> results = new List<IOrderItem>();
            if (terms == null) return All;
            foreach (IOrderItem item in All)
            {
                if (item.ToString() != null && item.ToString().Contains(terms, StringComparison.InvariantCultureIgnoreCase))
                {
                    results.Add(item);
                }
            }
            return results;

        }

        /// <summary>
        /// Hold different types of ItemTypes
        /// </summary>
        public static string[] ItemTypes
        {
            get => new string[]
            {
                "Entree",
                "Side",
                "Drink",
            };
        }

        /// <summary>
        /// Filters Menu by category
        /// </summary>
        /// <param name="menu"></param>
        /// <param name="Types"></param>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> FilterByCategory(IEnumerable<IOrderItem> menu, IEnumerable<string> Types)
        {
            if (ItemTypes == null || ItemTypes.Count() == 0) return menu;

            List<IOrderItem> results = new List<IOrderItem>();
            if (Types == null) return All;
            else
            {
                foreach (IOrderItem item in menu)
                {

                    var type = item.GetType();
                    if (Types.Contains(type.ToString()))
                    {
                        results.Add(item);

                    }
                }
            }

            return results;
        }

       
        /// <summary>
        /// Filter through menu by calories
        /// </summary>
        /// <param name="menu">menu to filter</param>
        /// <param name="Calories1">min calorie</param>
        /// <param name="Calories2">max calorie</param>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> menu, uint? Calories1, uint? Calories2)
        {
            if (Calories1 == null && Calories2 == null) return menu;

            var results = new List<IOrderItem>();

            if (Calories1 == null)
            {
                foreach (IOrderItem item in menu)
                {
                    if (item.Calories <= Calories2) results.Add(item);
                }
                return results;
            }

            // only a minimum specified 
            if (Calories2 == null)
            {
                foreach (IOrderItem item in menu)
                {
                    if (item.Calories >= Calories1) results.Add(item);
                }
                return results;
            }

            // Both minimum and maximum specified
            foreach (IOrderItem item in menu)
            {
                if (item.Calories >= Calories1 && item.Calories <= Calories2)
                {
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// Filters menu by price
        /// </summary>
        /// <param name="menu">menu to filter through</param>
        /// <param name="Price1">min price</param>
        /// <param name="Price2">max price</param>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> menu, double? Price1, double? Price2)
        {            
            if (Price1 == null || Price2 == null) return menu;

            var results = new List<IOrderItem>();

            if (Price1 == null)
            {
                foreach (IOrderItem item in menu)
                {
                    if (item.Price <= Price2) results.Add(item);
                }
                return results;
            }

            // only a minimum specified 
            if (Price2 == null)
            {
                foreach (IOrderItem item in menu)
                {
                    if (item.Price >= Price1) results.Add(item);
                }
                return results;
            }

            // Both minimum and maximum specified
            foreach (IOrderItem item in menu)
            {
                if (item.Price >= Price1 && item.Price <= Price2)
                {
                    results.Add(item);
                }
            }
            return results;
        }
    }


}

