﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Webserives.Models
{
    public class Team
    {
        public int ID { get; set; }
        public String Name
        {
            get; set;
        }
        public int Position { get; set; }
        public virtual ICollection<Player> Players { get; set; }

    }
}