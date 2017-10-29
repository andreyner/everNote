using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evernote.DataLayer.Sql
{
    public class NotesRepository : INotesRepository
    {
        private readonly string _connectionString;
        private readonly IUsersRepository _usersRepository;
        public NotesRepository(IUsersRepository _usersRepository, string connectionString)
        {
            this._usersRepository = _usersRepository;
            this._connectionString = connectionString;
        }
        
        public Note Create(Note note)
        {
            
            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                sqlConnection.Open();
                using (var command = sqlConnection.CreateCommand())
                {
                    note.Id = Guid.NewGuid();
                    command.CommandText = "insert into Note (id, header, text, date_created, userid, date_changed) values (@id, @header, @text, @date_created, @userid, @date_changed)";
                    command.Parameters.AddWithValue("@id", note.Id);
                    command.Parameters.AddWithValue("@header", note.header);
                    command.Parameters.AddWithValue("@text", note.text);
                    command.Parameters.AddWithValue("@date_created", note.Created);
                    command.Parameters.AddWithValue("@userid", note.Owner.Id);
                    command.Parameters.AddWithValue("@date_changed", note.Created);
                    command.ExecuteNonQuery();
                    return note;
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
                    command.CommandText = "delete from Note where id = @id";
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }
            }
        
        }

        public Note Get(Guid noteid)
        {
            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                sqlConnection.Open();
                using (var command = sqlConnection.CreateCommand())
                {
                    command.CommandText = "Select * from Note where id= @id";
                    command.Parameters.AddWithValue("@id", noteid);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (!reader.Read())
                                throw new ArgumentException($"Заметка с id {noteid} не найдена");
                            return new Note
                            {

                                Id = reader.GetGuid(reader.GetOrdinal("id")),
                                header = reader.GetString(reader.GetOrdinal("header")),
                                text = reader.GetString(reader.GetOrdinal("text")),
                                Created = reader.GetDateTime(reader.GetOrdinal("date_created")),
                               // Owner = _usersRepository.Get(userId),
                                Changed = reader.GetDateTime(reader.GetOrdinal("date_changed"))
                            };
                        }
                        
                    }
                }
            }
                throw new ArgumentException($"Заметка с id {noteid} не найдена");
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
                                Owner = _usersRepository.Get(userId),
                                Changed = reader.GetDateTime(reader.GetOrdinal("date_changed"))
                            };
                        }
                    }
                }
            }

        }

        public Note UpdateNote(Note note)
        {
            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                sqlConnection.Open();
                using (var command = sqlConnection.CreateCommand())
                {
                    note.Id = Guid.NewGuid();
                    command.CommandText = "Update Note Set" +
                        " header=@header, " +
                        " text=@text," +
                        " data_created=@data_created," +
                        " data_changed=@data_changed " +
                        " Where id=@id";
                    command.Parameters.AddWithValue("@id", note.Id);
                    command.Parameters.AddWithValue("@header", note.header);
                    command.Parameters.AddWithValue("@text", note.text);
                    command.Parameters.AddWithValue("@data_created", note.Created);
                    command.Parameters.AddWithValue("@data_changed", note.Created);
                    command.ExecuteNonQuery();
                    return note;
                }
            }
        }

        public Note CopyNoteToUser(Guid noteid, Guid newuserId)
        {
            Note note = Get(noteid);
            var resNote= Create(note);
           resNote.Owner= _usersRepository.Get(newuserId);
           return resNote;
        }

        public IEnumerable<Note> GetNotesofCategory(Guid categoryId)
        {
            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                sqlConnection.Open();
                using (var command = sqlConnection.CreateCommand())
                {
                    command.CommandText = "select * from Note where categoryid = @categoryid";
                    command.Parameters.AddWithValue("@categoryid", categoryId);

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
                                Changed = reader.GetDateTime(reader.GetOrdinal("date_changed"))
                            };
                        }
                    }
                }
            }
        }

       
    }
}
