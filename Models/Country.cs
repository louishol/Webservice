using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Webserives.Models
{
    public class Country
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public List<Competition> Competitions { get; set; }
    }
}