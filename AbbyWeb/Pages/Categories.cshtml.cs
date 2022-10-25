using AbbyWeb.Data;
using AbbyWeb.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AbbyWeb.Pages
{
    public class CategoriesModel : PageModel
    {
        private readonly ApplicationDBContext _db;

        public IEnumerable<Category>? Categories { get; set; }

        public CategoriesModel(ApplicationDBContext db) => _db = db;
        public void OnGet()
        {
            Categories = _db.Category;
        }
    }
}

