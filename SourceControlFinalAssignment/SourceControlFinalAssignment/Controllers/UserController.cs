using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SourceControlFinalAssignment.DBContext;
using SourceControlFinalAssignment.Models;

namespace SourceControlFinalAssignment.Controllers
{
    public class UserController : Controller 
    { 

        private readonly ApplicationDbContext _db;
    public UserController(ApplicationDbContext db)
    {
        _db = db;
    }
    
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Dashboard(User user)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(UserLogin userLogin)
        {
            if (ModelState.IsValid)
            {
                var users = _db.Users.ToList();

                foreach (var user in users)
                {
                    if(user.Email == userLogin.Email && user.Password == userLogin.Password)
                    {
                        return RedirectToAction("Dashboard", user);
                    }
                }
                ModelState.AddModelError("NotFound", "Email or Password is invalid");
            }
                return View(userLogin);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Signup(UserSignUp userSignUp)
        {
            if(ModelState.IsValid)
            {
                var users = _db.Users.ToList();

                foreach (var user in users)
                {
                    if (user.Email == userSignUp.Email)
                    {
                        ModelState.AddModelError("EmailExists", "Email already exists");
                        return View(userSignUp);
                    }
                }

                var myUser = new User
                {
                    FirstName = userSignUp.FirstName,
                    LastName = userSignUp.LastName,
                    PhoneNo = userSignUp.PhoneNo,
                    Email = userSignUp.Email,
                    Password = userSignUp.Password,
                };

                _db.Users.Add(myUser);
                _db.SaveChanges();
                return RedirectToAction("Dashboard");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Signup()
        {
            return View();
        }
    }
}
