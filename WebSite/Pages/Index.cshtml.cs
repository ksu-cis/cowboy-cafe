using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using CowboyCafe.Data;
using CowboyCafe.Extensions;

namespace WebSite.Pages
{
    public class IndexModel : PageModel
    {
        /// <summary>
        /// The movies to display on the index page 
        /// </summary>
        public IEnumerable<IOrderItem> All { get; protected set; }

        /// <summary>
        /// The current search terms 
        /// </summary>
        [BindProperty]
        public string SearchTerms { get; set; } = "";

        /// <summary>
        /// Different types of items served
        /// </summary>
        [BindProperty]
        public static string[] ItemTypes { get; set; } = new string[3];

        /// <summary>
        /// The minimum price
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public double? Price1 { get; set; }

        /// <summary>
        /// The minimum price
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public double? Price2 { get; set; }

        /// <summary>
        /// The maximum calories
        /// </summary>
        [BindProperty(SupportsGet =true)]
        public uint? Calories1 { get; set; }

        /// <summary>
        /// The maximum calories
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public uint? Calories2 { get; set; }

        public void OnGet(double? Price1, double? Price2, uint? Calories1, uint? Calories2)
        {
            var p1 = double.Parse(Request.Query["Price1"]);
            if (double.IsNaN(p1)) Price1 = null;
            else Price1 = p1;

            var p2 = double.Parse(Request.Query["Price2"]);
            if (double.IsNaN(p2)) Price2 = null;
            else Price2 = p2;

            this.Calories1 = Calories1;
            this.Calories2 = Calories2;

            All = Menu.All;
            All = CowboyCafe.Data.Menu.Search(SearchTerms);
            All = CowboyCafe.Data.Menu.FilterByCategory(All, ItemTypes);
            All = CowboyCafe.Data.Menu.FilterByPrice(All, Price1, Price2);
            All = CowboyCafe.Data.Menu.FilterByCalories(All, Calories1, Calories2);
        }

    }
}
