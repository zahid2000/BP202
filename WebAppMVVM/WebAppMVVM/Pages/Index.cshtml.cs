using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppMVVM.Models;

namespace WebAppMVVM.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public List<Student> Students;
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            Students= new List<Student>()
            {
                new Student(1,"Murad"),
                new Student(2,"Ali"),
                new Student(3,"Nezrin"),
            };
        }

        public void OnGet()
        {

        }
    }
}