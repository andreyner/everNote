using Evernote.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evernote.DataLayer.Sql
{
   public class CategoriesRepository : ICategoriesRepository
    {
        private readonly string _connectionString;

        public CategoriesRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void AddNoteintoCategory(Guid noteId, Guid categoryId)
        {
            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                sqlConnection.Open();
                using (var command = sqlConnection.CreateCommand())
                {
                    command.CommandText = "insert into Mediator (categoryid, noteid) values (@categoryid, @noteid)";
                    command.Parameters.AddWithValue("@categoryid", categoryId);
                    command.Parameters.AddWithValue("@noteid", noteId);
                    command.ExecuteNonQuery();
                
                }
                using (var command = sqlConnection.CreateCommand())
                {
                    command.CommandText = "Update Note Set" +
                        " categoryid=@categoryid " +
                        " Where id=@id";
                    command.Parameters.AddWithValue("@id", noteId);
                    command.Parameters.AddWithValue("@categoryid",categoryId);

                    command.ExecuteNonQuery();                   
                }
            }
        }

        public Category Create(Guid userId, string name)
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

        public void Delete(Guid categoryId)
        {

            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                sqlConnection.Open();
                using (var command = sqlConnection.CreateCommand())
                {
                    command.CommandText = "delete from Category where id = @id";
                    command.Parameters.AddWithValue("@id", categoryId);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DellNoteintoCategory(Guid categoryId, Guid noteId)
        {
            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                sqlConnection.Open();
                using (var command = sqlConnection.CreateCommand())
                {
                    command.CommandText = "delete from Mediator where categoryid = @categoryid AND noteid=@noteid";
                    command.Parameters.AddWithValue("@categoryid", categoryId);
                    command.Parameters.AddWithValue("@noteid",noteId);
                    command.ExecuteNonQuery();
                }
            }
        }

        public Category GetCategory(Guid categoryId)
        {

            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                sqlConnection.Open();
                using (var command = sqlConnection.CreateCommand())
                {
                    command.CommandText = "Select * from Category where id=@id";
                    command.Parameters.AddWithValue("@id", categoryId);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            return new Category
                            {

                                Id = reader.GetGuid(reader.GetOrdinal("id")),
                                Name = reader.GetString(reader.GetOrdinal("name")),
                            };
                        }

                    }
                }
            }
            throw new ArgumentException($"Категория с id {categoryId} не найдена");
        }

        public IEnumerable<Category> GetNoteCategories(Guid noteId)
        {
            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                sqlConnection.Open();
                using (var command = sqlConnection.CreateCommand())
                {
                    command.CommandText = "select categoryid from Mediator where noteid = @noteId";
                    command.Parameters.AddWithValue("@noteId", noteId);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Category category = GetCategory(reader.GetGuid(reader.GetOrdinal("categoryid")));
                            yield return new Category
                            {
                                Name = category.Name,
                                Id = category.Id
                                
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
    }
}
