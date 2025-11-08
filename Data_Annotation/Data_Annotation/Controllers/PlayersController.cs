using Microsoft.AspNetCore.Mvc;
using MyApp.Models;
using System.Collections.Generic;

namespace MyApp.Controllers
{
    public class PlayersController : Controller
    {
        // Temp in-memory store for example; in production use DB
        private static readonly List<Player> _players = new List<Player>();

        // GET: /Players/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: /Players/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Player player)
        {
            // Model binding happens before this and DataAnnotations are evaluated.
            if (!ModelState.IsValid)
            {
                // If validation failed, return the same view with the model so validation messages are displayed.
                return View(player);
            }

            // Simulate saving to DB
            player.Id = _players.Count + 1;
            _players.Add(player);

            // Redirect after POST to avoid resubmission; could go to Details/Index.
            return RedirectToAction(nameof(Index));
        }

        // GET: /Players
        public IActionResult Index()
        {
            return View(_players);
        }
    }
}
