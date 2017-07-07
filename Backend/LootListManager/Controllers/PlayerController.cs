using LootListManager.BindingModels;
using LootListManager.Connectors;
using LootListManager.Util;
using LootListManager.ViewModels;
using System;
using System.Collections.Generic;
using System.Globalization;
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

    #region -- Class --

    [HttpGet]
    [Route("Classes")]
    public IHttpActionResult GetClasss() {
      Exception ex = null;
      LinkContainer<ClassViewModel> classes = null;

      try {
        var requestUri = Request.RequestUri;
        // todo -> save in auth token after authorization is implemented
        var cultureInfo = new CultureInfo("de-CH");
        classes = new LinkContainer<ClassViewModel>(_playerConnector.GetClasses().Select(x => new ClassViewModel(x, cultureInfo)).ToList());

        foreach (var c in classes.Items) {
          c.AddLink(new Link(requestUri, HttpMethod.Get, RelValues.Self, ActionValues.Load, "players/classes/" + c.ClassId));
        }

        classes.AddLink(new Link(requestUri, HttpMethod.Post, RelValues.Child, ActionValues.Create, "players/classes"));
      } catch (Exception e) {
        ex = e;
      }

      return GetHttpActionResult(classes, ex);
    }

    [HttpGet]
    [Route("Classes/{id:int}")]
    public IHttpActionResult GetClass([FromUri] int id) {
      Exception ex = null;
      ClassViewModel c = null;

      try {
        var requestUri = Request.RequestUri;
        // todo -> save in auth token after authorization is implemented
        var cultureInfo = new CultureInfo("de-CH");
        c = new ClassViewModel(_playerConnector.GetClass(id), cultureInfo);

        c.AddLink(new Link(requestUri, HttpMethod.Get, RelValues.Self, ActionValues.Refresh, "players/Classes/" + c.ClassId));
        c.AddLink(new Link(requestUri, HttpMethod.Put, RelValues.Self, ActionValues.Update, "players/Classes/" + c.ClassId));
        c.AddLink(new Link(requestUri, HttpMethod.Delete, RelValues.Self, ActionValues.Delete, "players/Classes/" + c.ClassId));
      } catch (Exception e) {
        ex = e;
      }

      return GetHttpActionResult(c, ex);
    }

    [HttpPost]
    [Route("Classes")]
    public IHttpActionResult CreateClass([FromBody] ClassBindingModel c, [FromBody] ResourceEntryBindingModel className) {
      Exception ex = null;

      try {
        _playerConnector.SaveClass(c.GetEntity());
        _resourceConnector.AddResource(className.GetResourceEntry(c.GetEntity().GetType().Name));
      } catch (Exception e) {
        ex = e;
      }

      return GetHttpActionResult(ex);
    }

    [HttpPut]
    [Route("Classes/{id:int}")]
    public IHttpActionResult UpdateClass([FromUri] int id, [FromBody] ClassBindingModel c) {
      Exception ex = null;

      try {
        _playerConnector.SaveClass(c.GetEntity());
      } catch (Exception e) {
        ex = e;
      }

      return GetHttpActionResult(ex);
    }

    [HttpDelete]
    [Route("Classes/{id:int}")]
    public IHttpActionResult DeleteClass([FromUri] int id) {
      Exception ex = null;

      try {
        _playerConnector.DeleteClass(id);
      } catch (Exception e) {
        ex = e;
      }

      return GetHttpActionResult(ex);
    }

    #endregion

    #region -- ClassRaceSetting --

    [HttpGet]
    [Route("ClassRaceSettings")]
    public IHttpActionResult GetClassRaceSettings() {
      Exception ex = null;
      LinkContainer<ClassRaceSettingViewModel> classRaceSettings = null;

      try {
        var requestUri = Request.RequestUri;
        classRaceSettings = new LinkContainer<ClassRaceSettingViewModel>(_playerConnector.GetClassRaceSettings().Select(x => new ClassRaceSettingViewModel(x)).ToList());

        foreach (var classRaceSetting in classRaceSettings.Items) {
          classRaceSetting.AddLink(new Link(requestUri, HttpMethod.Get, RelValues.Self, ActionValues.Load, "players/classracesettings/" + classRaceSetting.ClassRaceSettingId));
        }

        classRaceSettings.AddLink(new Link(requestUri, HttpMethod.Post, RelValues.Child, ActionValues.Create, "players/classracesettings"));
      } catch (Exception e) {
        ex = e;
      }

      return GetHttpActionResult(classRaceSettings, ex);
    }

    [HttpGet]
    [Route("ClassRaceSettings/{id:int}")]
    public IHttpActionResult GetClassRaceSetting([FromUri] int id) {
      Exception ex = null;
      ClassRaceSettingViewModel classRaceSetting = null;

      try {
        var requestUri = Request.RequestUri;
        classRaceSetting = new ClassRaceSettingViewModel(_playerConnector.GetClassRaceSetting(id));

        classRaceSetting.AddLink(new Link(requestUri, HttpMethod.Get, RelValues.Self, ActionValues.Refresh, "players/classracesettings/" + classRaceSetting.ClassRaceSettingId));
        classRaceSetting.AddLink(new Link(requestUri, HttpMethod.Put, RelValues.Self, ActionValues.Update, "players/classracesettings/" + classRaceSetting.ClassRaceSettingId));
        classRaceSetting.AddLink(new Link(requestUri, HttpMethod.Delete, RelValues.Self, ActionValues.Delete, "players/classracesettings/" + classRaceSetting.ClassRaceSettingId));
      } catch (Exception e) {
        ex = e;
      }

      return GetHttpActionResult(classRaceSetting, ex);
    }

    [HttpPost]
    [Route("ClassRaceSettings")]
    public IHttpActionResult CreateClassRaceSetting([FromBody] ClassRaceSettingBindingModel classRaceSetting) {
      Exception ex = null;

      try {
        _playerConnector.SaveClassRaceSetting(_bindingModelFactory.GetClassRaceSettingFromModel(classRaceSetting));
      } catch (Exception e) {
        ex = e;
      }

      return GetHttpActionResult(ex);
    }

    [HttpPut]
    [Route("ClassRaceSettings/{id:int}")]
    public IHttpActionResult UpdateClassRaceSetting([FromUri] int id, [FromBody] ClassRaceSettingBindingModel classRaceSetting) {
      Exception ex = null;

      try {
        _playerConnector.SaveClassRaceSetting(_bindingModelFactory.GetClassRaceSettingFromModel(classRaceSetting));
      } catch (Exception e) {
        ex = e;
      }

      return GetHttpActionResult(ex);
    }

    [HttpDelete]
    [Route("ClassRaceSettings/{id:int}")]
    public IHttpActionResult DeleteClassRaceSetting([FromUri] int id) {
      Exception ex = null;

      try {
        _playerConnector.DeleteClassRaceSetting(id);
      } catch (Exception e) {
        ex = e;
      }

      return GetHttpActionResult(ex);
    }

    #endregion

    #region -- Faction --

    [HttpGet]
    [Route("Factions")]
    public IHttpActionResult GetFactions() {
      Exception ex = null;
      LinkContainer<FactionViewModel> factions = null;

      try {
        var requestUri = Request.RequestUri;
        // todo -> save in auth token after authorization is implemented
        var cultureInfo = new CultureInfo("de-CH");
        factions = new LinkContainer<FactionViewModel>(_playerConnector.GetFactions().Select(x => new FactionViewModel(x, cultureInfo)).ToList());

        foreach (var faction in factions.Items) {
          faction.AddLink(new Link(requestUri, HttpMethod.Get, RelValues.Self, ActionValues.Load, "players/factions/" + faction.FactionId));
        }

        factions.AddLink(new Link(requestUri, HttpMethod.Post, RelValues.Child, ActionValues.Create, "players/factions"));
      } catch (Exception e) {
        ex = e;
      }

      return GetHttpActionResult(factions, ex);
    }

    [HttpGet]
    [Route("Factions/{id:int}")]
    public IHttpActionResult GetFaction([FromUri] int id) {
      Exception ex = null;
      FactionViewModel faction = null;

      try {
        var requestUri = Request.RequestUri;
        // todo -> save in auth token after authorization is implemented
        var cultureInfo = new CultureInfo("de-CH");
        faction = new FactionViewModel(_playerConnector.GetFaction(id), cultureInfo);

        faction.AddLink(new Link(requestUri, HttpMethod.Get, RelValues.Self, ActionValues.Refresh, "players/factions/" + faction.FactionId));
        faction.AddLink(new Link(requestUri, HttpMethod.Put, RelValues.Self, ActionValues.Update, "players/factions/" + faction.FactionId));
        faction.AddLink(new Link(requestUri, HttpMethod.Delete, RelValues.Self, ActionValues.Delete, "players/factions/" + faction.FactionId));
      } catch (Exception e) {
        ex = e;
      }

      return GetHttpActionResult(faction, ex);
    }

    [HttpPost]
    [Route("Factions")]
    public IHttpActionResult CreateFaction([FromBody] FactionBindingModel faction, [FromBody] ResourceEntryBindingModel factionName) {
      Exception ex = null;

      try {
        _playerConnector.SaveFaction(faction.GetEntity());
        _resourceConnector.AddResource(factionName.GetResourceEntry(faction.GetEntity().GetType().Name));
      } catch (Exception e) {
        ex = e;
      }

      return GetHttpActionResult(ex);
    }

    [HttpPut]
    [Route("Factions/{id:int}")]
    public IHttpActionResult UpdateFaction([FromBody] FactionBindingModel faction) {
      Exception ex = null;

      try {
        _playerConnector.SaveFaction(faction.GetEntity());
      } catch (Exception e) {
        ex = e;
      }

      return GetHttpActionResult(ex);
    }

    [HttpDelete]
    [Route("Factions/{id:int}")]
    public IHttpActionResult DeleteFaction([FromUri] int id) {
      Exception ex = null;

      try {
        _playerConnector.DeleteFaction(id);
      } catch (Exception e) {
        ex = e;
      }

      return GetHttpActionResult(ex);
    }

    #endregion

    #region -- Need --

    #endregion

    #region -- Race --

    #endregion

    #region -- Talent --

    #endregion

    #endregion

  }
}
