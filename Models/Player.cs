using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Webserives.Models
{
    public enum Position
    {
        Attack,
        Midfielder,
        Defense
    }
    public class Player
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public int Age { get; set; }
        public int Number { get; set; }
        public Position Position { get; set; }
        public virtual Team Team { get; set; }

    }
}