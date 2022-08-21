using _17318905_HW04.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace _17318905_HW04.Controllers
{
    public class HomeController : Controller
    {

        //Admin Password
        private static string Username = "ZAZA";
        private static string SitePassword = "juju";
        //Declare Conservation List
        public static List<Conservation> OrgConservation = new List<Conservation>();
        //Declare OceanCleanup List
        public static List<OceanCleanup> OrgCleanup = new List<OceanCleanup>();
        //Declare Marine Wildlife List
        public static List<MarineWildlife> OrgWildlife = new List<MarineWildlife>();

        private void InitialiseGallery()
        {
            if (OrgGallery.Count() == 0)
            {
                //Conservation Organisation Items
                OrgConservation.Add(new Conservation(1, "Pure Ocean", 2017, "~/Logos/OrgLogo/Conservation1.jpg", "Everyone", "Conservation",
                    "support state-of-the-art applied research projects to conserve marine biodiversity, protect and restore fragile marine ecosystems and increase knowledge of the oceans and contribute to the fight against climate change."));
                OrgConservation.Add(new Conservation(2, "OceansWatch", 2007, "~/Logos/OrgLogo/Conservation1.jpg", "Rufford Foundation", "Conservation",
                    "OceansWatch works in partnership with coastal communities to develop conservation action plans, sustainable livelihood projects and help communities mitigate and adapt to the effects of climate change."));


                //Ocean Cleanup Organisation Items
                OrgCleanup.Add(new OceanCleanup(3, "The Ocean Cleanup", 2013, "~/Logos/OrgLogo/Cleanup1.jpg", "Maersk", "Cleanup", "To remove 90 % of floating ocean plastic, which requires global initiative",
                    "developing and scaling technologies to rid the oceans of plastic.", "Cleaning the Ocean and Intercepting in Rivers"));
                OrgCleanup.Add(new OceanCleanup(4, "Surfers Against Sewage", 1990, "~/Logos/OrgLogo/Cleanup1.jpg", "Trusts and Foundations", "Cleanup", "Increase awareness of and clean beaches and seas",
                    "Building a community through education, volunteering, beach cleans, campaigns, parliamentary events and advocacy to create the change we want to see for the future.", "Multiple Community Projects."));

                //Marine Wildlife Items
                OrgWildlife.Add(new MarineWildlife(5, "Marine Stewardship Council", 1997, "~/Logos/OrgLogo/Preservation2.jpg", "Charitable Activities and Donations", "Wildlife",
                    "Work with fisheries, scientists and industry to make sure our oceans are fished sustainably and it’s easy to find and buy certified sustainable seafood.",
                    "Application of the Theory of Change"));
                OrgWildlife.Add(new MarineWildlife(6, "Ocean Conservancy", 1972, "~/Logos/OrgLogo/Preservation2.jpg", "Columbia", "Wildlife", "We envision a healthier ocean, protected by a more just world.",
                    "Ocean Conservancy is working with you to protect the ocean from today’s greatest global challenges. Together, we create evidence-based solutions for a healthy ocean and the wildlife and communities that depend on it."));

                //Populate Gallery
                OrgGallery.AddRange(OrgConservation);
                OrgGallery.AddRange(OrgCleanup);
                OrgGallery.AddRange(OrgWildlife);
            }
            else
            {
                OrgGallery.Clear();
                OrgGallery.AddRange(OrgConservation);
                OrgGallery.AddRange(OrgCleanup);
                OrgGallery.AddRange(OrgWildlife);
                return;
            }
        }

        public ActionResult Home()
        {
            InitialiseGallery();
            return View(OrgGallery);
        }


        //Conservation Items
        [HttpGet]
        public ActionResult ConservationIndex()
        {
            return View(OrgConservation);
        }

        [HttpGet]
        public ActionResult AddOrgConservationToGallery()
        {
            return View(OrgConservation);
        }
        [HttpPost]
        public ActionResult AddOrgConservationToGallery(Conservation data)
        {
            //Add new data
            OrgConservation.Add(data);
            //Send new data to gallery
            return RedirectToAction("Home");
        }

        //Cleanup Items


        [HttpGet]
        public ActionResult CleanupIndex()
        {

            return View(OrgCleanup);
        }
        [HttpGet]
        public ActionResult AddOrgCleanupToGallery()
        {

            return View(OrgCleanup);
        }

        [HttpPost]
        public ActionResult AddOrgCleanupToGallery(OceanCleanup data)
        {
            OrgCleanup.Add(data);
            return View();
        }


        [HttpGet]
        public ActionResult WildlifeIndex()
        {
            return View(OrgWildlife);
        }


        [HttpGet]
        public ActionResult AddOrgWildlifeToGallery()
        {
            return View(OrgWildlife);
        }
        [HttpPost]
        public ActionResult AddOrgWildlifeToGallery(MarineWildlife data)
        {
            OrgWildlife.Add(data);
            return View();
        }

        //Login
        [HttpGet]
    public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string Username, string Password)
        {
            if(Password== SitePassword)
            {
                return RedirectToAction("AdminPage");
            }
            else
            {
                ViewBag.Message = "You do not have access";
                return View();
            }
            
        }

        [HttpGet]
        public ActionResult AdminPage()
        {
            return View();
        }


        //Declare Org List
        public static List<Organisation> OrgGallery = new List<Organisation>();
    }
    
    

}