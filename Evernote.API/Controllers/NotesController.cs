using Evernote.API.Helper;
using Evernote.DataLayer;
using Evernote.DataLayer.Sql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Evernote.API.Controllers
{
    [FilterExceptions]
    public class NotesController : ApiController
    {

        private const string ConnectionString = @"Data Source=ANDREY-PK\SQLEXPRESS;Initial Catalog=EverNoteDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private readonly INotesRepository _notesRepository;

        public NotesController()
        {
            _notesRepository = new NotesRepository(new UsersRepository(ConnectionString,new CategoriesRepository(ConnectionString)), ConnectionString );

        }

        [HttpPost]
        [Route("api/notes")]
        public Note Create([FromBody] Note note)
        {
            Logger.Log.Instance.Info("Создание заметки c заголовком {0} ",note.header);
            return _notesRepository.Create(note);
        }

        [HttpPost]
        [Route("api/notes/{id}/newuser/{id}")]
        public Note CopyNoteToUser(Guid noteid, Guid newuserId)
        {
            Logger.Log.Instance.Info("Копировать заметку c id: {0} пользователю с Id: {1}", noteid,newuserId);
            return _notesRepository.CopyNoteToUser(noteid, newuserId);
        }

        [HttpPut]
        [Route("api/notes/update")]
        public Note UpdateNote([FromBody] Note note)
        {
            Logger.Log.Instance.Info("Удаление заметки с Id: {0}", note.Id);
            return _notesRepository.UpdateNote(note);
        }

        [HttpDelete]
        [Route("api/notes/{id}")]
        public void Delete(Guid id)
        {
             Logger.Log.Instance.Info("Удаление заметки с Id: {0}", id);
            _notesRepository.Delete(id);
        }

        [HttpGet]
        [Route("api/notes/{id}/users")]
        public IEnumerable<Note> GetUserNotes(Guid userid)
        {
            Logger.Log.Instance.Info("Получение заметок пользователя с Id: {0}", userid);
            return _notesRepository.GetUserNotes(userid);
        }

        [HttpGet]
        [Route("api/notes/{id}/categories")]
        public IEnumerable<Note> GetNotesofCategory(Guid categoryId)
        {
            Logger.Log.Instance.Info("Получение ззаметок категории с Id: {0}", categoryId);
            return _notesRepository.GetNotesofCategory(categoryId);
        }
    }
}
