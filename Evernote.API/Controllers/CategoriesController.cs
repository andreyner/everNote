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
    /// <summary>
    /// Контроллер категорий
    /// </summary>
    [FilterExceptions]
    public class CategoriesController : ApiController
    {

        private readonly ICategoriesRepository _categoriesRepository;

        public CategoriesController()
        {
            _categoriesRepository = new CategoriesRepository();
            

        }
        /// <summary>
        /// Удаление категории
        /// </summary>
        /// <param name="id">id категории</param>
        [HttpDelete]
        [Route("api/categories/{id}")]
        public void Delete(Guid id)
        {
            Logger.Log.Instance.Info("Удаление категории c id: {0} ", id);
            _categoriesRepository.Delete(id);
        }
        /// <summary>
        /// Удаление заметки из категории
        /// </summary>
        /// <param name="categoryId"> id категории</param>
        /// <param name="noteId">id заметки</param>
        [HttpDelete]
        [Route("api/categories/{categoryId}/note/{noteId}")]
        public void DellNoteintoCategory(Guid categoryId, Guid noteId)
        {
            Logger.Log.Instance.Info("Удаление заметки с id: {0} из категории c id: {1}",noteId,categoryId);
            _categoriesRepository.DellNoteintoCategory(categoryId,noteId);
        }
        /// <summary>
        /// Добавить заметку в категорию
        /// </summary>
        /// <param name="id"> id категории</param>
        /// <param name="note"> заметка</param>
        /// <returns>заметка</returns>
        [HttpPost]
        [Route("api/categories/{id}/add")]
        public Note AddNoteintoCategory(Guid id, [FromBody] Note note)
        {
            Logger.Log.Instance.Info("Добавление заметкм с id: {0} в категорию c id: {1}", note.Id, id);
            _categoriesRepository.AddNoteintoCategory(id, note.Id);
            return note;
        }
        /// <summary>
        /// Получить заметки категории
        /// </summary>
        /// <param name="id"> id категории</param>
        /// <returns> заметки</returns>
        [HttpGet]
        [Route("api/categories/{id}/notes")]
        public IEnumerable<Note> GetNotesofCategory(Guid id)
        {
            Logger.Log.Instance.Info("Получение заметок категории с Id: {0}", id);
            return _categoriesRepository.GetNotesofCategory(id);
        }
        /// <summary>
        /// Получить категории заметки
        /// </summary>
        /// <param name="id"> id заметки</param>
        /// <returns></returns>
        [HttpGet]
        [Route("api/categories/note/{id}")]
        public IEnumerable<Category> GetCategoriesofNote(Guid id)
        {
            Logger.Log.Instance.Info("Получить категории заметки с id: {0}", id);
            return _categoriesRepository.GetCategoriesofNote(id);
        }
        /// <summary>
        /// Получить категории пользователя где нет заметки
        /// </summary>
        /// <param name="noteid">id заметки</param>
        /// <param name="userid">id пользователя</param>
        /// <returns>категории</returns>
        [HttpGet]
        [Route("api/categories/note/{noteid}/user/{userid}")]
        public IEnumerable<Category> GetfreeCategoriesofNote(Guid noteid, Guid userid)
        {
            Logger.Log.Instance.Info("Получить категорий пользователя с id: {0} не принадлжежащие заметке с id: {1}", userid, noteid);
            return _categoriesRepository.GetfreeCategoriesofNote(noteid, userid);
        }
        /// <summary>
        /// Обновить категорию
        /// </summary>
        /// <param name="category"> категория</param>
        /// <returns>категория</returns>
        [HttpPut]
        [Route("api/categories")]
        public Category CategoryUpdate([FromBody] Category category)
        {
            Logger.Log.Instance.Info("Обновление категории с названием: {0}", category.Name);
            return _categoriesRepository.Update(category);
        }
        /// <summary>
        /// Получить категорию
        /// </summary>
        /// <param name="id"> id категории</param>
        /// <returns>категория</returns>
        [HttpGet]
        [Route("api/categories/{id}")]
        public Category GetCategory(Guid id)
        {
            Logger.Log.Instance.Info("Получение категории с id: {0}", id);
            return _categoriesRepository.GetCategory(id);
        }

    }
}
