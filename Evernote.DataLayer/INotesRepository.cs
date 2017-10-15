﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evernote.DataLayer
{
    public interface INotesRepository
    {
        Note Create(Note note);
        void Delete(Guid id);
        IEnumerable<Note> GetUserNotes(Guid userId);
        Note UpdateNote(Note note);
        Note MakeMyNote(Note note, Guid newuserId);
        IEnumerable<Note> GetNotesofCategory(Guid categoryId, Guid OwnerId);
    }
}
