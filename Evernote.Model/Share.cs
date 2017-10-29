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
        public Share(Guid destinationUserId, Guid sharedNoteId)
        {
            this.DestinationUserId = destinationUserId;
            this.SharedNoteId = sharedNoteId;
        }
        [Required(ErrorMessage = "Укажите пользователя с которым нужно поделиться!")]
        public Guid DestinationUserId { get; private set;}
        [Required(ErrorMessage = "Укажите заметку которой нужно поделиться!")]
        public Guid SharedNoteId { get; private set; }
    }
}
