using Bees.Core;
using Bees.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;

namespace Bees.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IBeeData _beeData;

        public IEnumerable<IBee> Bees { get; set; }


        public IndexModel(IBeeData beeData)
        {
            _beeData = beeData;
        }

        public void OnGet()
        {
            Bees = _beeData.GetAll();
        }

        public IActionResult OnPost()
        {
            Bees = _beeData.GetAll();
            foreach (var bee in Bees)
            {
                bee.Damage(new Random().Next(0, 80));
            }

            // Following the POST-REDIRECT-GET (PRG) pattern, so the user isn't left on a page that is displaying the results of a POST request.    
            return RedirectToPage("./Index");
        }
    }
}