using App.Data;
using App.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace App.Pages.Author
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDBcs _db;

        public IEnumerable<Autor> Authors { get; set; }

        public IndexModel(ApplicationDBcs db)
        {
            _db = db;
        }
        public void OnGet()
        {
            Authors = _db.Authors;
        }
    }
}
