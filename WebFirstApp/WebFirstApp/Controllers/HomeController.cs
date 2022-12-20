using Microsoft.AspNetCore.Mvc;
using WebFirstApp.Models;
using WebFirstApp.ViewModels;

namespace WebFirstApp.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            //string[] names= { "Ali", "Murad", "Samir" };
            //ViewBag.Names = names;
            //ViewData["Names"] = "Ali"; 
            //TempData["Students"] = students; 
            //return RedirectToAction(nameof(Contact));


            List<Student> students = new List<Student>
            {
                new Student{ Id=1,Name="Ali",Surname="Mammadov"},
                new Student{ Id=2,Name="Ali",Surname="Ibrahimov"},
                new Student{ Id=3,Name="Ali",Surname="Seyfullazade"}

            };
            string[] groups = { "BB201", "BB202", "BB101" };
            //HomeViewModel homeVM= new HomeViewModel() { Studens=students,Groups=groups};
            (List<Student> Students, string[] Groups) HomeTouple=(students, groups);           

            return View(HomeTouple);
        }

        public IActionResult Error()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}
