using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sync.Areas.admin.Controllers
{
    [Area("admin")] //bunu elave edenden sonra normal error geldi
    public class AdminHomeController : Controller
    {
        public IActionResult Index2()
        {
            return View();
        }
    }
}
