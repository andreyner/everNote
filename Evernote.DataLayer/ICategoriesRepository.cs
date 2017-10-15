using Evernote.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Evernote.DataLayer
{
   public interface ICategoriesRepository
    {
        Category Create(Guid userId, string name);
        IEnumerable<Category> GetUserCategories(Guid userId);
        void Delete(Guid categoryId);
        void AddNoteintoCategory(Guid categoryId, Guid noteId);
        void DellNoteintoCategory(Guid categoryId, Guid noteId);
    }
}
