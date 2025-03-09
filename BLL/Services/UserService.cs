using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Entities;
using Common.Repositories;

namespace BLL.Services
{
    public class UserService : IUserRepository<User>
    {
        private IUserRepository<DAL.Entities.User> _userService;

        public UserService(
           IUserRepository<DAL.Entities.User> userService)
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

        public User Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public Guid Insert(User entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Guid id, User entity)
        {
            throw new NotImplementedException();
        }
    }
}
