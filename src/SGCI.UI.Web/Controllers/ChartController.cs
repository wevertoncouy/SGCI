using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SGCI.UI.Web.Controllers
{
    public class ChartController : Controller
    {
        public IActionResult Morris()
        {
            return View();
        }
    }
}