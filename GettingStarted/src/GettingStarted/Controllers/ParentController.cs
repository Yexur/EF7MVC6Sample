using GettingStarted.Logic;
using GettingStarted.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GettingStarted.Controllers
{
    public class ParentController : Controller
    {
        private readonly IParentLogic _parentlogic;

        public ParentController(IParentLogic parentLogic)
        {
            _parentlogic = parentLogic;
        }

        //GET
        public IActionResult Index()
        {
            return View(_parentlogic.GetList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Parent parent)
        {
            if (ModelState.IsValid)
            {
                _parentlogic.Save(parent);
                return RedirectToAction("Index");
            }
            return View(parent);           
        }
    }
}
