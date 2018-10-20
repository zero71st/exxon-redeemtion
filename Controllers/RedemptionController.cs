using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ExxonRedeemtion.Models;

namespace ExxonRedeemtion.Controllers
{
    public class RedemptionController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}