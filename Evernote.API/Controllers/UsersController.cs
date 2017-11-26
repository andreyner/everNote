using Evernote.API.Helper;
using Evernote.DataLayer;
using Evernote.DataLayer.Sql;
using Evernote.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Filters;

namespace Evernote.API.Controllers
{
    /// <summary>
    /// Контроллер шар
    /// </summary>
    [FilterExceptions]
    public class UsersController : ApiController
    {

        private readonly IUsersRepository _usersRepository;

        public UsersController()
        {
            _usersRepository = new UsersRepository();
        }
        /// <summary>
        /// Получить пользователя по id
        /// </summary>
        /// <param name="id">id пользователя</param>
        /// <returns>пользователь</returns>
        [HttpGet]
        [Route("api/users/{id}")]
        public User Get(Guid id)
        {
            Logger.Log.Instance.Info("Получение пользователя с Id: {0}", id);
            return _usersRepository.Get(id);
        }
        /// <summary>
        /// Получить пользователя по логину и паролю
        /// </summary>
        /// <param name="login">логин</param>
        /// <param name="password">пароль</param>
        /// <returns>пользователь</returns>
        [HttpGet]
        [Route("api/users/{login}/{password}")]
        public User Get(string login,string password)
        {
            Logger.Log.Instance.Info("Получение пользователя с логином: {0} и паролем: {1}", login,password);
            return _usersRepository.Get(login,password);
        }
        /// <summary>
        /// Создать пользователя
        /// </summary>
        /// <param name="user"> пользователь</param>
        /// <returns><пользователь</returns>
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
        /// <summary>
        /// Создание категории пользователя
        /// </summary>
        /// <param name="category">категория</param>
        /// <param name="id"> id пользователя</param>
        /// <returns> категория</returns>
        [HttpPost]
        [Route("api/users/{id}/categories")]
        public Category CreateCategory([FromBody] Category category, Guid id)
        {
            Logger.Log.Instance.Info("Создание категории c именем {0}", category.Name);
            //string errors = ModelValidator.Validate(ModelState);
            //if (errors != null)
            //{
            //    Logger.Log.Instance.Error(errors);
            //    throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState));
            //}
            return _usersRepository.CreateCategory(id, category.Name);
        }
        /// <summary>
        /// Удалить пользователя
        /// </summary>
        /// <param name="id"> id пользователя</param>
        [HttpDelete]
        [Route("api/users/{id}")]
        public void Delete(Guid id)
        {
             Logger.Log.Instance.Info("Удаление пользователя с Id: {0}", id);
            _usersRepository.Delete(id);
        }
        /// <summary>
        /// Получить категории пользователя
        /// </summary>
        /// <param name="id"> id пользователя</param>
        /// <returns>категории</returns>
        [HttpGet]
        [Route("api/users/{id}/categories")]
        public IEnumerable<Category> GetUserCategories(Guid id)
        {
            Logger.Log.Instance.Info("Получение категорий заметок пользоваля с Id: {0}", id);
            return _usersRepository.Get(id).Categories;
        }
        /// <summary>
        /// Получить заметки пользователя
        /// </summary>
        /// <param name="id"> id пользователя</param>
        /// <returns> заметки</returns>
        [HttpGet]
        [Route("api/users/{id}/notes")]
        public IEnumerable<Note> GetUserNotes(Guid id)
        {
            Logger.Log.Instance.Info("Получение заметок пользователя с Id: {0}", id);
            return _usersRepository.GetUserNotes(id);
        }
        /// <summary>
        /// Получить список пользователей, исключая пользователя с id
        /// </summary>
        /// <param name="id">id исключённого пользователя</param>
        /// <returns>пользователи</returns>
        [HttpGet]
        [Route("api/users/{id}/expected")]
        public IEnumerable<User> GetUsersExpectedMe(Guid id)
        {
            Logger.Log.Instance.Info("Получение всех пользователей приложения, кроме пользователя с Id: {0}", id);
            return _usersRepository.GetAllUserExpectMe(id);
        }
        /// <summary>
        /// Обновить информацию о пользователе
        /// </summary>
        /// <param name="user"> пользователь</param>
        /// <returns> пользователь</returns>
        [HttpPut]
        [Route("api/users")]
        public User UpdateUser([FromBody] User user)
        {
            Logger.Log.Instance.Info("Обновление пользователя с id: {0}", user.Id);
            return _usersRepository.Update(user);
        }


    }
}
