using Evernote.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evernote
{
    public class Note
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Укажите название заметки!")]
        public string header { get; set; }

        public string text { get; set; }

        public User Owner { get; set; }
        [Required(ErrorMessage = "Дата создания не может быть пустой!")]
        public DateTime Created { get; set; }

        public DateTime Changed { get; set; }

        public IEnumerable<Category> Categories { get; set; }

        public IEnumerable<User> Shared { get; set; }
    }
}
