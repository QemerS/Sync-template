using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Sync.Data;
using Sync.Models;
using Sync.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Sync.Controllers
{
    public class HomeController : Controller
    {
        private readonly SyncContext _context;

        public HomeController(SyncContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            HomeVm vm = new HomeVm()
            {
                Socials = _context.Social.ToList(),
                Settings = _context.Setting.ToList()

            };
            return View(vm);    
        }

    }
}
