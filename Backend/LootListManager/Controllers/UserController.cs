using LootListManager.DataProviders;
using System.Web.Http;

namespace LootListManager.Controllers {
  [RoutePrefix("User")]
  public class UserController : ApiController {

    #region - Instance Variables -

    private readonly DataProvider _dataProvider;

    #endregion

    #region - Constructor -

    public UserController(DataProvider dataProvider) {
      _dataProvider = dataProvider;
    }

    #endregion

    #region - API -

    [HttpGet]
    [Route("")]
    public IHttpActionResult Get() {
      var users = _dataProvider.GetUsers();

      return Ok(users);
    }

    [HttpGet]
    [Route("{id:int}")]
    public IHttpActionResult GetUser([FromUri] int id) {
      var user = _dataProvider.GetUser(id);

      return Ok(user);
    }

    #endregion

  }
}