using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.DynamicData.ModelProviders;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using LineChart_Implementation.Models;
namespace LineChart_Implementation.Controllers
{
    public class GoogleChartController : Controller
    {
        // GET: GoogleChart
        public ActionResult Index()
        {
            //GetChartData();
            return View();
        }


        public JsonResult GetChartData() 
        {
            List<GoogleChartData> data = new List<GoogleChartData>();
            //Here MyDatabaseEntities  is our dbContext
            //using (UsersDBEntities1 dc = new UsersDBEntities1())
            //{
            //    data = dc.GoogleChartDatas.ToList();
            //}
            data = DataProviderService.GetGoogleChartDatas();

            var chartData = new object[data.Count + 1];
            chartData[0] = new object[]{
                "Year",
                "Electronics",
                "Books & Media",
                "Home & Kitchen"
            };

            int j = 0;
            foreach (var i in data)
            {
                j++;
                chartData[j] = new object[] { i.Year.ToString(), i.Electronics, i.BookAndMedia, i.HomeAndKitchen };
            }

            return new JsonResult { Data = chartData.ToArray(), JsonRequestBehavior = JsonRequestBehavior.AllowGet };

        }

    }
 }
