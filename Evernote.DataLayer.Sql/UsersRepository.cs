using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Evernote.Model;
namespace Evernote.DataLayer.Sql
{
    public class UsersRepository : IUsersRepository
    {
        private readonly string _connectionString;
        private readonly ICategoriesRepository _categoriesRepository;

        public UsersRepository(string connectionString, ICategoriesRepository categoriesRepository)
        {
            _connectionString = connectionString;
            _categoriesRepository = categoriesRepository;
        }

        public User Create(User user)
        {
            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                sqlConnection.Open();
                using (var command = sqlConnection.CreateCommand())
                {
                    user.Id = Guid.NewGuid();
                    command.CommandText = "insert into [User] (id, firstName, lastName, login, password) values (@id, @firstName, @lastName, @login, @password)";
                    command.Parameters.AddWithValue("@id", user.Id);
                    command.Parameters.AddWithValue("@firstName", user.FirstName);
                    command.Parameters.AddWithValue("@lastName", user.LastName);
                    command.Parameters.AddWithValue("@login", user.Login);
                    command.Parameters.AddWithValue("@password", user.Password);
                    command.ExecuteNonQuery();
                    return user;
                }
            }
        }

        public void Delete(Guid id)
        {
            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                sqlConnection.Open();
                using (var command = sqlConnection.CreateCommand())
                {
                    command.CommandText = "delete from [User] where id = @id";
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public User Get(Guid id)
        {
            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                sqlConnection.Open();
                using (var command = sqlConnection.CreateCommand())
                {
                    command.CommandText = "select *from [User] where id = @id";
                    command.Parameters.AddWithValue("@id", id);

                    using (var reader = command.ExecuteReader())
                    {
                        if (!reader.Read())
                            throw new ArgumentException($"Пользователь с id {id} не найден");

                        var user = new User
                        {
                            Id = reader.GetGuid(reader.GetOrdinal("id")),
                            FirstName = reader.GetString(reader.GetOrdinal("firstName")),
                            LastName = reader.GetString(reader.GetOrdinal("lastName")),
                            Login = reader.GetString(reader.GetOrdinal("login")),
                            Password = reader.GetString(reader.GetOrdinal("password"))
                        };
                        user.Categories = _categoriesRepository.GetUserCategories(user.Id);
                        return user;
                    }
                }
            }
        }
    }
}
