using Microsoft.AspNet.Identity;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LootListManager.Controllers {
  [Authorize]
  public class BaseController : ApiController {

    #region - Instance Variables -



    #endregion

    #region - Constructor -

    public BaseController() { }

    #endregion

    #region - Properties -

    protected int UserId {
      get {
        var idString = User.Identity.GetUserId();
        var id = default(int);

        if (Int32.TryParse(idString, out id)) {
          return id;
        } else {
          return 0;
        }
      }
    }

    #endregion

    #region - Private Methods -

    protected IHttpActionResult GetHttpActionResult(object result, Exception ex) {

      if (result != null && ex == null) {
        return Ok(result);
      }

      if (ex != null) {
        return ResponseMessage(Request.CreateResponse(HttpStatusCode.BadRequest, ex));
      }

      if (result == null && ex == null) {
        return NotFound();
      }

      return InternalServerError();

    }

    protected IHttpActionResult GetHttpActionResult(Exception ex) {

      if (ex != null) {
        return ResponseMessage(Request.CreateResponse(HttpStatusCode.BadRequest, ex));
      }

      if (ex == null) {
        return Ok();
      }

      return InternalServerError();

    }

    #endregion

  }
}
