using System.Collections.Generic;
using System.Linq;
using CalendarNotes.Core.Repos;
using CalendarNotes.Common.Models;

namespace CalendarNotes.Core.Services
{
    public interface IUserNoteService
    {
        int AddUserNote(UserNote userNote);
        UserNote GetUserNote(int userNoteId);
        List<UserNote> GetuserNotes(int userId);
    }
    public class UserNoteService : IUserNoteService
    {
        private readonly IGenericRepo<UserNote> _userNoteRepo;
        public UserNoteService(IGenericRepo<UserNote> userNoteRepo)
        {
            _userNoteRepo = userNoteRepo;
        }

        public int AddUserNote(UserNote userNote)
        {
            _userNoteRepo.Add(userNote);
            return _userNoteRepo.Commit();
        }

        public UserNote GetUserNote(int userNoteId)
        {
            return _userNoteRepo.Single(x=> x.UserNoteId == userNoteId);
        }

        public List<UserNote> GetuserNotes(int userId)
        {
            return _userNoteRepo.Where(x => x.UserId == userId).ToList();
        }
    }
}
