using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using CalendarNotes.Common.Models;
using CalendarNotes.Core.Services;
using Microsoft.AspNetCore.Identity;
using CalendarNotes.Web.ExtentionMethod;

namespace CalendarNotes.Web.Controllers
{
    [Authorize]
    public class UserNoteController : Controller
    {
        private IUserNoteService _userNoteService;
        private readonly UserManager<User> _userManager;
        
        public UserNoteController(IUserNoteService userNoteService, UserManager<User> userManager)
        {
            _userNoteService = userNoteService;
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(UserNote userNote)
        {
            int userId = User.GetUserId().Value;
            if (ModelState.IsValid)
            {
                userNote.UserId = userId;
                _userNoteService.AddUserNote(userNote);
                List<UserNote> userNotes = _userNoteService.GetuserNotes(userId);
                return View("../Home/Index",userNotes);
            }
            return View();
        }
    }
}