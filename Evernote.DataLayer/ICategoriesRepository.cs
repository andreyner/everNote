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
        IEnumerable<Category> GetCategoriesofNote(Guid noteId);
        /// <summary>
        /// Получение категории по ид
        /// </summary>
        /// <param name="categoryId">ид категории</param>
        /// <returns>Категория</returns>
        Category GetCategory(Guid categoryId);
        /// <summary>
        /// Получить заметки категории
        /// </summary>
        /// <param name="categoryId">ид категории</param>
        /// <returns> Все заметки</returns>
        IEnumerable<Note> GetNotesofCategory(Guid categoryId);
        /// <summary>
        /// Получение категорий пользователя где нет заметки
        /// </summary>
        /// <param name="noteId"> id заметки</param>
        /// <param name="userid"> id владелеца заметки</param>
        /// <returns> Свободные категории категории для заметки </returns>
        IEnumerable<Category> GetfreeCategoriesofNote(Guid noteId, Guid userid);
        /// <summary>
        /// Обновление категории
        /// </summary>
        /// <param name="category"> Категория</param>
        /// <returns> Категория</returns>
        Category Update(Category category);

    }
}
