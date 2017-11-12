using Evernote.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace Evernote.DataLayer.Sql
{
   public class CategoriesRepository : ICategoriesRepository
    {
        private readonly string _connectionString;
        private readonly INotesRepository _notesRepository;

        public CategoriesRepository(string connectionString,INotesRepository _notesRepository)
        {
            this. _connectionString = connectionString;
            this._notesRepository = _notesRepository;
        }

        public void AddNoteintoCategory( Guid categoryId,Guid noteId)
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
                            ////if (!reader.Read())
                            ////    throw new ArgumentException($"Категория с id {categoryId} не найдена");
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

        public IEnumerable<Category> GetCategoriesofNote(Guid noteId)
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
 
        public IEnumerable<Note> GetNotesofCategory(Guid categoryId)
        {
            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                sqlConnection.Open();
                using (var command = sqlConnection.CreateCommand())
                {
                    Category temp = GetCategory(categoryId);
                    command.CommandText = "select * from Mediator where categoryid = @categoryid";
                    command.Parameters.AddWithValue("@categoryid", categoryId);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            
                            yield return _notesRepository.Get(reader.GetGuid(reader.GetOrdinal("noteid")));
                            
                        }
                    }
                }
            }
        }

        public IEnumerable<Category> GetfreeCategoriesofNote(Guid noteId)
        {
            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                sqlConnection.Open();
                using (var command = sqlConnection.CreateCommand())
                {
                    command.CommandText = @"select B.[id] " +
                        "from Mediator A " +
                        "RIGHT JOIN Category B " +
                        "ON A.[categoryid]=B.[id] AND A.[noteid]=@noteId " +
                        "where A.[categoryid] IS NULL";
                    //command.CommandText = @"select Mediator.categoryid " +
                    //    "from Mediator " +
                    //    "RIGHT JOIN Category " +
                    //    "ON Mediator.categoryid=Category.id AND Mediator.noteid=@noteId " +
                    //    "where Mediator.categoryid IS NULL";
                    command.Parameters.AddWithValue("@noteId", noteId);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                           
                            Category category = GetCategory(reader.GetGuid(reader.GetOrdinal("id")));
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

        public Category Update( Category category)
        {
            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                sqlConnection.Open();
                using (var command = sqlConnection.CreateCommand())
                {
                    command.CommandText = "Update Category Set" +
                        " name=@name " +
                        " Where id=@id";
                    command.Parameters.AddWithValue("@id", category.Id);
                    command.Parameters.AddWithValue("@name", category.Name);
                    command.ExecuteNonQuery();
                    return category;
                }
            }
        }

  
    }

}
    

