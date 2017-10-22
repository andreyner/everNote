using Evernote.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Evernote.DataLayer
{
   public interface ICategoriesRepository
    {   
        /// <summary>
        /// Создание категории пользователя
        /// </summary>
        /// <param name="userId"> ид пользователя</param>
        /// <param name="name"> имя категории</param>
        /// <returns>Созданная категория</returns>
        Category Create(Guid userId, string name);
        /// <summary>
        /// Получение всех категорий пользователя
        /// </summary>
        /// <param name="userId">ид пользователя</param>
        /// <returns>Категории пользователя</returns>
        IEnumerable<Category> GetUserCategories(Guid userId);
        /// <summary>
        /// Удаление категории
        /// </summary>
        /// <param name="categoryId">ид удаляемой категории</param>
        void Delete(Guid categoryId);
        /// <summary>
        /// Добавление заметки в категорию
        /// </summary>
        /// <param name="categoryId"> ид категории</param>
        /// <param name="noteId"> ид заметки</param>
        void AddNoteintoCategory(Guid categoryId, Guid noteId);
        /// <summary>
        /// Удаление заметки из категории
        /// </summary>
        /// <param name="categoryId"> ид категории</param>
        /// <param name="noteId"> ид заметки</param>
        void DellNoteintoCategory(Guid categoryId, Guid noteId);
        /// <summary>
        /// Получить все категории заметки
        /// </summary>
        /// <param name="noteId">ид заметки</param>
        /// <returns> Все категории</returns>
        IEnumerable<Category> GetNoteCategories(Guid noteId);
        /// <summary>
        /// Получение категории по ид
        /// </summary>
        /// <param name="categoryId">ид категории</param>
        /// <returns>Категория</returns>
        Category GetCategory(Guid categoryId);
    }
}
