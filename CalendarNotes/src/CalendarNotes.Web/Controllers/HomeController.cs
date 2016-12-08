using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using CalendarNotes.Common.Models;
using CalendarNotes.Web.ExtentionMethod;
using CalendarNotes.Core.Services;

namespace CalendarNotes.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserNoteService _userNoteService;
        public HomeController(IUserNoteService userNoteService)
        {
            _userNoteService = userNoteService;
        }
        public IActionResult Index()
        {
            int? userId = User.Identity.GetUserId();
            List<UserNote> userNotes = new List<UserNote>();
            if (userId.HasValue)
            {
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
