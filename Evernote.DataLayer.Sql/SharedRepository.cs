using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evernote.DataLayer.Sql
{
   public  class SharedRepository : ISharedRepository
    {
        private readonly string _connectionString;
        private readonly IUsersRepository _usersRepository;
        public SharedRepository( IUsersRepository _usersRepository)
        {
            this._connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            this._usersRepository = _usersRepository;
        }
        /// <summary>
        /// Создать шару
        /// </summary>
        /// <param name="share">шара</param>
        /// <returns>созданная шара</returns>
        public Share ShareCreate(Share share)
        {
            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                sqlConnection.Open();
                using (var command = sqlConnection.CreateCommand())
                {

                    command.CommandText = "insert into Shares (Userid, Noteid) values (@Userid, @Noteid)";
                    command.Parameters.AddWithValue("@Userid", share.DestinationUserId);
                    command.Parameters.AddWithValue("@Noteid", share.SharedNoteId);
                    command.ExecuteNonQuery();
                    return share;
                }
            }
        }
        /// <summary>
        /// Получить шары пользователя по его id
        /// </summary>
        /// <param name="userid">id пользователя</param>
        /// <returns> заметки из шар</returns>
        public IEnumerable<Note> GetShares(Guid userid)
        {
            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                sqlConnection.Open();
                using (var command = sqlConnection.CreateCommand())
                {
                    command.CommandText = "select * from Shares" +
                        " where Userid = @Userid";
                    command.Parameters.AddWithValue("@Userid", userid);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            yield return new NotesRepository(_usersRepository).Get(reader.GetGuid(reader.GetOrdinal("Noteid")));

                        }
                    }
                }
            }
        }
        /// <summary>
        /// Удаление шары
        /// </summary>
        /// <param name="share"></param>
        public void ShareDelete(Share share)
        {
            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                sqlConnection.Open();
                using (var command = sqlConnection.CreateCommand())
                {
                    command.CommandText = "Delete from Shares where Noteid = @Noteid and Userid=@Userid";
                    command.Parameters.AddWithValue("@Noteid", share.SharedNoteId);
                    command.Parameters.AddWithValue("@Userid", share.DestinationUserId);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
