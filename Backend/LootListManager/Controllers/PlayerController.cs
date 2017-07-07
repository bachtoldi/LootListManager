using LootListManager.BindingModels;
using LootListManager.Connectors;
using LootListManager.Util;
using LootListManager.ViewModels;
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
    private readonly BindingModelFactory _bindingModelFactory;

    #endregion

    #region - Constructor -

    public PlayerController() : base() {
      _playerConnector = new PlayerDataConnector();
      _resourceConnector = new ResourceDataConnector();
      _bindingModelFactory = new BindingModelFactory();
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
        characters = new LinkContainer<CharacterViewModel>(_playerConnector.GetCharacters().Select(x => new CharacterViewModel(x)).ToList());

        foreach (var character in characters.Items) {
          character.AddLink(new Link(requestUri, HttpMethod.Get, RelValues.Self, ActionValues.Load, "players/characters/" + character.CharacterId));
        }

        characters.AddLink(new Util.Link(requestUri, HttpMethod.Post, RelValues.Child, ActionValues.Create, "players/characters"));
      } catch (Exception e) {
        ex = e;
      }

      return GetHttpActionResult(characters, ex);
    }

    [HttpGet]
    [Route("Characters/{id:int}")]
    public IHttpActionResult GetCharacter([FromUri] int id) {
      Exception ex = null;
      CharacterViewModel character = null;

      try {
        var requestUri = Request.RequestUri;
        character = new CharacterViewModel(_playerConnector.GetCharacter(id));

        character.AddLink(new Link(requestUri, HttpMethod.Get, RelValues.Self, ActionValues.Refresh, "players/characters/" + character.CharacterId));
        character.AddLink(new Link(requestUri, HttpMethod.Put, RelValues.Self, ActionValues.Update, "players/characters/" + character.CharacterId));
        character.AddLink(new Link(requestUri, HttpMethod.Delete, RelValues.Self, ActionValues.Delete, "players/characters/" + character.CharacterId));
      } catch (Exception e) {
        ex = e;
      }

      return GetHttpActionResult(character, ex);
    }

    [HttpPost]
    [Route("Characters")]
    public IHttpActionResult CreateCharacter([FromBody] CharacterBindingModel character) {
      Exception ex = null;

      try {
        _playerConnector.SaveCharacter(_bindingModelFactory.GetCharacterFromModel(character, UserId));
      } catch (Exception e) {
        ex = e;
      }

      return GetHttpActionResult(ex);
    }

    [HttpPut]
    [Route("characters/{id:int}")]
    public IHttpActionResult UpdateCharacter([FromUri] int id, [FromBody] CharacterBindingModel character) {
      Exception ex = null;

      try {
        _playerConnector.SaveCharacter(_bindingModelFactory.GetCharacterFromModel(character, UserId));
      } catch (Exception e) {
        ex = e;
      }

      return GetHttpActionResult(ex);
    }

    [HttpDelete]
    [Route("Characters/{id:int}")]
    public IHttpActionResult DeleteCharacter([FromUri] int id) {
      Exception ex = null;

      try {
        _playerConnector.DeleteCharacter(id);
      } catch (Exception e) {
        ex = e;
      }

      return GetHttpActionResult(ex);
    }

    #endregion

    #endregion

  }
}
