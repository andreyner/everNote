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
        Share ShareCreate(Share share);
        IEnumerable<Note> GetShares(Guid userid);
    }
}
