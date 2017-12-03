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
    /// <summary>
     /// Контроллер шар
     /// </summary>
    [FilterExceptions]
    public class SharesController : ApiController
    {

      
        private readonly ISharedRepository _sharesRepository;

        public SharesController()
        {
            _sharesRepository = new SharedRepository();
        }
        /// <summary>
        /// Создать шару
        /// </summary>
        /// <param name="share"> шара</param>
        /// <returns>шара</returns>
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
        /// <summary>
        /// Получить шары (заметки) пользователю
        /// </summary>
        /// <param name="id"> id пользователя</param>
        /// <returns> заметки</returns>
        [HttpGet]
        [Route("api/shares/touser/{id}")]
        public IEnumerable<Note> GetSharestoMe(Guid id)
        {
            Logger.Log.Instance.Info("Получение шары для пользователя с id: {0}", id);
            return _sharesRepository.GetSharestoMe(id);
        }
        /// <summary>
        /// Получить шары(заметки) от меня
        /// </summary>
        /// <param name="id"> id пользователя</param>
        /// <returns>заметки</returns>
        [HttpGet]
        [Route("api/shares/fromuser/{id}")]
        public IEnumerable<Note> GetSharesfromMe(Guid id)
        {
            Logger.Log.Instance.Info("Получение шары  от пользователя с id: {0}", id);
            return _sharesRepository.GetSharesfromMe(id);
        }
       /// <summary>
       /// Удаление шары
       /// </summary>
       /// <param name="DestinationUserID"> кому шары</param>
       /// <param name="SharedNoteID"> id заметки</param>
        [HttpDelete]
        [Route("api/shares/user/{DestinationUserID}/note/{SharedNoteID}")]
        public void Sharesdelete(Guid DestinationUserID,Guid SharedNoteID)
        {
             Logger.Log.Instance.Info("Удаление шары для пользователя с id: {0} c заметкой id которой {1}", DestinationUserID, SharedNoteID);
            _sharesRepository.ShareDelete(new Share { DestinationUserId=DestinationUserID, SharedNoteId= SharedNoteID });
        }

    }
}
