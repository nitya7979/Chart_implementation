using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LineChart_Implementation.Models;
using Newtonsoft.Json;

namespace LineChart_Implementation.Controllers
{
    public class HomeController : Controller
    {
		// GET: Home
		public ActionResult Index()
		{
			List<DataPoint> dataPoints1 = new List<DataPoint>();
			List<DataPoint> dataPoints2 = new List<DataPoint>();
			List<DataPoint> dataPoints3 = new List<DataPoint>();

			dataPoints1.Add(new DataPoint("Jan", 72));
			dataPoints1.Add(new DataPoint("Feb", 67));
			dataPoints1.Add(new DataPoint("Mar", 55));
			dataPoints1.Add(new DataPoint("Apr", 42));
			dataPoints1.Add(new DataPoint("May", 40));
			dataPoints1.Add(new DataPoint("Jun", 35));

			dataPoints2.Add(new DataPoint("Jan", 48));
			dataPoints2.Add(new DataPoint("Feb", 56));
			dataPoints2.Add(new DataPoint("Mar", 50));
			dataPoints2.Add(new DataPoint("Apr", 47));
			dataPoints2.Add(new DataPoint("May", 65));
			dataPoints2.Add(new DataPoint("Jun", 69));

			dataPoints3.Add(new DataPoint("Jan", 38));
			dataPoints3.Add(new DataPoint("Feb", 46));
			dataPoints3.Add(new DataPoint("Mar", 55));
			dataPoints3.Add(new DataPoint("Apr", 70));
			dataPoints3.Add(new DataPoint("May", 77));
			dataPoints3.Add(new DataPoint("Jun", 91));

			ViewBag.DataPoints1 = JsonConvert.SerializeObject(dataPoints1);
			ViewBag.DataPoints2 = JsonConvert.SerializeObject(dataPoints2);
			ViewBag.DataPoints3 = JsonConvert.SerializeObject(dataPoints3);

			return View();
		}

		public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}