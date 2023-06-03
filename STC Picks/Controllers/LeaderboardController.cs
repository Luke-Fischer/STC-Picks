using Microsoft.AspNetCore.Mvc;
using STC_Picks.Data;
using STC_Picks.Models;
using System.Diagnostics;

namespace STC_Picks.Controllers
{
    public class LeaderboardController : Controller
    {
        private STCDbContext _db;
        public LeaderboardController(STCDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<User> userList = _db.Users.OrderByDescending(sp => sp.score).ToList();
            return View(userList);
        }
        public IActionResult ViewPicks(string? id)
        {
            if (id != null){
                User user = _db.Users.Find(id);
                return View(user);
            }
            else
            {
                return NotFound();
            }
        }
    }
}
