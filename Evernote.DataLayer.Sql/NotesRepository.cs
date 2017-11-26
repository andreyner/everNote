using System;
using System.Collections.Generic;
using System.Configuration;
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
        public NotesRepository()
        {
            this._usersRepository = new UsersRepository();
            this._connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }
        /// <summary>
        /// создание заметки
        /// </summary>
        /// <param name="note">заметка</param>
        /// <returns>созданная заметка</returns>
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
        /// <summary>
        /// удалени заметки по id
        /// </summary>
        /// <param name="id">id заметки</param>
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
        /// <summary>
        /// Получить заметку по id
        /// </summary>
        /// <param name="noteid">id заметки</param>
        /// <returns>заметка</returns>
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
                          
                            return new Note
                            {

                                Id = reader.GetGuid(reader.GetOrdinal("id")),
                                header = reader.GetString(reader.GetOrdinal("header")),
                                text = reader.GetString(reader.GetOrdinal("text")),
                                Created = reader.GetDateTime(reader.GetOrdinal("date_created")),
                                Owner = _usersRepository.Get(reader.GetGuid(reader.GetOrdinal("userid"))),
                                Changed = reader.GetDateTime(reader.GetOrdinal("date_changed"))
                            };
                        }
                        
                    }
                }
            }
                throw new ArgumentException($"Заметка с id {noteid} не найдена");
        }
        /// <summary>
        /// Обновление заметки
        /// </summary>
        /// <param name="note"> заметка</param>
        /// <returns>обновлённая заметка</returns>
        public Note UpdateNote(Note note)
        {
            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                sqlConnection.Open();
                using (var command = sqlConnection.CreateCommand())
                {
                    command.CommandText = "Update Note Set" +
                        " header=@header, " +
                        " text=@text," +
                        " date_changed=@date_changed " +
                        " Where id=@id";
                    command.Parameters.AddWithValue("@id", note.Id);
                    command.Parameters.AddWithValue("@header", note.header);
                    command.Parameters.AddWithValue("@text", note.text);
                    command.Parameters.AddWithValue("@date_changed", note.Changed);
                    command.ExecuteNonQuery();
                    return note;
                }
            }
        }
        /// <summary>
        /// Копировать заметку пользователю с id newuserId заметку с id noteid
        /// </summary>
        /// <param name="noteid">id заметки</param>
        /// <param name="newuserId">id пользователя</param>
        /// <returns></returns>
        public Note CopyNoteToUser(Guid noteid, Guid newuserId)
        {
            Note note = Get(noteid);
            var resNote= Create(note);
           resNote.Owner= _usersRepository.Get(newuserId);
           return resNote;
        }
        /// <summary>
        /// Получить владельца заметки по id заметки
        /// </summary>
        /// <param name="noteid"> ид заметки</param>
        /// <returns>владелец</returns>

    }
}
