using Evernote.API.Helper;
using Evernote.DataLayer;
using Evernote.DataLayer.Sql;
using Evernote.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Evernote.API.Controllers
{
    [FilterExceptions]
    public class CategoriesController : ApiController
    {

        private readonly ICategoriesRepository _categoriesRepository;

        public CategoriesController()
        {
            _categoriesRepository = new CategoriesRepository(new NotesRepository(new UsersRepository()));
            

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
        public Note AddNoteintoCategory(Guid id, [FromBody] Note note)
        {
            Logger.Log.Instance.Info("Добавление заметкм с id: {0} в категорию c id: {1}", note.Id, id);
            _categoriesRepository.AddNoteintoCategory(id, note.Id);
            return note;
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
        [Route("api/categories/note/{noteid}/user/{userid}")]
        public IEnumerable<Category> GetfreeCategoriesofNote(Guid noteid, Guid userid)
        {
            Logger.Log.Instance.Info("Получить категорий пользователя с id: {0} не принадлжежащие заметке с id: {1}", userid, noteid);
            return _categoriesRepository.GetfreeCategoriesofNote(noteid, userid);
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
