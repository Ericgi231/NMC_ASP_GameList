using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameList.Models
{
    public class Game
    {
        public string Name { get; set; }
        public string Genre { get; set; }
        public string Developer { get; set; } 
        public DateTime ReleaseDate { get; set; }
        public Double Score { get; set; }
    }
}