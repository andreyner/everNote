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
    }
}
