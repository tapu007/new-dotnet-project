using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagementApp.DatabaseContext;
using EmployeeManagementApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagementApp.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee model)
        {
            EmployeeDbContext db = new EmployeeDbContext();
            db.Employees.Add(model);
            bool isSaved = db.SaveChanges() > 0;
            if (isSaved)
            {

                ViewBag.Message = "saved";
            }

            ModelState.Clear();
       
            return View();

        }
        
    }
}