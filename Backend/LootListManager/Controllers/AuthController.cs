using LootListManager.Auth;
using LootListManager.BindingModels;
using LootListManager.Connectors;
using LootListManager.Util;
using LootListManager.ViewModels;
using System;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using System.Web;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.AspNet.Identity;

namespace LootListManager.Controllers {
  [RoutePrefix("Auth")]
  public class AuthController : BaseController {

    #region - Instance Variables -

    private readonly AuthDataConnector _dataConnector;

    #endregion

    #region - Constructor -

    public AuthController() : base() {
      _dataConnector = new AuthDataConnector();
    }

    #endregion

    private ApplicationUserManager _userManager;

    public ApplicationUserManager UserManager {
      get {
        return _userManager ?? Request.GetOwinContext().GetUserManager<ApplicationUserManager>();
      }
      private set {
        _userManager = value;
      }
    }

    [HttpPost]
    [AllowAnonymous]
    [Route("Register")]
    public IHttpActionResult Register([FromBody] UserBindingModel userModel) {

      Exception ex = null;

      try {
        var result = UserManager.CreateAsync(userModel.GetAppUser(), userModel.UserPassword);
        if (!result.Result.Succeeded) {
          throw new Exception("user registration failed!");
        }
      } catch (Exception e) {
        ex = e;
      }

      return GetHttpActionResult(ex);
    }

    #region - User -

    [HttpGet]
    [Route("User")]
    public IHttpActionResult GetUsers() {

      Exception ex = null;
      LinkContainer<UserViewModel> users = null;

      try {
        var requestUri = Request.RequestUri;
        users = new LinkContainer<UserViewModel>(_dataConnector.GetUsers().Select(x => new UserViewModel(x)).ToList());

        foreach (var user in users.Items) {
          user.AddLink(new Link(requestUri, HttpMethod.Get, RelValues.Self, ActionValues.Load, "auth/user/" + user.UserId));
        }

        users.AddLink(new Link(requestUri, HttpMethod.Post, RelValues.Child, ActionValues.Create, "auth/user"));

      } catch (Exception e) {
        ex = e;
      }

      return GetHttpActionResult(users, ex);

    }

    [HttpGet]
    [Route("User/Current")]
    public IHttpActionResult GetCurrentUser() {

      Exception ex = null;
      UserViewModel user = null;

      try {
        user = new UserViewModel(_dataConnector.GetUser(UserId));
      }catch(Exception e) {
        ex = e;
      }

      return GetHttpActionResult(user, ex);

    }

    [HttpGet]
    [Route("User/{id:int}")]
    public IHttpActionResult GetUser([FromUri] int id) {

      Exception ex = null;
      UserViewModel user = null;

      try {
        var requestUri = Request.RequestUri;
        user = new UserViewModel(_dataConnector.GetUser(id));

        user.AddLink(new Link(requestUri, HttpMethod.Get, RelValues.Self, ActionValues.Refresh, "auth/user/" + user.UserId));
        user.AddLink(new Link(requestUri, HttpMethod.Put, RelValues.Self, ActionValues.Update, "auth/user/" + user.UserId));
        user.AddLink(new Link(requestUri, HttpMethod.Delete, RelValues.Self, ActionValues.Delete, "auth/user/" + user.UserId));

      } catch (Exception e) {
        ex = e;
      }

      return GetHttpActionResult(user, ex);

    }

    [HttpPost]
    [Route("User")]
    public IHttpActionResult CreateUser([FromBody] UserBindingModel user) {

      Exception ex = null;

      try {
        _dataConnector.SaveUser(user.GetEntity());
      } catch (Exception e) {
        ex = e;
      }

      return GetHttpActionResult(ex);

    }

    [HttpPut]
    [Route("User/{id}")]
    public IHttpActionResult UpdateUser([FromUri] string id, [FromBody] UserBindingModel user) {

      Exception ex = null;

      try {
        _dataConnector.SaveUser(user.GetEntity());
      } catch (Exception e) {
        ex = e;
      }

      return GetHttpActionResult(ex);

    }

    [HttpDelete]
    [Route("User/{id:int}")]
    public IHttpActionResult DeleteUser([FromUri] int id) {

      Exception ex = null;

      try {
        _dataConnector.DeleteUser(id);
      } catch (Exception e) {
        ex = e;
      }

      return GetHttpActionResult(ex);

    }

    #endregion

  }
}