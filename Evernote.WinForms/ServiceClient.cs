using Evernote.Model;
using System;
using System.Collections.Generic;
using System.Linq;
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
            user = _client.PostAsJsonAsync("users", user).Result.Content.ReadAsAsync<User>().Result;
            return user;
        }
        public User FindUser(string Login, string Password)
        {
            User user = _client.GetAsync($"users/{Login}/{Password}").Result.Content.ReadAsAsync<User>().Result;
            return user;
        }
        public Category CreateCategory(Category category, Guid ownerid)
        {
            category = _client.PostAsJsonAsync($"users/{ownerid}/categories", category).Result.Content.ReadAsAsync<Category>().Result;
            return category;
        }
        public IEnumerable<Category> GetUserCategories(Guid userid)
        {
            IEnumerable<Category> category = _client.GetAsync($"users/{userid}/categories").Result.Content.ReadAsAsync<IEnumerable<Category>>().Result;
            return category;
        }
        public Note CreateNote(Note note)
        {
            Note resnote = _client.PostAsJsonAsync("notes", note).Result.Content.ReadAsAsync<Note>().Result;
            return resnote;
        }
        public IEnumerable<Note> GetUserNotes(Guid userid)
        {
            IEnumerable<Note> notes = _client.GetAsync($"users/{userid}/notes").Result.Content.ReadAsAsync<IEnumerable<Note>>().Result;
            return notes;
        }
        public void DeleteNote(Guid noteid)
        {
            _client.DeleteAsync($"notes/{noteid}");
        }
        public Note UpdateNote(Note note)
        {
            Note resnote = _client.PutAsJsonAsync("notes", note).Result.Content.ReadAsAsync<Note>().Result;
            return resnote;
        }
        public IEnumerable<Note> GetNotesofCategory(Guid categoryid)
        {
            IEnumerable<Note> notes = _client.GetAsync($"categories/{categoryid}/notes").Result.Content.ReadAsAsync<IEnumerable<Note>>().Result;
            return notes;
        }
        public IEnumerable<User> GetAllUsersexpectedMe(Guid userexpected)
        {
            IEnumerable<User> users = _client.GetAsync($"users/{userexpected}/expected").Result.Content.ReadAsAsync<IEnumerable<User>>().Result;
            return users;
        }
        public Share CreatShare(Share share)
        {
            Share shareres = _client.PostAsJsonAsync("shares", share).Result.Content.ReadAsAsync<Share>().Result;
            return shareres;

        }
        public IEnumerable<Note> GetShareMe(Guid userid)
        {
            IEnumerable<Note> notes = _client.GetAsync($"shares/user/{userid}").Result.Content.ReadAsAsync<IEnumerable<Note>>().Result;
            return notes;
        }
        public void AddNoteIntoCategory(Guid categoryid, Note note)
        {
            _client.PostAsJsonAsync($"categories/{categoryid}/add",note);

        }

        public Note GetNote(Guid noteid)
        {
            Note note = _client.GetAsync($"notes/{noteid}").Result.Content.ReadAsAsync<Note>().Result;
            return note;
        }

        public void DellCategory(Guid categoryid)
        {
            _client.DeleteAsync($"categories/{categoryid}");

        }

        public IEnumerable<Category> GetCategoriesofNote(Guid noteid)
        {
            IEnumerable<Category> notes = _client.GetAsync($"categories/note/{noteid}").Result.Content.ReadAsAsync<IEnumerable<Category>>().Result;
            return notes;
        }

        public IEnumerable<Category> GetfreeCategoriesofNote(Guid noteid)
        {
            IEnumerable<Category> notes = _client.GetAsync($"categories/free/note/{noteid}").Result.Content.ReadAsAsync<IEnumerable<Category>>().Result;
            return notes;
        }

        public IEnumerable<Note> GetSharesofUser(Guid userid)
        {
            IEnumerable<Note> notes = _client.GetAsync($"shares/user/{userid}").Result.Content.ReadAsAsync<IEnumerable<Note>>().Result;
            return notes;
        }
        public Category CategoryUpdate(Category category)
        {
            Category categoryres = _client.PutAsJsonAsync("categories", category).Result.Content.ReadAsAsync<Category>().Result;
            return categoryres;
        }
        public Category GetCategory(Guid categoryid)
        {
            Category category = _client.GetAsync($"categories/{categoryid}").Result.Content.ReadAsAsync<Category>().Result;
            return category;
        }

        public User UpdateUser(User user)
        {
            User userres = _client.PutAsJsonAsync("users", user).Result.Content.ReadAsAsync<User>().Result;
            return userres;
        }


    }
}
