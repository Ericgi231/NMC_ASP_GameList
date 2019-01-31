using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GameList.Models;

namespace GameList.Controllers
{
    public class GameController : Controller
    {
        // GET: Form
        [HttpPost]
        public ActionResult Add(string name, string developer, string genre, DateTime releaseDate)
        {
            Game Game = new Models.Game()
            {
                Name = name,
                Developer = developer,
                Genre = genre,
                ReleaseDate = releaseDate
            };
            GameContainer.Games.Add(Game);
            ViewBag.Message = Game.Name + " has been added to the list.";
            return View("SucPage");
        }

        public ActionResult Add()
        {
            return View();
        }

        public ActionResult List(bool raw = false)
        {
            if (raw)
                return View("Raw", GameContainer.Games);
            else
                return View(GameContainer.Games);
        }

        [HttpPost]
        public ActionResult RateGame(string gameName, double score = 0)
        {
            try
            {
                GameContainer.Games.SingleOrDefault(i => i.Name == gameName).Score = score;
            }
            catch (Exception)
            {
                return View("RateGameError");
            }
            Game selectedGame = GameContainer.Games.SingleOrDefault(i => i.Name == gameName);
            return View(selectedGame);
        }

        public ActionResult RateGame()
        {
            return View();
        }
    }
}