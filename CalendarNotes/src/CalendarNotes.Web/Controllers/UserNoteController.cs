using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using CalendarNotes.Common.Models;
using CalendarNotes.Core.Services;
using CalendarNotes.Web.ExtentionMethod;

namespace CalendarNotes.Web.Controllers
{
    [Authorize]
    public class UserNoteController : Controller
    {
        private readonly IUserNoteService _userNoteService;
        
        public UserNoteController(IUserNoteService userNoteService)
        {
            _userNoteService = userNoteService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(UserNote userNote)
        {
            var id = User.GetUserId();
            if (id != null)
            {
                int userId = id.Value;
                if (ModelState.IsValid)
                {
                    userNote.UserId = userId;
                    _userNoteService.AddUserNote(userNote);
                    List<UserNote> userNotes = _userNoteService.GetuserNotes(userId);
                    return View("../Home/Index",userNotes);
                }
            }
            return View();
        }
    }
}