using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel;
using WebAppMVVMTest.Models;

namespace WebAppMVVMTest.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public List<Student> Students;

        [BindProperty]
        public Student Student { get; set; }; 

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            Students = new List<Student>()
            {
                new Student(1,"Murad"),
                new Student(2, "Ali"),
                new Student(3, "Sima")
            };
        }


        public void OnGet()
        {

        }
    }
}