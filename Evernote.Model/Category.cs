using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evernote.Model
{
  public class Category
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Укажите название категории!")]
        public string Name { get; set; }
    }
}
