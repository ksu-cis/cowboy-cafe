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
            entree.Add(new CowpokeChili());
            entree.Add(new AngryChicken());
            entree.Add(new DakotaDoubleBurger());
            entree.Add(new PecosPulledPork());
            entree.Add(new RustlersRibs());
            entree.Add(new TexasTripleBurger());
            entree.Add(new TrailBurger());
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

