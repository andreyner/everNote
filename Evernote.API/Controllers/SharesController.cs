using Evernote.API.Helper;
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
    [FilterExceptions]
    public class SharesController : ApiController
    {

        private const string ConnectionString = @"Data Source=ANDREY-PK\SQLEXPRESS;Initial Catalog=EverNoteDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private readonly ISharedRepository _sharesRepository;

        public SharesController()
        {
            _sharesRepository = new SharedRepository(ConnectionString, new UsersRepository(ConnectionString));
        }

        [HttpPost]
        [Route("api/shares")]
        public Share CreatShare([FromBody] Share share)
        {
            Logger.Log.Instance.Info("Создание шары для пользователя с id: {0} c заметкой id которой {1}", share.DestinationUserId,share.SharedNoteId);
            string errors = ModelValidator.Validate(ModelState);
            if (errors != null)
            {
                Logger.Log.Instance.Error(errors);
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState));
            }
            return _sharesRepository.ShareCreate(share);
        }

        [HttpGet]
        [Route("api/shares/user/{id}")]
        public IEnumerable<Note> GetSharesofUser(Guid id)
        {
            Logger.Log.Instance.Info("Получение шары пользователя с id: {0}", id);
            return _sharesRepository.GetShares(id);
        }

        [HttpDelete]
        [Route("api/shares")]
        public void Sharesdelete([FromBody]Share share)
        {
             Logger.Log.Instance.Info("Удаление шары для пользователя с id: {0} c заметкой id которой {1}", share.DestinationUserId, share.SharedNoteId);
            _sharesRepository.ShareDelete(share);
        }

    }
}
