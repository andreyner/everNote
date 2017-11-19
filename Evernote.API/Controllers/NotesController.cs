﻿using Evernote.API.Helper;
using Evernote.DataLayer;
using Evernote.DataLayer.Sql;
using Evernote.Model;
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

       
        private readonly INotesRepository _notesRepository;

        public NotesController()
        {
            _notesRepository = new NotesRepository(new UsersRepository());

        }

        [HttpPost]
        [Route("api/notes")]
        public Note Create([FromBody] Note note)
        {
            Logger.Log.Instance.Info("Создание заметки c заголовком {0} ",note.header);
            return _notesRepository.Create(note);
        }

        [HttpPut]
        [Route("api/notes")]
        public Note UpdateNote([FromBody] Note note)
        {
            Logger.Log.Instance.Info("Обновление заметки с Id: {0}", note.Id);
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
        [Route("api/notes/{id}")]
        public Note GetNote(Guid id)
        {
            Logger.Log.Instance.Info("Получение заметки с Id: {0}", id);
            return _notesRepository.Get(id);
        }

    }
}
