using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evernote
{
    public class Share
    {

        [Required(ErrorMessage = "Укажите пользователя с которым нужно поделиться!")]
        public Guid DestinationUserId { get; set; }
        [Required(ErrorMessage = "Укажите заметку которой нужно поделиться!")]
        public Guid SharedNoteId { get; set; }
    }
}
