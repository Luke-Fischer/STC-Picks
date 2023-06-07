using Microsoft.AspNetCore.Mvc;
using STC_Picks.Data;
using STC_Picks.Models;

namespace STC_Picks.Controllers
{
    public class AdminServicesController : Controller
    {
        private STCDbContext _db;
        public AdminServicesController(STCDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult UpdateScores()
        {
            Eliminated inst = new Eliminated();
            var userList = _db.Users.ToList();
            foreach(User user in userList)
            {
                int numElim = 0;
                if (inst.IsEliminated(user.male1) == 1)
                {
                    numElim++;
                }
                if (inst.IsEliminated(user.male2) == 1)
                {
                    numElim++;
                }
                if (inst.IsEliminated(user.male3) == 1)
                {
                    numElim++;
                }
                if (inst.IsEliminated(user.male4) == 1)
                {
                    numElim++;
                }
                if (inst.IsEliminated(user.male5) == 1)
                {
                    numElim++;
                }
                if (inst.IsEliminated(user.male6) == 1)
                {
                    numElim++;
                }
                if (inst.IsEliminated(user.male7) == 1)
                {
                    numElim++;
                }
                if (inst.IsEliminated(user.male8) == 1)
                {
                    numElim++;
                }
                if (inst.IsEliminated(user.female1) == 1)
                {
                    numElim++;
                }
                if (inst.IsEliminated(user.female2) == 1)
                {
                    numElim++;
                }
                if (inst.IsEliminated(user.female3) == 1)
                {
                    numElim++;
                }
                if (inst.IsEliminated(user.female4) == 1)
                {
                    numElim++;
                }
                if (inst.IsEliminated(user.female5) == 1)
                {
                    numElim++;
                }
                if (inst.IsEliminated(user.female6) == 1)
                {
                    numElim++;
                }
                if (inst.IsEliminated(user.female7) == 1)
                {
                    numElim++;
                }
                if (inst.IsEliminated(user.female8) == 1)
                {
                    numElim++;
                }
                user.score = 16 - numElim;
                _db.Update(user);
                _db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
