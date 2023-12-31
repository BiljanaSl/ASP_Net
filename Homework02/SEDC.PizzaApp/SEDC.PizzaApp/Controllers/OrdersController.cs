﻿using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.Models;

namespace SEDC.PizzaApp.Controllers
{

    [Route("ListOrders")]
    public class OrdersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet("Details/{id?}")]
        public IActionResult Details(int? id)
        {
            if (id == null) 
            { 
                return new EmptyResult();
            }

            return View();
        }


        [HttpGet("JsonData")]
        public IActionResult JsonDataDetails()
        {
                Pizza pizza = new Pizza()
                {
                    Id = 1,
                    Name = "Margarita",
                    Price = 15,
                    IsOnPromotion = true

                };
                return new JsonResult(pizza);
        }





    }
}
