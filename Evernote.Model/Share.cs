using System;
using System.Collections.Generic;
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

      public Guid DestinationUserId { get; private set;}
      public Guid SharedNoteId { get; private set; }
    }
}
