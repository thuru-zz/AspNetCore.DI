using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspNetCore.DI.Services;

namespace AspNetCore.DI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMySingeltonService _singletonService;
        private readonly IMyTransientService _transientService;
        private readonly IMyScopedService _scopedService;
        private readonly IMyAnotherService _anotherService;
        

        public HomeController(IMySingeltonService singletonService, IMyTransientService transientService, 
            IMyScopedService scopedService, IMyAnotherService anotherService)
        {
            _singletonService = singletonService;
            _transientService = transientService;
            _scopedService = scopedService;
            _anotherService = anotherService;
        }

        public IActionResult Index()
        {
            ViewBag.Singleton = _singletonService.Id;
            ViewBag.Transient = _transientService.Id;
            ViewBag.Scoped = _scopedService.Id;

            ViewBag.AnotherSingleton = _anotherService.SingletonId;
            ViewBag.AnotherTransient = _anotherService.TransientId;
            ViewBag.AnotherScoped = _anotherService.ScopedId;

            return View(ViewBag);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
