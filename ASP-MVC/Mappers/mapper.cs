using ASP_MVC.Models.User;
using BLL1.Entities;

namespace ASP_MVC.Mappers
{
    public static class mapper
    {

        public static UserDetails ToDetails(this User user)
        {
            if (user is null) throw new ArgumentNullException(nameof(user));
            return new UserDetails()
            {
                User_Id = user.User_Id,
                First_Name = user.First_Name,
                Last_Name = user.Last_Name,
                Email = user.Email,
                Date = user.CreatedAt,
                
            };
        }

    }
}
