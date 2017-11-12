using Evernote.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evernote.DataLayer
{
    public  interface IUsersRepository
    {   
        /// <summary>
        /// Создать пользователя
        /// </summary>
        /// <param name="user"> Пользователь</param>
        /// <returns>Созданный пользователь</returns>
        User Create(User user);
        /// <summary>
        /// Удалить пользователя
        /// </summary>
        /// <param name="id">ид пользователя</param>
        void Delete(Guid id);
        /// <summary>
        /// Получить пользователя по ИД
        /// </summary>
        /// <param name="id">ИД пользователя</param>
        /// <returns>Пользователь</returns>
        User Get(Guid id);
        /// <summary>
        /// Получить пользователя по лоигину и паролю
        /// </summary>
        /// <param name="login"> логин</param>
        /// <param name="password">пароль</param>
        /// <returns>Пользователь</returns>
        User Get(string login,string password);
        /// <summary>
        /// Создание категории пользователя
        /// </summary>
        /// <param name="userId"> ид пользователя</param>
        /// <param name="name"> имя категории</param>
        /// <returns>Созданная категория</returns>
        Category CreateCategory(Guid userId, string name);
        /// <summary>
        /// Получение заметок пользователя
        /// </summary>
        /// <param name="userId">ид пользователя</param>
        /// <returns></returns>
        IEnumerable<Note> GetUserNotes(Guid userId);
        /// <summary>
        /// Получить всех пользователей приложения,кроме себя
        /// </summary>
        /// <param name="userId"> мой id</param>
        /// <returns> Пользователи</returns>
        IEnumerable<User> GetAllUserExpectMe(Guid userId);
        /// <summary>
        /// Получить все категории пользователя
        /// </summary>
        /// <param name="userId">ид пользователя</param>
        /// <returns>Категории пользователя</returns>
        IEnumerable<Category> GetUserCategories(Guid userId);
        /// <summary>
        /// Обноваление персональных данных пользователя
        /// </summary>
        /// <param name="user"> Пользователь</param>
        /// <returns>Изенённый пользователь</returns>
        User Update(User user);


    }
}
