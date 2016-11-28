using CalendarNotes.Common.Models;
using CalendarNotes.Core.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalendarNotes.Core.Services
{
    public interface IUserService
    {
        string GetFullUserName(int userId);
        User GetUser(int userId);
    }
    public class UserService : IUserService
    {
        private IGenericRepo<User> _userRepo;
        public UserService(IGenericRepo<User> userRepo)
        {
            _userRepo = userRepo;
        }
        public string GetFullUserName(int userId)
        {
            User user = _userRepo.Single(x=>x.Id == userId);
            return user.FirstName + " " + user.LastName;
        }

        public User GetUser(int userId)
        {
            return _userRepo.Single(x => x.Id == userId);            
        }
    }
}
