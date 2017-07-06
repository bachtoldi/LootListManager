using LootListManager.Connectors;
using LootListManager.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LootListManager.Controllers {
  [RoutePrefix("Players")]
  public class PlayerController : BaseController {

    #region - Instance Variables -

    private readonly PlayerDataConnector _playerConnector;
    private readonly ResourceDataConnector _resourceConnector;

    #endregion

    #region - Constructor -

    public PlayerController() : base() {
      _playerConnector = new PlayerDataConnector();
      _resourceConnector = new ResourceDataConnector();
    }

    #endregion

    #region - API -

    #region -- Characters --

    [HttpGet]
    [Route("Characters")]
    public IHttpActionResult GetCharacters() {

      Exception ex = null;
      LinkContainer<CharacterViewModel> characters = null;

      try {
        var requestUri = Request.RequestUri;
        characters = new LinkContainer<CharacterViewModel>(_playerConnector.GetCharacters());

        foreach(var character in characters.Items) {
          character.AddLink(new Link(requestUri, HttpMethod.Get, RelValues.Self, ActionValues.Load, "players/characters/" + character.CharacterId));
        }

        characters.AddLink(new Util.Link(requestUri, HttpMethod.Post, RelValues.Child, ActionValues.Create, "players/characters"));
      }catch(Exception e) {
        ex = e;
      }

      return GetHttpActionResult(characters, ex);
    }

    #endregion

    #endregion

  }
}
