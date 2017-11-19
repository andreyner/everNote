using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Evernote.Model;
using System.Configuration;

namespace Evernote.DataLayer.Sql
{
    public class UsersRepository : IUsersRepository
    {
        private readonly string _connectionString;

        public UsersRepository()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }
        /// <summary>
        /// Создание  новго пользователя
        /// </summary>
        /// <param name="user">юзер</param>
        /// <returns>созданный пользователь</returns>
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
        /// <summary>
        /// Создание категории пользователя
        /// </summary>
        /// <param name="userId"> ид пользователя</param>
        /// <param name="name">имя категории</param>
        /// <returns></returns>
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
        /// <summary>
        /// удаление пользователя по id
        /// </summary>
        /// <param name="id">id пользователя</param>
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
        /// <summary>
        /// Получение пользователя по id
        /// </summary>
        /// <param name="id"> id пользователя</param>
        /// <returns> созданный пользователь</returns>
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
                            throw new InvalidOperationException("Пользователь не найден!");

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
        /// <summary>
        /// Получение пользователя по логину паролю
        /// </summary>
        /// <param name="login">логин</param>
        /// <param name="password">пароль</param>
        /// <returns>найднный пользователь</returns>
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
                            throw new InvalidOperationException("Пользователь не найден!");
                      

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
        /// <summary>
        /// Получить всех пользователей,кроме пользователя с userid
        /// </summary>
        /// <param name="userId">id исключённого пользователя</param>
        /// <returns> список пользователей</returns>
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
        /// <summary>
        /// Получить заметки пользователя
        /// </summary>
        /// <param name="userId"> ид пользователя</param>
        /// <returns>заметки</returns>
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
        /// <summary>
        /// Получить категории пользователя
        /// </summary>
        /// <param name="userId"> id пользователя</param>
        /// <returns> список категорий</returns>
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
        /// <summary>
        /// Обновление пользователя 
        /// </summary>
        /// <param name="user"> пользователь</param>
        /// <returns>обновленный пользователь</returns>
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
