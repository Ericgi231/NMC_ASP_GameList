using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameList.Models
{
    public static class GameContainer
    {
        public static List<Game> Games { get; set; } = new List<Game>();
    }
}