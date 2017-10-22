using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evernote.DataLayer
{
    public interface INotesRepository
    {
        /// <summary>
        /// Создание заметки
        /// </summary>
        /// <param name="note"> Заметка</param>
        /// <returns>Созданная заметка</returns>
        Note Create(Note note);
        /// <summary>
        /// Удаление заметки
        /// </summary>
        /// <param name="id">ид заметки</param>
        void Delete(Guid id);
        /// <summary>
        /// Получение заметок пользователя
        /// </summary>
        /// <param name="userId">ид пользователя</param>
        /// <returns></returns>
        IEnumerable<Note> GetUserNotes(Guid userId);
        /// <summary>
        /// Обновление заметки
        /// </summary>
        /// <param name="note">ид заметки</param>
        /// <returns></returns>
        Note UpdateNote(Note note);
        /// <summary>
        /// Добавить заметку в свои заметки
        /// </summary>
        /// <param name="noteid">ид заметки</param>
        /// <param name="newuserId"> ид пользователя</param>
        /// <returns></returns>
        Note MakeMyNote(Guid noteid, Guid newuserId);
        /// <summary>
        /// Получить заметки категории
        /// </summary>
        /// <param name="categoryId">ид категории</param>
        /// <returns> Все заметки</returns>
        IEnumerable<Note> GetNotesofCategory(Guid categoryId);
    }
}
