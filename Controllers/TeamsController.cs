using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using Newtonsoft.Json;
using Aerospace.Models;



namespace Aerospace.Controllers
{
    public class TeamsController : Controller
    {
        // GET LATEST TEAM
        //public ActionResult Reading_teamsJson()
        //{
            

        //}


        public ActionResult Index()
        {
            string jsonPath = Server.MapPath("~/App_Data/teams.json"); //find better solution
            string jsonData = System.IO.File.ReadAllText(jsonPath);

            Dictionary<string, List<Teams>> TeamsDict = JsonConvert.DeserializeObject<Dictionary<string, List<Teams>>>(jsonData);

            string firstKey = TeamsDict.Keys.FirstOrDefault();

            if (firstKey != null)
            {
               
                return View(TeamsDict[firstKey]);

            }
            else
            {
                return View();
            }

            
        }

        public ActionResult Team_2023()
        {
            return View();
        }

    }
}