﻿using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class CartController : Controller
    {
        public IActionResult CartPage()
        {
            return View();
        }
    }
}