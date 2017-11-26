using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Evernote.Model;
namespace Evernote.DataLayer
{
   public  interface ISharedRepository
    {    
        /// <summary>
        /// Создать шару
        /// </summary>
        /// <param name="share">Шара</param>
        /// <returns>Созданная Шара</returns>
        Share ShareCreate(Share share);
        /// <summary>
        /// Получить шары пришедшие пользователю
        /// </summary>
        /// <param name="userid"> ид пользователя</param>
        /// <returns>Все шары</returns>
        IEnumerable<Note> GetSharestoMe(Guid userid);
        /// <summary>
        /// Получить шары,отправленнные пользователем
        /// </summary>
        /// <param name="userid">id пользователя</param>
        /// <returns>заметки</returns>
        IEnumerable<Note> GetSharesfromMe(Guid userid);     
        /// <summary>
        /// Удалить шару
        /// </summary>
        /// <param name="shareid"> шара</param>
        void ShareDelete(Share share);
   
    }
}
