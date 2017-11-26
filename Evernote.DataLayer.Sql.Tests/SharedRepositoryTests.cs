using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evernote.DataLayer.Sql.Tests
{
    [TestClass]
    public class SharedRepositoryTests
    {
        
        private readonly List<Guid> _tempUsers = new List<Guid>();
        [TestMethod]
        public void ShouldCreateShared()
        {
            //arrange
            var user = new User
            {
                FirstName = "test",
                LastName = "test",
                Login = "login",
                Password = "password"
            };
            var userrepository = new UsersRepository();
            var result = userrepository.Create(user);

            _tempUsers.Add(user.Id);

            var userFromDb = userrepository.Get(result.Id);



            var noterepository = new NotesRepository();
            var note = new Note
            {
                header = "test",
                text = "test",
                Owner = userFromDb,
                Created = DateTime.Now,
                Changed = DateTime.Now
            };

            var noteresult = noterepository.Create(note);


            var sharedrepository = new SharedRepository();

            var share = new Share()
            {
                DestinationUserId = result.Id,
                SharedNoteId = noteresult.Id
            };
            var shareresult=sharedrepository.ShareCreate(share);


            //asserts
            Assert.AreEqual(shareresult.SharedNoteId, noteresult.Id);
        }
        [TestMethod]
        public void ShouldCreateShared_and_CetShared()
        {
            var user = new User
            {
                FirstName = "test",
                LastName = "test",
                Login = "login",
                Password = "password"
            };
            var userrepository = new UsersRepository();
            var result = userrepository.Create(user);

            _tempUsers.Add(user.Id);

            var userFromDb = userrepository.Get(result.Id);



            var noterepository = new NotesRepository();
            var note = new Note
            {
                header = "test",
                text = "test",
                Owner = userFromDb,
                Created = DateTime.Now,
                Changed = DateTime.Now
            };

            var noteresult = noterepository.Create(note);


            var sharedrepository = new SharedRepository();

            var share = new Share()
            {
                DestinationUserId = result.Id,
                SharedNoteId = noteresult.Id
            };
            sharedrepository.ShareCreate(share);
            var shareresult = sharedrepository.GetSharestoMe(userFromDb.Id);

            Assert.AreEqual(shareresult.Single().Id, noteresult.Id);


        }

        [TestCleanup]
        public void CleanData()
        {
            foreach (var id in _tempUsers)
                new UsersRepository().Delete(id);
        }
    }
}
