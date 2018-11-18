using Microsoft.AspNetCore.Mvc;
using OdeToFood.Models;
using OdeToFood.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Controllers
{
    public class HomeController  : Controller
    {
        private IRestautantData _restautantData;
        public HomeController(IRestautantData restautantData)
        {
            _restautantData = restautantData;
        }
        public IActionResult Index()
        {
            var model = _restautantData.GetAll();
          

            return View(model);
        }
    }
}
