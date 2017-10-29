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
            _categoriesRepository = new CategoriesRepository(ConnectionString);

        }

        [HttpPost]
        [Route("api/categories/{id}/{name}")]
        public Category Create([FromBody] Category category,Guid ownerid)
        {
            Logger.Log.Instance.Info("Создание категории c именем {0}", category.Name);
            string errors = ModelValidator.Validate(ModelState);
            if (errors != null)
            {
                Logger.Log.Instance.Error(errors);
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState));
            }
                return _categoriesRepository.Create(ownerid, category.Name);
        }

        [HttpDelete]
        [Route("api/categories/{id}")]
        public void Delete(Guid categoryId)
        {
            Logger.Log.Instance.Info("Удаление категории c id: {0} ", categoryId);
            _categoriesRepository.Delete(categoryId);
        }

        [HttpDelete]
        [Route("api/categories/{id}")]
        public void DellNoteintoCategory(Guid categoryId, Guid noteId)
        {
            Logger.Log.Instance.Info("Удаление заметки с id: {0} из категории c id: {1}",noteId,categoryId);
            _categoriesRepository.DellNoteintoCategory(categoryId,noteId);
        }

        [HttpPost]
        [Route("api/categories/{categoryId}/add/{noteId}")]
        public void AddNoteintoCategory(Guid categoryId, Guid noteId)
        {
            Logger.Log.Instance.Info("Добавление заметкм с id: {0} в категорию c id: {1}", noteId, categoryId);
            string errors = ModelValidator.Validate(ModelState);
            _categoriesRepository.AddNoteintoCategory(categoryId, noteId);
        }

        [HttpGet]
        [Route("api/categories/user/{id}")]
        public IEnumerable<Category> GetNotesofCategory(Guid userId)
        {
            Logger.Log.Instance.Info("Получить категории пользователя с id: {0}",userId);
            return _categoriesRepository.GetUserCategories(userId);
        }

        [HttpGet]
        [Route("api/categories/note/{id}")]
        public IEnumerable<Category> GetCategoryofNotes(Guid noteId)
        {
            Logger.Log.Instance.Info("Получить категории заметки с id: {0}", noteId);
            return _categoriesRepository.GetNoteCategories(noteId);
        }

    }
}
