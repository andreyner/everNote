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
    public class NotesController : ApiController
    {

        private const string ConnectionString = @"Data Source=ANDREY-PK\SQLEXPRESS;Initial Catalog=EverNoteDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private readonly INotesRepository _notesRepository;

        public NotesController()
        {
            _notesRepository = new NotesRepository(new UsersRepository(ConnectionString,new CategoriesRepository(ConnectionString)), ConnectionString );

        }

        [HttpPost]
        [Route("api/notes/create")]
        public Note Post([FromBody] Note note)
        {
            return _notesRepository.Create(note);
        }

        [HttpPost]
        [Route("api/notes/{id}/newuser/{id}")]
        public Note Post(Guid noteid, Guid newuserId)
        {
            return _notesRepository.MakeMyNote(noteid, newuserId);
        }

        [HttpPut]
        [Route("api/notes/update")]
        public Note UpdateNote([FromBody] Note note)
        {
            return _notesRepository.UpdateNote(note);
        }

        [HttpDelete]
        [Route("api/notes/{id}/delete")]
        public void Delete(Guid id)
        {
            _notesRepository.Delete(id);
        }

        [HttpGet]
        [Route("api/notes/{id}/users")]
        public IEnumerable<Note> GetUserNotes(Guid userid)
        {
            return _notesRepository.GetUserNotes(userid);
        }

        [HttpGet]
        [Route("api/notes/{id}/categories")]
        public IEnumerable<Note> GetNotesofCategory(Guid categoryId)
        {
            return _notesRepository.GetNotesofCategory(categoryId);
        }
    }
}
