using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CowboyCafe.Data
{
    public static class Menu
    {
        /// <summary>
        /// Returns all entree items
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Entree()
        {    
            List<IOrderItem> entree = new List<IOrderItem>();
            Order order = new Order();
            foreach (IOrderItem item in order.Items)
            {
                if(item is Entree e)
                {
                    entree.Add(item);
                }
            }
            IEnumerable<IOrderItem> et = entree.ToArray();
            return et;
        }

        /// <summary>
        /// Returns all side items
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Side()
        {
            List<IOrderItem> side = new List<IOrderItem>();
            Order order = new Order();
            foreach (IOrderItem item in order.Items)
            {
                if (item is Side s)
                {
                    side.Add(item);
                }
            }
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
            Order order = new Order();
            foreach (IOrderItem item in order.Items)
            {
                if (item is Drink d)
                {
                    drink.Add(item);
                }
            }
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
            Order order = new Order();
            foreach (IOrderItem item in order.Items)
            {
                menu.Add(item);
            }
            IEnumerable<IOrderItem> m = menu.ToArray();
            return m;
        }
    }

   
}

