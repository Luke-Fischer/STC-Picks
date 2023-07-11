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
        public IActionResult Adam()
        {
            TiebreakerPicks Tpicks = new TiebreakerPicks();
            Tpicks.MensSemiOne = "C. ALCARAZ (1)";
            Tpicks.MensSemiTwo = "D. MEDVEDEV (3)";
            Tpicks.MensSemiThree = "J. SINNER (8)";
            Tpicks.MensSemiFour = "N. DJOKOVIC (2)";
            Tpicks.WomensSemiOne = "I. SWIATEK (1)";
            Tpicks.WomensSemiTwo = "J. PEGULA (4)";
            Tpicks.WomensSemiThree = "E. RYBAKINA (3)";
            Tpicks.WomensSemiFour = "A. SABALENKA (2)";
            return View();
        }
        public IActionResult Will()
        {
            return View();
        }
        public IActionResult Shaun()
        {
            return View();
        }
    }
}
