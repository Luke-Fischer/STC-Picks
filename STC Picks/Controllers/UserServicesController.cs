using Microsoft.AspNetCore.Mvc;
using STC_Picks.Data;
using STC_Picks.Models;
using System;
using System.Diagnostics;
using System.Security.Cryptography;

namespace STC_Picks.Controllers
{
	public class UserServicesController : Controller
	{
        public static string key;
        private STCDbContext _db;
        public UserServicesController(STCDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
		{
			return View();
		}
        public IActionResult InvalidUser(User user)
        {
            ViewBag.ErrorMessage = user.fullName + " has already entered picks. To edit your picks please use the \"Edit Picks\" button located on the home page. If you forgot your access key please email lukefischer959@gmail.com";
            return View(user);
        }
        [HttpPost]
        public IActionResult ValidateEntrant(User user)
        {
            user.fullName = user.firstName.Trim() + " " + user.lastName.Trim();
            user.score = 16;
            var userList = _db.Users.ToList();
            if (userList.Count() > 0)
            {
                foreach (User userInstance in userList)
                {
                    if (user.fullName.ToLower() == userInstance.fullName.ToLower())
                    {
                        return RedirectToAction("InvalidUser", user);
                    }
                }
            }
            //Valid user and submission
            user.accessCode = randomAccessKey();
            _db.Users.Add(user);
            _db.SaveChanges();
            return RedirectToAction("Confirmation", user);
        }
        public IActionResult Confirmation(User user)
        {
            return View(user);
        }
        public string randomAccessKey()
        {
            string accessKey = " ";
            for(int i = 0; i < 7; i++)
            {
                accessKey += RandomNumberGenerator.GetInt32(0, 9).ToString();
            }
            return accessKey;
        }
        public IActionResult EditLogin()
        {
            return View();
        }
        public IActionResult EditLoginFailure(User user)
        {
            if(user.accessCode == null)
            {
                ViewBag.ErrorMessage = "Please enter an access key";
                return View(user);
            }
            var userList = _db.Users.ToList();
            foreach(User keyUser in userList)
            {
                if (keyUser.accessCode.Trim() == user.accessCode.Trim())
                {
                    key = keyUser.fullName;
                    return RedirectToAction("EditPicks", keyUser);
                }
            }
            ViewBag.ErrorMessage = "Not a valid access key.";
            return View(user);
        }

        [ResponseCache(Duration = 30, NoStore = true)]
        public IActionResult EditPicks(User user)
        {
            return View(user);
        }
        
        [ResponseCache(Duration = 30, NoStore = true)]
        public IActionResult UpdatedPicks(User user)
        {
            User currentUser = _db.Users.Find(keyValues: key);
            //Update user
            if (currentUser != null)
            {
                currentUser.male1 = user.male1;
                currentUser.male2 = user.male2;
                currentUser.male3 = user.male3;
                currentUser.male4 = user.male4;
                currentUser.male5 = user.male5;
                currentUser.male6 = user.male6;
                currentUser.male7 = user.male7;
                currentUser.male8 = user.male8;
                currentUser.female1 = user.female1;
                currentUser.female2 = user.female2;
                currentUser.female3 = user.female3;
                currentUser.female4 = user.female4;
                currentUser.female5 = user.female5;
                currentUser.female6 = user.female6;
                currentUser.female7 = user.female7;
                currentUser.female8 = user.female8;

                _db.Users.Update(currentUser);
                _db.SaveChanges();
                TempData["success"] = "Updated Successfully";
                
                return RedirectToAction("EditPicks", currentUser);
            }
            else
            {
                return NotFound();
            }
        }
    }
}
