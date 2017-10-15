using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evernote.DataLayer.Sql.Tests
{
    [TestClass]
   public class NotesRepositoryTests
    {

        private const string ConnectionString = @"Data Source=ANDREY-PK\SQLEXPRESS;Initial Catalog=EverNoteDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private readonly List<Guid> _tempUsers = new List<Guid>();
        [TestMethod]
        public void ShouldCreateNote()
        {
            //arrange
            var user = new User
            {   
                FirstName = "test",
                LastName = "test",
                Login="login",
                Password="password"
            };
            var userrepository = new UsersRepository(ConnectionString, new CategoriesRepository(ConnectionString));
            var result = userrepository.Create(user);

            _tempUsers.Add(user.Id);

            var userFromDb = userrepository.Get(result.Id);

            //asserts 1
            Assert.AreEqual(result.FirstName, userFromDb.FirstName);

            var noterepository = new NotesRepository(new UsersRepository(ConnectionString,new CategoriesRepository(ConnectionString)),ConnectionString);
            var note = new Note
            {
                header = "test",
                text = "test",
                Owner = userFromDb,
                Created =DateTime.Now,
                Changed = DateTime.Now
            };
          
           var noteresult= noterepository.Create(note);

            var notefromDb = noterepository.GetUserNotes(userFromDb.Id).Single();

            //asserts 2
            Assert.AreEqual(notefromDb.text,noteresult.text);

        }
        [TestCleanup]
        public void CleanData()
        {
            

            foreach (var id in _tempUsers)
                new UsersRepository(ConnectionString, new CategoriesRepository(ConnectionString)).Delete(id);
        }
    }
}
