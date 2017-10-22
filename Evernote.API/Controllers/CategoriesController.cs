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
        public Category Create(Guid userId, string name)
        {
            return _categoriesRepository.Create(userId, name);
        }

        [HttpDelete]
        [Route("api/categories/{id}")]
        public void Delete(Guid categoryId)
        {
            _categoriesRepository.Delete(categoryId);
        }

        [HttpDelete]
        [Route("api/categories/{id}")]
        public void DellNoteintoCategory(Guid categoryId, Guid noteId)
        {
            _categoriesRepository.DellNoteintoCategory(categoryId,noteId);
        }

        [HttpPost]
        [Route("api/categories/{categoryId}/add/{noteId}")]
        public void Create(Guid categoryId, Guid noteId)
        {
           _categoriesRepository.AddNoteintoCategory(categoryId, noteId);
        }

        [HttpGet]
        [Route("api/categories/user/{id}")]
        public IEnumerable<Category> GetNotesofCategory(Guid userId)
        {
            return _categoriesRepository.GetUserCategories(userId);
        }

        [HttpGet]
        [Route("api/categories/note/{id}")]
        public IEnumerable<Category> GetCategoryofNotes(Guid noteId)
        {
            return _categoriesRepository.GetNoteCategories(noteId);
        }

    }
}
