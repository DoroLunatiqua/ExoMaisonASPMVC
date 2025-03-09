using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL1.Entities;
using D = DAL1.Entities;
namespace BLL1.Mappers
{
    internal static class mapper
    {
        public static User ToBLL(this D.User user)
        {
            if (user is null) throw new ArgumentNullException(nameof(user));
            return new User(
                user.User_Id,
                user.First_Name,
                user.Last_Name,
                user.Email,
                user.Password,
                user.CreatedAt
                );
               
        }

        public static D.User ToDAL(this User user)
        {
            if (user is null) throw new ArgumentNullException(nameof(user));
            return new D.User()
            {
                User_Id = user.User_Id,
                First_Name = user.First_Name,
                Last_Name = user.Last_Name,
                Email = user.Email,
                Password = user.Password,
                CreatedAt = user.CreatedAt,
               
                
            };
        }
    }
}
