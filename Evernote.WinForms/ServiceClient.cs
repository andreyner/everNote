using Evernote.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Evernote.WinForms
{
    public class ServiceClient
    {
        private readonly HttpClient _client;

        public ServiceClient(string connectionString)
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri(connectionString);
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public User CreateUser(User user)
        {
            var userres = _client.PostAsJsonAsync("users", user).Result;
            switch (userres.StatusCode)
            {
                case HttpStatusCode.OK: return userres.Content.ReadAsAsync<User>().Result;
                case HttpStatusCode.Forbidden: throw new Exception("Логин уже занят!");
                case HttpStatusCode.BadRequest: throw new Exception(userres.RequestMessage.ToString());
                default: throw new Exception("Не удалось создать пользователя!");
            }
        }
        public User FindUser(string Login, string Password)
        {
         
            var response = _client.GetAsync($"users/{Login}/{Password}").Result;

            switch (response.StatusCode)
            {
                case HttpStatusCode.OK: return response.Content.ReadAsAsync<User>().Result;
                case HttpStatusCode.NotFound: throw new Exception("Пользователь с указанными данными не найден!");
                default: throw new Exception("Ошибка при входе в приложение!");
            }
         
            
        }
        public User FindUser(Guid userid)
        {
            var response = _client.GetAsync($"users/{userid}").Result;

            switch (response.StatusCode)
            {
                case HttpStatusCode.OK: return response.Content.ReadAsAsync<User>().Result;
                case HttpStatusCode.NotFound: throw new Exception("Пользователь с указанными данными не найден!");
                default: throw new Exception("Не удалось найти пользователя!");
            }
        }
        public Category CreateCategory(Category category, Guid ownerid)
        {
            var categoryres = _client.PostAsJsonAsync($"users/{ownerid}/categories", category).Result;
            switch (categoryres.StatusCode)
            {
                case HttpStatusCode.OK: return categoryres.Content.ReadAsAsync<Category>().Result;
                default: throw new Exception("Не удалось создать категорию!");
            }
            

        }
        public IEnumerable<Category> GetUserCategories(Guid userid)
        {
            var category = _client.GetAsync($"users/{userid}/categories").Result;
            switch (category.StatusCode)
            {
                case HttpStatusCode.OK: return category.Content.ReadAsAsync<IEnumerable<Category>>().Result;
                default: throw new Exception("Не удалось получить категории пользователя!");
            }

        }
        public Note CreateNote(Note note)
        {
            var resnote = _client.PostAsJsonAsync("notes", note).Result;
            switch (resnote.StatusCode)
            {
                case HttpStatusCode.OK: return resnote.Content.ReadAsAsync<Note>().Result;
                default: throw new Exception("Не удалось создать заметку!");
            }
            
            
        }
        public IEnumerable<Note> GetUserNotes(Guid userid)
        {
            var notes = _client.GetAsync($"users/{userid}/notes").Result;
            switch (notes.StatusCode)
            {
                case HttpStatusCode.OK: return notes.Content.ReadAsAsync<IEnumerable<Note>>().Result;
                default: throw new Exception("Не удалось получить заметки!");
            }

        }
        public void DeleteNote(Guid noteid)
        {
            var res=_client.DeleteAsync($"notes/{noteid}").Result;
            switch (res.StatusCode)
            {
                case HttpStatusCode.OK: return;
                case HttpStatusCode.NoContent: return;
                default: throw new Exception("Не удалось удалить заметку!");
            }
        }
        public Note UpdateNote(Note note)
        {
            var resnote = _client.PutAsJsonAsync("notes", note).Result;
            switch (resnote.StatusCode)
            {
                case HttpStatusCode.OK: return resnote.Content.ReadAsAsync<Note>().Result;
                default: throw new Exception("Не удалось обновить заметку!");
            }

        }
        public IEnumerable<Note> GetNotesofCategory(Guid categoryid)
        {
            var notes = _client.GetAsync($"categories/{categoryid}/notes").Result;
            switch (notes.StatusCode)
            {
                case HttpStatusCode.OK: return notes.Content.ReadAsAsync<IEnumerable<Note>>().Result;
                default: throw new Exception("Не удалось получить заметки из категории!");
            }
        }
        public IEnumerable<User> GetAllUsersexpectedMe(Guid userexpected)
        {
            var users = _client.GetAsync($"users/{userexpected}/expected").Result;
            switch (users.StatusCode)
            {
                case HttpStatusCode.OK: return users.Content.ReadAsAsync<IEnumerable<User>>().Result;
                default: throw new Exception("Не удалось получить список пользователей!");
            }
        }
        public Share CreatShare(Share share)
        {
            var shareres = _client.PostAsJsonAsync("shares", share).Result;
            switch (shareres.StatusCode)
            {
                case HttpStatusCode.OK: return shareres.Content.ReadAsAsync<Share>().Result;
                default: throw new Exception("Не удалось поделиться заметкой!");
            }

        }
        public IEnumerable<Note> GetShareMe(Guid userid)
        {
            var notes = _client.GetAsync($"shares/touser/{userid}").Result;
            switch (notes.StatusCode)
            {
                case HttpStatusCode.OK: return notes.Content.ReadAsAsync<IEnumerable<Note>>().Result;
                default: throw new Exception("Не удалось получить заметки от других пользователей!");
            }
        }
        public void AddNoteIntoCategory(Guid categoryid, Note note)
        {
           var res=_client.PostAsJsonAsync($"categories/{categoryid}/add",note).Result;
            switch (res.StatusCode)
            {
                case HttpStatusCode.OK: return;
                case HttpStatusCode.NoContent: return;
                default: throw new Exception("Не удалось добавить заметку в категорию!");
            }

        }
        public Note GetNote(Guid noteid)
        {
            var note = _client.GetAsync($"notes/{noteid}").Result;
            switch (note.StatusCode)
            {
                case HttpStatusCode.OK: return note.Content.ReadAsAsync<Note>().Result;
                default: throw new Exception("Не удалось получить заметку!");
            }
            
        }
        public void DellCategory(Guid categoryid)
        {
            var res= _client.DeleteAsync($"categories/{categoryid}").Result;
            switch (res.StatusCode)
            {
                case HttpStatusCode.OK: return;
                case HttpStatusCode.NoContent: return;
                default: throw new Exception("Не удалось удалить категорию!");
            }

        }
        public IEnumerable<Category> GetCategoriesofNote(Guid noteid)
        {
            var notes = _client.GetAsync($"categories/note/{noteid}").Result;
            switch (notes.StatusCode)
            {
                case HttpStatusCode.OK: return notes.Content.ReadAsAsync<IEnumerable<Category>>().Result;
                default: throw new Exception("Не удалось получить категории заметки");
            }
           
        }
        public IEnumerable<Category> GetfreeCategoriesofNote(Guid noteid, Guid userid)
        {
            var notes = _client.GetAsync($"categories/note/{noteid}/user/{userid}").Result;
            switch (notes.StatusCode)
            {
                case HttpStatusCode.OK: return notes.Content.ReadAsAsync<IEnumerable<Category>>().Result;
                default: throw new Exception("Не удалось получить свободные  категории  для заметки");
            }
        }
        public IEnumerable<Note> GetSharestoMe(Guid userid)
        {
            var notes = _client.GetAsync($"shares/touser/{userid}").Result;
            switch (notes.StatusCode)
            {
                case HttpStatusCode.OK: return notes.Content.ReadAsAsync<IEnumerable<Note>>().Result;
                default: throw new Exception("Не удалось получить заметки от других пользователей");
            }
        }
        public Category CategoryUpdate(Category category)
        {
            var categoryres = _client.PutAsJsonAsync("categories", category).Result;
            switch (categoryres.StatusCode)
            {
                case HttpStatusCode.OK: return categoryres.Content.ReadAsAsync<Category>().Result;
                default: throw new Exception("Не удалось обновить категорию!");
            }
        }
        public Category GetCategory(Guid categoryid)
        {
            var category = _client.GetAsync($"categories/{categoryid}").Result;
            switch (category.StatusCode)
            {
                case HttpStatusCode.OK: return category.Content.ReadAsAsync<Category>().Result;
                default: throw new Exception("Не удалось получить категорию!");
            }
     
        }
        public User UpdateUser(User user)
        {
            var userres = _client.PutAsJsonAsync("users", user).Result;
            switch (userres.StatusCode)
            {
                case HttpStatusCode.OK: return userres.Content.ReadAsAsync<User>().Result;
                default: throw new Exception("Не удалось обновить информацию!");
            }
        }
        public void dellNotefromCategory(Guid noteid,Guid categoryid)
        {
            var res = _client.DeleteAsync($"categories/{categoryid}/note/{noteid}").Result;
            switch (res.StatusCode)
            {
                case HttpStatusCode.OK: return;
                case HttpStatusCode.NoContent: return;
                default: throw new Exception("Не удалось удалить заметку!");
            }
        }
        public IEnumerable<Note> GetSharesfromMe(Guid userid)
        {
            var notes = _client.GetAsync($"shares/fromuser/{userid}").Result;
            switch (notes.StatusCode)
            {
                case HttpStatusCode.OK: return notes.Content.ReadAsAsync<IEnumerable<Note>>().Result;
                default: throw new Exception("Не удалось получить заметки от других пользователей");
            }
        }
        public void DellShare(Share share)
        {
            var res = _client.DeleteAsync($"shares/user/{share.DestinationUserId}/note/{share.SharedNoteId}").Result;
            switch (res.StatusCode)
            {
                case HttpStatusCode.OK: return;
                case HttpStatusCode.NoContent: return;
                default: throw new Exception("Не удалось удалить шару!");
            }
        }


    }
}
