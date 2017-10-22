using Evernote.DataLayer;
using Evernote.DataLayer.Sql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Evernote.API.Controllers
{
    public class SharesController : ApiController
    {

        private const string ConnectionString = @"Data Source=ANDREY-PK\SQLEXPRESS;Initial Catalog=EverNoteDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private readonly ISharedRepository _sharesRepository;

        public SharesController()
        {
            _sharesRepository = new SharedRepository(ConnectionString, new UsersRepository(ConnectionString,new CategoriesRepository(ConnectionString)));
        }

        [HttpPost]
        [Route("api/shares")]
        public Share Post([FromBody] Share share)
        {
            return _sharesRepository.ShareCreate(share);
        }

        [HttpGet]
        [Route("api/shares/user/{id}")]
        public IEnumerable<Note> GetShares(Guid userid)
        {
            return _sharesRepository.GetShares(userid);
        }

        [HttpDelete]
        [Route("api/shares/delete")]
        public void Sharesdelete([FromBody]Share share)
        {
             _sharesRepository.ShareDelete(share);
        }

    }
}
