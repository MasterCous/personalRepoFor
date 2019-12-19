using HomeWork2._2.Models;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace HomeWork2._2.Controllers
{
    public class MobileController : Controller
    {
        // GET: Mobile
        public ActionResult MobileView()
        {
            List<MobileModel> mobile = new List<MobileModel>();
            mobile.Add(new MobileModel
            {
                Id = 1,
                Name = "IPhone",
                Model = "7",
                Description = "Best of the best",
                Price = 699.50m,
                DateCreate = DateTime.Now

            });
            mobile.Add(new MobileModel
            {
                Id = 2,
                Name = "IPhone",
                Model = "8",
                Description = "Best of the best(or not)",
                Price = 799.50m,
                DateCreate = DateTime.Now

            });
            mobile.Add(new MobileModel
            {
                Id = 3,
                Name = "IPhone",
                Model = "8 Plus",
                Description = "Best of the best(100%)",
                Price = 899.50m,
                DateCreate = DateTime.Now

            });
            mobile.Add(new MobileModel
            {
                Id = 4,
                Name = "IPhone",
                Model = "10",
                Description = "не очень =) если честно говоря",
                Price = 999.50m,
                DateCreate = DateTime.Now

            });
            mobile.Add(new MobileModel
            {
                Id = 5,
                Name = "IPhone",
                Model = "10 Max",
                Description = "Best of the best",
                Price = 1099.50m,
                DateCreate = DateTime.Now

            });
            mobile.Add(new MobileModel
            {
                Id = 6,
                Name = "IPhone",
                Model = "XS Max",
                Description = "Best of the best",
                Price = 1199.50m,
                DateCreate = DateTime.Now

            });

            return View(mobile);
        }
    }
}