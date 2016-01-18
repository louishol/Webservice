using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Webserives.Models
{
    public class Competition
    {
        public int ID { get; set; }
        public String Name { get; set;}
        public virtual ICollection<Team> Teams { get; set; }
        public virtual Country Country { get; set; }
    }
}