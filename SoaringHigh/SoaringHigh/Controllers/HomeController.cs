using SoaringHigh.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SoaringHigh.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<ImageModel> imageList = new List<ImageModel>();

            imageList.Add(new ImageModel { ImageID = 1, ImageName = "Image 1", ImagePath = "/img/sky-full-colorful-hot-air-balloons_315169.jpg" });
            imageList.Add(new ImageModel { ImageID = 2, ImageName = "Image 2", ImagePath = "/img/hotairballoonmountain.jpg" });
            imageList.Add(new ImageModel { ImageID = 3, ImageName = "Image 3", ImagePath = "/img/hotairballoonlaketahoe.jpg" });
            imageList.Add(new ImageModel { ImageID = 4, ImageName = "Image 4", ImagePath = "/img/hotairballoonreflection.jpg" });
            imageList.Add(new ImageModel { ImageID = 5, ImageName = "Image 5", ImagePath = "/img/hotairballoon_animals.jpg" });

            return View(imageList);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Soaring High.";

            return View();
        }

        public ActionResult History()
        {
            ViewBag.Message = "History.";

            return View();
        }

        public ActionResult Events()
        {
            ViewBag.Message = "Events.";

            return View();
        }

        public ActionResult Rides()
        {
            ViewBag.Message = "Ride Vendors.";

            return View();
        }

        public ActionResult LaunchCriteria()
        {
            ViewBag.Message = "LaunchCriteria.";

            return View();
        }


        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

    }
}