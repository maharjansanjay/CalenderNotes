using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CalendarNotes.Common.Models;
using CalendarNotes.Web.ExtentionMethod;
using CalendarNotes.Core.Services;
using Microsoft.AspNetCore.Identity;

namespace CalendarNotes.Web.Controllers
{
    public class HomeController : Controller
    {
        private IUserNoteService _userNoteService;
        private IUserService _userService;
        public HomeController(IUserNoteService userNoteService,IUserService userService)
        {
            _userNoteService = userNoteService;
            _userService = userService;          
        }
        public IActionResult Index()
        {
            int? userId = User.Identity.GetUserId();
            List<UserNote> userNotes = new List<UserNote>();
            if (userId.HasValue)
            {
                //ViewBag.UserName = _userService.GetFullUserName(userId.Value);
                ViewBag.UserName = User.Identity.GetUserFullName();
                userNotes = _userNoteService.GetuserNotes(userId.Value);
            }            
            return View(userNotes);

        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
