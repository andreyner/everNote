﻿using Evernote.Model;
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
        [RegularExpression(@"^[a-zа-яA-ZА-Я]{3,15}$", ErrorMessage = "Имя должно содержать только буквы.Длинна от 3 до 15 смиволов")]
        public string FirstName { get; set; }

        public string LastName { get; set; }

        [Required(ErrorMessage = "Укажите логин!")]
        [RegularExpression(@"^[a-zа-яA-ZА-Я]{3,15}$", ErrorMessage = "Логин должен содержать только буквы.Длинна от 3 до 15 смиволов")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Укажите пароль!")]
        [RegularExpression(@"^[a-zа-яA-ZА-Я0-9]{3,15}$", ErrorMessage = "Пароль должен содержать только буквы и цифры.Длинна от 3 до 15 смиволов")]
        public string Password { get; set; }

        public IEnumerable<Category> Categories { get; set; }
    }
}
