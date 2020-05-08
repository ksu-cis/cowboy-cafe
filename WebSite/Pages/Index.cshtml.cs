using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using CowboyCafe.Data;
using CowboyCafe.Extensions;
using System.Security.Policy;

namespace WebSite.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        /// <summary>
        /// Holds the current menu that is shown in the html
        /// </summary>
        public IEnumerable<IOrderItem> FullMenu { get; protected set; }


        public string[] typeOfItems { get; set; }

        /// <summary>
        /// Search terms if the user wanted to search for something
        /// </summary>
        [BindProperty]
        public string SearchTerms { get; set; } = "";

        /// <summary>
        /// The minimum price to filter the items by
        /// </summary>
        [BindProperty]
        public double? PriceMin { get; set; } = 0;

        /// <summary>
        /// The maximum price to filter the items by
        /// </summary>
        [BindProperty]
        public double? PriceMax { get; set; } = 100;

        /// <summary>
        /// The minimum calorie to filter the items by
        /// </summary>
        [BindProperty]
        public uint? CalorieMin { get; set; } = 0;

        /// <summary>
        /// The maximum calorie to filter the items by
        /// </summary>
        [BindProperty]
        public uint? CalorieMax { get; set; } = 1000;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Hits this method when get request start flowing
        /// </summary>
        public void OnGet(uint? CalorieMin, uint? CalorieMax, double? PriceMin, double? PriceMax, string[]? typeOfItems)
        {
            this.CalorieMax = CalorieMax;
            this.CalorieMin = CalorieMin;
            this.PriceMin = PriceMin;
            this.PriceMax = PriceMax;

            SearchTerms = Request.Query["SearchTerms"];
            this.typeOfItems = Request.Query["typeOfItems"];

            if (this.typeOfItems.Length == 0)
            {
                typeOfItems = new string[]
                {
                    "Entrees",
                    "Sides",
                    "Drinks"
                };
            }

            FullMenu = Menu.All;
            // Search menu for the SearchTerms
            if (SearchTerms != null)
            {
                FullMenu = from All in FullMenu
                         where All.ToString() != null && All.ToString().Contains(SearchTerms, StringComparison.InvariantCultureIgnoreCase)
                         select All;
            }

            // Filter by Category 
            if (typeOfItems != null && typeOfItems.Length != 0)
            {
                FullMenu = from All in FullMenu
                           where typeOfItems != null && typeOfItems.Contains(Menu.TypeOfItems.ToString())
                           select All;
            }

            //Filter by category
            if(CalorieMin == null && CalorieMax == null)
            {
                FullMenu = FullMenu;
            }
            else if(CalorieMin == null)
            {
                FullMenu = from All in FullMenu
                           where All.Price <= CalorieMax
                           select All;
            }
            else if (CalorieMax == null)
            {
                FullMenu = from All in FullMenu
                           where All.Price >= CalorieMin
                           select All;
            }
            else
            {
                FullMenu = from All in FullMenu
                           where All.Price <= CalorieMax && All.Price >= CalorieMin
                           select All;
            }

            //Filter By Price
            if (PriceMax == null && PriceMin == null)
            {
                FullMenu = FullMenu;
            }
            else if (PriceMin == null)
            {
                FullMenu = from All in FullMenu
                           where All.Price <= PriceMax
                           select All;
            }
            else if (PriceMax == null)
            {
                FullMenu = from All in FullMenu
                           where All.Price >= PriceMin
                           select All;
            }
            else
            {
                FullMenu = from All in FullMenu
                           where All.Price <= PriceMax && All.Price >= PriceMin
                           select All;
            }
        }

    }
}
