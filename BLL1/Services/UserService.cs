using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL1.Entities;
using BLL1.Mappers;
using Common.Repositories;

namespace BLL1.Services
{
    public class UserService : IUserRepository<User>
    {
        private IUserRepository<DAL1.Entities.User> _userService;

        public UserService(
           IUserRepository<DAL1.Entities.User> userService)
        {
            _userService = userService;
        }
        public Guid CheckPassword(string email, string password)
        {
            return _userService.CheckPassword(email, password);
        }

        public void Delete(Guid user_id)
        {
            _userService.Delete(user_id);
        }
        public IEnumerable<User> Get()
        {
            throw new NotImplementedException();
        }

        public User Get(Guid user_id)
        {
            User user = _userService.Get(user_id).ToBLL();
            return user;
        }

        public Guid Insert(User user)
        {
            return _userService.Insert(user.ToDAL());
        }

        public void Update(Guid user_id, User user)
        {
            _userService.Update(user_id, user.ToDAL());
        }
    }
}
