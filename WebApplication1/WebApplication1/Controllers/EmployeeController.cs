using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class EmployeeController : Controller
    {
        public static List<Employee> empList = new List<Employee>()
        {
            new Employee() { Id = 1, Fname ="SAM",Lname="Dicosta",Salary=98000.98,Designation="Manager" },
               new Employee() { Id = 2, Fname ="Aishu",Lname="Divi",Salary=98000.98,Designation="Manager" },
                   new Employee() { Id = 3, Fname ="Divi",Lname="Aishu",Salary=98000.98,Designation="Manager" },
                       new Employee() { Id = 4, Fname ="Ilex",Lname="kava",Salary=98000.98,Designation="Manager" },
                           new Employee() { Id = 5, Fname ="Sneha",Lname="ben",Salary=98000.98,Designation="Manager" },
        };
        public IActionResult Index()
        {
            return View(empList);
        }
        [HttpGet]
        public  IActionResult Create()
        {
            return View(new Employee());
        }
        [HttpPost]

        public IActionResult Create(Employee model)
        {
            if(ModelState.IsValid)
            {
                empList.Add(model);
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }
    }
}
