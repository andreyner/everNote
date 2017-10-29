using Evernote.API.Helper;
using Evernote.DataLayer;
using Evernote.DataLayer.Sql;
using Evernote.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Filters;

namespace Evernote.API.Controllers
{
    [FilterExceptions]
    public class UsersController : ApiController
    {

        private const string ConnectionString = @"Data Source=ANDREY-PK\SQLEXPRESS;Initial Catalog=EverNoteDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private readonly IUsersRepository _usersRepository;

        public UsersController()
        {
            _usersRepository = new UsersRepository(ConnectionString, new CategoriesRepository(ConnectionString));
        }

        [HttpGet]
        [Route("api/users/{id}")]
        public User Get(Guid id)
        {
            Logger.Log.Instance.Info("Получение пользователя с Id: {0}", id);
            return _usersRepository.Get(id);
        }

      
        [HttpPost]
        [Route("api/users")]
        public User CreatUser([FromBody] User user)
        {
            Logger.Log.Instance.Info("Создание пользователя с именем: {0}", user.FirstName);
            string errors = ModelValidator.Validate(ModelState);
            if ( errors!= null)
            {
                Logger.Log.Instance.Error(errors);
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState));
            }
            return _usersRepository.Create(user);
        }

       
        [HttpDelete]
        [Route("api/users/{id}")]
        public void Delete(Guid id)
        {
             Logger.Log.Instance.Info("Удаление пользователя с Id: {0}", id);
            _usersRepository.Delete(id);
        }

        
        [HttpGet]
        [Route("api/users/{id}/categories")]
        public IEnumerable<Category> GetUserCategories(Guid id)
        {
            Logger.Log.Instance.Info("Получение категоий заметок пользоваля с Id: {0}", id);
            return _usersRepository.Get(id).Categories;
        }

    }
}
