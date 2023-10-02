using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.Web.Script.Serialization;


namespace Aerospace.Models
{
    public class Teams
    {
        public string Name { get; set; }
        public string Role { get; set; }
        public string Group { get; set; }

        Dictionary<int, List<Teams>> TeamsDict = new Dictionary<int, List<Teams>>();


    }
}