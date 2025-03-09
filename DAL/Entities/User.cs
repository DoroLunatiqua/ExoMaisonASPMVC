using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class User
    {

    public Guid User_Id { get; set; }
    public string First_Name { get; set; }
    public string Last_Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public Guid Salt { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? DisabledAt { get; set; }
        public User(string v1, string v2, Guid guid)
        {
        }

        public User()
        {
        }
    }
    
    
}
