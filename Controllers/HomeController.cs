using MapsApplication.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MapsApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(new AddLocation());

        }

        [HttpPost]
        public IActionResult Index(AddLocation addLocation)
        {
            AddLocationDetailsToDatabase addLocationDetailsToDatabase = new AddLocationDetailsToDatabase();
            addLocationDetailsToDatabase.Name = addLocation.Name;
            addLocationDetailsToDatabase.Latitude = addLocation.Latitude;
            addLocationDetailsToDatabase.Longitude = addLocation.Longitude;
            
            using (ISession session = NHibernateHelper.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Save(addLocationDetailsToDatabase);
                    transaction.Commit();
                }
            }
            
            return View();
        }



        
        
    }
}
