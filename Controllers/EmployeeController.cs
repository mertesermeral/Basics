using Basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace Basics.Controllers
{
    public class EmployeeController : Controller 
    {
        public IActionResult Index1()
        {
            string message = $"Hello {DateTime.Now.ToString()}";
            return View("Index1",message); //string

        }
        public ViewResult Index2()
        {
            var names = new String [] //String array
            {
                "Mehmet",
                "Ali",
                "Can"


            };
            return View(names); //doğrudan names verebiliriz. 
        }
        /*public IActionResult Index3(){ /*daha kapsayıcı, contentresult da kullanılabilir.
            return Content("Employee"); //content (içerik)
        } */

        public IActionResult Index3()
        {
            var list = new List<Employee>()
            {

                new Employee(){Id=1,FirstName="Mert", LastName="Can",Age=20},
                new Employee(){Id=2,FirstName="Can", LastName="Dağ",Age=25},
                new Employee(){Id=3,FirstName="Demir", LastName="Kaya",Age=30},


            };
            return View(list);



        }

    }
}