using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Repositories;
using DAL.Entities;
using DAL.Services;
using Microsoft.Extensions.Configuration;
using DAL.Mappers;


namespace DAL.Services
{
    public class UserService : BaseService, IUserRepository<DAL.Entities.User>
    {
        public UserService(IConfiguration config) : base(config, "Main-DB") { }
        public Guid CheckPassword(string email, string password)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "sp_CheckPassword";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue(nameof(email), email);
                    command.Parameters.AddWithValue(nameof(password), password);
                    connection.Open();
                    return (Guid)command.ExecuteScalar();
                }
            }
        }

        public void Delete(Guid id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_User_Delete";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue(nameof(id), id);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public IEnumerable<User> Get()
        {
            throw new NotImplementedException();
        }

        public User Get(Guid id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "sp_GetUserById";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue(nameof(id), id);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader.ToUser();
                        }
                        else
                        {
                            throw new ArgumentOutOfRangeException(nameof(id));
                        }
                    }
                }
            }
        }

        public Guid Insert(User user)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "sp_CreateUser";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue(nameof(User.First_Name), user.First_Name);
                    command.Parameters.AddWithValue(nameof(User.Last_Name), user.Last_Name);
                    command.Parameters.AddWithValue(nameof(User.Email), user.Email);
                    command.Parameters.AddWithValue(nameof(User.Password), user.Password);
                    connection.Open();
                    return (Guid)command.ExecuteScalar();
                }
            }
        }

        public void Update(Guid id, User user)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "sp_UpdateUser";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue(nameof(id), id);
                    command.Parameters.AddWithValue(nameof(User.First_Name), user.First_Name);
                    command.Parameters.AddWithValue(nameof(User.Last_Name), user.Last_Name);
                    command.Parameters.AddWithValue(nameof(User.Email), user.Email);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
