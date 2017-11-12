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

        public UsersRepository(string connectionString)
        {
            _connectionString = connectionString;
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

        public Category CreateCategory(Guid userId, string name)
        {
            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                sqlConnection.Open();
                using (var command = sqlConnection.CreateCommand())
                {
                    command.CommandText = "insert into Category (id, name, Userid) values (@id, @name, @Userid)";

                    var category = new Category
                    {
                        Id = Guid.NewGuid(),
                        Name = name
                    };
                    command.Parameters.AddWithValue("@UserId", userId);
                    command.Parameters.AddWithValue("@name", category.Name);
                    command.Parameters.AddWithValue("@id", category.Id);
                    command.ExecuteNonQuery();

                    return category;
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
                        user.Categories = GetUserCategories(user.Id);
                        return user;
                    }
                }
            }
        }

        public User Get(string login, string password)
        {
           
                using (var sqlConnection = new SqlConnection(_connectionString))
                {
                    sqlConnection.Open();
                    using (var command = sqlConnection.CreateCommand())
                    {
                        command.CommandText = "select *from [User] where login = @login AND password=@password";
                        command.Parameters.AddWithValue("@login", login);
                        command.Parameters.AddWithValue("@password", password);
                        using (var reader = command.ExecuteReader())
                        {
                            if (!reader.Read())
                                return null;

                            var user = new User
                            {
                                Id = reader.GetGuid(reader.GetOrdinal("id")),
                                FirstName = reader.GetString(reader.GetOrdinal("firstName")),
                                LastName = reader.GetString(reader.GetOrdinal("lastName")),
                                Login = reader.GetString(reader.GetOrdinal("login")),
                                Password = reader.GetString(reader.GetOrdinal("password"))
                            };
                            user.Categories = GetUserCategories(user.Id);
                            return user;
                        }
                    }
                }
           

        }

        public IEnumerable<User> GetAllUserExpectMe(Guid userId)
        {
            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                sqlConnection.Open();
                using (var command = sqlConnection.CreateCommand())
                {
                    command.CommandText = "select *from [User] where NOT id = @id";
                    command.Parameters.AddWithValue("@id", userId);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return new User
                            {
                                Id = reader.GetGuid(reader.GetOrdinal("id")),
                                FirstName = reader.GetString(reader.GetOrdinal("firstName")),
                                LastName = reader.GetString(reader.GetOrdinal("lastName")),
                                Login = reader.GetString(reader.GetOrdinal("login")),
                                Password = reader.GetString(reader.GetOrdinal("password")),
                                Categories = GetUserCategories(reader.GetGuid(reader.GetOrdinal("id")))
                            };
                        }

                    }
                }
            }
        }
    
        public IEnumerable<Note> GetUserNotes(Guid userId)
        {
            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                sqlConnection.Open();
                using (var command = sqlConnection.CreateCommand())
                {
                    command.CommandText = "select * from Note where userId = @userId";
                    command.Parameters.AddWithValue("@userId", userId);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return new Note
                            {

                                Id = reader.GetGuid(reader.GetOrdinal("id")),
                                header = reader.GetString(reader.GetOrdinal("header")),
                                text = reader.GetString(reader.GetOrdinal("text")),
                                Created = reader.GetDateTime(reader.GetOrdinal("date_created")),
                                Owner = Get(userId),
                                Changed = reader.GetDateTime(reader.GetOrdinal("date_changed"))
                            };
                        }
                    }
                }
            }

        }

        public IEnumerable<Category> GetUserCategories(Guid userId)
        {
            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                sqlConnection.Open();
                using (var command = sqlConnection.CreateCommand())
                {
                    command.CommandText = "select id, name from Category where Userid = @userId";
                    command.Parameters.AddWithValue("@userId", userId);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return new Category
                            {
                                Name = reader.GetString(reader.GetOrdinal("name")),
                                Id = reader.GetGuid(reader.GetOrdinal("id"))
                            };
                        }
                    }
                }
            }
        }

        public User Update(User user)
        {
            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                sqlConnection.Open();
                using (var command = sqlConnection.CreateCommand())
                {
                    command.CommandText = "Update [User] Set" +
                        " firstName=@firstName, " +
                        " lastName=@lastName, " +
                        " login=@login, " +
                        " password=@password " +
                        " Where id=@id";
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
    }
}
