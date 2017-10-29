using Evernote.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evernote
{
  public class User
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Укажите своё имя!")]
        public string FirstName { get; set; }

        public string LastName { get; set; }
        [Required(ErrorMessage = "Укажите логин пользователя!")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Укажите пароль пользователя!")]
        public string Password { get; set; }

        public IEnumerable<Category> Categories { get; set; }
    }
}
