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
        public static List<AddLocationDetailsToDatabase> dataFromControllerToView;
        public static List<AddLocationDetailsToDatabase> locationDetailsFromDatabases;
        AddLocationDetailsToDatabase addLocationDetailsToDatabase = new AddLocationDetailsToDatabase();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            using (ISession session1 = NHibernateHelper.OpenSession())
            {
                var result = session1.QueryOver<AddLocationDetailsToDatabase>().List();
                locationDetailsFromDatabases = new List<AddLocationDetailsToDatabase>(result);
            }
            return View(new AddLocation());

        }

        [HttpPost]
        public IActionResult Index(AddLocation addLocation)
        {

            int count = 0;
            using (ISession session2 = NHibernateHelper.OpenSession())
            {
                var details = session2.QueryOver<AddLocationDetailsToDatabase>().List();
                count = details.Count + 1;
            }
            addLocationDetailsToDatabase.id = count;
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

            using (ISession session1 = NHibernateHelper.OpenSession())
            {
                var result = session1.QueryOver<AddLocationDetailsToDatabase>().List();
                locationDetailsFromDatabases = new List<AddLocationDetailsToDatabase>(result);
            }
            return View();
        }

        
        [HttpPost]
        [ActionName("Location")]
        public string Post(string locationName, double latitudeValue, double longitudeValue)
        {
            int count = 0;
            using (ISession session2 = NHibernateHelper.OpenSession())
            {
                var details = session2.QueryOver<AddLocationDetailsToDatabase>().List();
                count = details.Count + 1;
            }

            addLocationDetailsToDatabase.id = count;
            addLocationDetailsToDatabase.Name = locationName;
            addLocationDetailsToDatabase.Latitude = latitudeValue;
            addLocationDetailsToDatabase.Longitude = longitudeValue;
            
            using (ISession session = NHibernateHelper.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Save(addLocationDetailsToDatabase);
                    transaction.Commit();
                }
            }
            return "success";
        }

        [HttpGet]
        [ActionName("GetLocationDetails")]
        public IEnumerable<AddLocationDetailsToDatabase> Get()
        {
            using (ISession session1 = NHibernateHelper.OpenSession())
            {
                var result = session1.QueryOver<AddLocationDetailsToDatabase>().List();
                return result;
            }
        }
    }
}
