using BulkyWebRazor_Temp.Data;
using BulkyWebRazor_Temp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BulkyWebRazor_Temp.Pages.Categories
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
    }
}
