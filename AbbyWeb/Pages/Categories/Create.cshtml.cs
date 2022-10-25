using AbbyWeb.Data;
using AbbyWeb.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Identity.Client;

namespace AbbyWeb.Pages.Categories
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDBContext _db;
        public Category Category { get; set; }

        public CreateModel(ApplicationDBContext db)
        {
            _db = db;
        }

        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPost(Category category )
        {
            //if (Category.Name == Category.DisplayOrder.ToString())
            //{
            //    ModelState.AddModelError(string.Empty, "The Displayer order must not be as Category name.");
            //}
            if (ModelState.IsValid) {

                await _db.Category.AddAsync(category);
                await _db.SaveChangesAsync();
                TempData["Success"] = "Category created succesfully!.";
                return RedirectToPage("/Categories");
            }
            return Page();
            
        }
    }
}
