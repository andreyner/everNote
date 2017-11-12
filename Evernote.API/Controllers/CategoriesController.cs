using Evernote.API.Helper;
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
    public class CategoriesController : ApiController
    {

        private const string ConnectionString = @"Data Source=ANDREY-PK\SQLEXPRESS;Initial Catalog=EverNoteDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private readonly ICategoriesRepository _categoriesRepository;

        public CategoriesController()
        {
            _categoriesRepository = new CategoriesRepository(ConnectionString,new NotesRepository(new UsersRepository(ConnectionString),ConnectionString));

        }

        [HttpDelete]
        [Route("api/categories/{id}")]
        public void Delete(Guid id)
        {
            Logger.Log.Instance.Info("Удаление категории c id: {0} ", id);
            _categoriesRepository.Delete(id);
        }

        [HttpDelete]
        [Route("api/categories/{id}")]
        public void DellNoteintoCategory(Guid categoryId, Guid noteId)
        {
            Logger.Log.Instance.Info("Удаление заметки с id: {0} из категории c id: {1}",noteId,categoryId);
            _categoriesRepository.DellNoteintoCategory(categoryId,noteId);
        }

        [HttpPost]
        [Route("api/categories/{id}/add")]
        public void AddNoteintoCategory(Guid id, [FromBody] Note note)
        {
            Logger.Log.Instance.Info("Добавление заметкм с id: {0} в категорию c id: {1}", note.Id, id);
           // string errors = ModelValidator.Validate(ModelState);
            _categoriesRepository.AddNoteintoCategory(id, note.Id);
        }

        [HttpGet]
        [Route("api/categories/{id}/notes")]
        public IEnumerable<Note> GetNotesofCategory(Guid id)
        {
            Logger.Log.Instance.Info("Получение заметок категории с Id: {0}", id);
            return _categoriesRepository.GetNotesofCategory(id);
        }

        [HttpGet]
        [Route("api/categories/note/{id}")]
        public IEnumerable<Category> GetCategoriesofNote(Guid id)
        {
            Logger.Log.Instance.Info("Получить категории заметки с id: {0}", id);
            return _categoriesRepository.GetCategoriesofNote(id);
        }

        [HttpGet]
        [Route("api/categories/free/note/{id}")]
        public IEnumerable<Category> GetfreeCategoriesofNote(Guid id)
        {
            Logger.Log.Instance.Info("Получить категории не принадлжежащие заметке с id: {0}", id);
            return _categoriesRepository.GetfreeCategoriesofNote(id);
        }

        [HttpPut]
        [Route("api/categories")]
        public Category CategoryUpdate([FromBody] Category category)
        {
            Logger.Log.Instance.Info("Обновление категории с названием: {0}", category.Name);
            return _categoriesRepository.Update(category);
        }

        [HttpGet]
        [Route("api/categories/{id}")]
        public Category GetCategory(Guid id)
        {
            Logger.Log.Instance.Info("Получение категории с id: {0}", id);
            return _categoriesRepository.GetCategory(id);
        }

    }
}
