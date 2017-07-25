using LootListManager.BindingModels;
using LootListManager.Connectors;
using LootListManager.Util;
using LootListManager.ViewModels;
using System;
using System.Linq;
using System.Net.Http;
using System.Web.Http;

namespace LootListManager.Controllers {
  [RoutePrefix("Players")]
  public class PlayerController : BaseController {

    #region - Instance Variables -

    private readonly PlayerDataConnector _playerConnector;
    private readonly BindingModelFactory _bindingModelFactory;

    #endregion

    #region - Constructor -

    public PlayerController() : base() {
      _playerConnector = new PlayerDataConnector();
      _bindingModelFactory = new BindingModelFactory();
    }

    #endregion

    #region - API -

    #region -- Characters --

    [HttpGet]
    [Route("Characters")]
    public IHttpActionResult GetCharacters([FromUri] int userId = 0) {
      Exception ex = null;
      LinkContainer<CharacterViewModel> characters = null;

      try {
        var requestUri = Request.RequestUri;
        var charactersFromDatabase = (userId == 0) ? _playerConnector.GetCharacters() : _playerConnector.GetCharacters(userId);
        characters = new LinkContainer<CharacterViewModel>(charactersFromDatabase.Select(x => new CharacterViewModel(x)).ToList());

        foreach (var character in characters.Items) {
          character.AddLink(new Link(requestUri, HttpMethod.Get, RelValues.Self, ActionValues.Load, "players/characters/" + character.CharacterId));
        }

        characters.AddLink(new Link(requestUri, HttpMethod.Post, RelValues.Child, ActionValues.Create, "players/characters"));
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
    public IHttpActionResult GetClasses([FromUri] int raceId = 0) {
      Exception ex = null;
      LinkContainer<ClassViewModel> classes = null;

      try {
        var requestUri = Request.RequestUri;
        var classesFromDatabase = (raceId == 0) ? _playerConnector.GetClasses() : _playerConnector.GetClasses(raceId);
        classes = new LinkContainer<ClassViewModel>(classesFromDatabase.Select(x => new ClassViewModel(x)).ToList());

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
        c = new ClassViewModel(_playerConnector.GetClass(id));

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
    public IHttpActionResult CreateClass([FromBody] ClassBindingModel c) {
      Exception ex = null;

      try {
        _playerConnector.SaveClass(c.GetEntity());
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
        factions = new LinkContainer<FactionViewModel>(_playerConnector.GetFactions().Select(x => new FactionViewModel(x)).ToList());

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
        faction = new FactionViewModel(_playerConnector.GetFaction(id));

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
    public IHttpActionResult CreateFaction([FromBody] FactionBindingModel faction) {
      Exception ex = null;

      try {
        _playerConnector.SaveFaction(faction.GetEntity());
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

    [HttpGet]
    [Route("Needs")]
    public IHttpActionResult GetNeeds() {
      Exception ex = null;
      LinkContainer<NeedViewModel> needs = null;

      try {
        var requestUri = Request.RequestUri;
        needs = new LinkContainer<NeedViewModel>(_playerConnector.GetNeeds().Select(x => new NeedViewModel(x)).ToList());

        foreach (var need in needs.Items) {
          need.AddLink(new Link(requestUri, HttpMethod.Get, RelValues.Self, ActionValues.Load, "players/needs/" + need.NeedId));
        }

        needs.AddLink(new Link(requestUri, HttpMethod.Post, RelValues.Child, ActionValues.Create, "players/needs"));
      } catch (Exception e) {
        ex = e;
      }

      return GetHttpActionResult(needs, ex);
    }

    [HttpGet]
    [Route("Needs/{id:int}")]
    public IHttpActionResult GetNeed([FromUri] int id) {
      Exception ex = null;
      NeedViewModel need = null;

      try {
        var requestUri = Request.RequestUri;
        need = new NeedViewModel(_playerConnector.GetNeed(id));

        need.AddLink(new Link(requestUri, HttpMethod.Get, RelValues.Self, ActionValues.Refresh, "players/needs/" + need.NeedId));
        need.AddLink(new Link(requestUri, HttpMethod.Put, RelValues.Self, ActionValues.Update, "players/needs/" + need.NeedId));
        need.AddLink(new Link(requestUri, HttpMethod.Delete, RelValues.Self, ActionValues.Delete, "players/needs/" + need.NeedId));
      } catch (Exception e) {
        ex = e;
      }

      return GetHttpActionResult(need, ex);
    }

    [HttpPost]
    [Route("Needs")]
    public IHttpActionResult CreateNeed([FromBody] NeedBindingModel need) {
      Exception ex = null;

      try {
        _playerConnector.SaveNeed(_bindingModelFactory.GetNeedFromModel(need));
      } catch (Exception e) {
        ex = e;
      }

      return GetHttpActionResult(ex);
    }

    [HttpPut]
    [Route("Needs/{id:int}")]
    public IHttpActionResult UpdateNeed([FromUri] int id, [FromBody] NeedBindingModel need) {
      Exception ex = null;

      try {
        _playerConnector.SaveNeed(_bindingModelFactory.GetNeedFromModel(need));
      } catch (Exception e) {
        ex = e;
      }

      return GetHttpActionResult(ex);
    }

    [HttpDelete]
    [Route("Needs/{id:int}")]
    public IHttpActionResult DeleteNeed([FromUri] int id) {
      Exception ex = null;

      try {
        _playerConnector.DeleteNeed(id);
      } catch (Exception e) {
        ex = e;
      }

      return GetHttpActionResult(ex);
    }

    #endregion

    #region -- Race --

    [HttpGet]
    [Route("Races")]
    public IHttpActionResult GetRaces([FromUri] int factionId = 0) {
      Exception ex = null;
      LinkContainer<RaceViewModel> races = null;

      try {
        var requestUri = Request.RequestUri;
        var racesFromDatabase = (factionId == 0) ? _playerConnector.GetRaces() : _playerConnector.GetRaces(factionId);
        races = new LinkContainer<RaceViewModel>(racesFromDatabase.Select(x => new RaceViewModel(x)).ToList());

        foreach (var race in races.Items) {
          race.AddLink(new Link(requestUri, HttpMethod.Get, RelValues.Self, ActionValues.Load, "players/races/" + race.RaceId));
        }

        races.AddLink(new Link(requestUri, HttpMethod.Post, RelValues.Child, ActionValues.Create, "players/races"));
      } catch (Exception e) {
        ex = e;
      }

      return GetHttpActionResult(races, ex);
    }

    [HttpGet]
    [Route("races/{id:int}")]
    public IHttpActionResult GetRace([FromUri] int id) {
      Exception ex = null;
      RaceViewModel race = null;

      try {
        var requestUri = Request.RequestUri;
        race = new RaceViewModel(_playerConnector.GetRace(id));

        race.AddLink(new Link(requestUri, HttpMethod.Get, RelValues.Self, ActionValues.Refresh, "players/races/" + race.RaceId));
        race.AddLink(new Link(requestUri, HttpMethod.Put, RelValues.Self, ActionValues.Update, "players/races/" + race.RaceId));
        race.AddLink(new Link(requestUri, HttpMethod.Delete, RelValues.Self, ActionValues.Delete, "players/races/" + race.RaceId));
      } catch (Exception e) {
        ex = e;
      }

      return GetHttpActionResult(race, ex);
    }

    [HttpPost]
    [Route("Races")]
    public IHttpActionResult CreateRace([FromBody] RaceBindingModel race) {
      Exception ex = null;

      try {
        _playerConnector.SaveRace(_bindingModelFactory.GetRaceFromModel(race));
      } catch (Exception e) {
        ex = e;
      }

      return GetHttpActionResult(ex);
    }

    [HttpPut]
    [Route("Races/{id:int}")]
    public IHttpActionResult UpdateRace([FromUri] int id, [FromBody] RaceBindingModel race) {
      Exception ex = null;

      try {
        _playerConnector.SaveRace(_bindingModelFactory.GetRaceFromModel(race));
      } catch (Exception e) {
        ex = e;
      }

      return GetHttpActionResult(ex);
    }

    [HttpDelete]
    [Route("Races/{id:int}")]
    public IHttpActionResult DeleteRace([FromUri] int id) {
      Exception ex = null;

      try {
        _playerConnector.DeleteRace(id);
      } catch (Exception e) {
        ex = e;
      }

      return GetHttpActionResult(ex);
    }

    #endregion

    #region -- Talent --

    [HttpGet]
    [Route("Talents")]
    public IHttpActionResult GetTalents([FromUri] int classId = 0) {
      Exception ex = null;
      LinkContainer<TalentViewModel> talents = null;

      try {
        var requestUri = Request.RequestUri;
        var talentsFromDatabase = (classId == 0) ? _playerConnector.GetTalents() : _playerConnector.GetTalents(classId);
        talents = new LinkContainer<TalentViewModel>(talentsFromDatabase.Select(x => new TalentViewModel(x)).ToList());

        foreach (var talent in talents.Items) {
          talent.AddLink(new Link(requestUri, HttpMethod.Get, RelValues.Self, ActionValues.Load, "players/talents/" + talent.TalentId));
        }

        talents.AddLink(new Link(requestUri, HttpMethod.Post, RelValues.Child, ActionValues.Create, "players/talents"));
      } catch (Exception e) {
        ex = e;
      }

      return GetHttpActionResult(talents, ex);
    }

    [HttpGet]
    [Route("Talents/{id:int}")]
    public IHttpActionResult GetTalent([FromUri] int id) {
      Exception ex = null;
      TalentViewModel talent = null;

      try {
        var requestUri = Request.RequestUri;
        talent = new TalentViewModel(_playerConnector.GetTalent(id));

        talent.AddLink(new Link(requestUri, HttpMethod.Get, RelValues.Self, ActionValues.Refresh, "players/talents/" + talent.TalentId));
        talent.AddLink(new Link(requestUri, HttpMethod.Put, RelValues.Self, ActionValues.Update, "players/talents/" + talent.TalentId));
        talent.AddLink(new Link(requestUri, HttpMethod.Delete, RelValues.Self, ActionValues.Delete, "players/talents/" + talent.TalentId));
      } catch (Exception e) {
        ex = e;
      }

      return GetHttpActionResult(talent, ex);
    }

    [HttpPost]
    [Route("Talents")]
    public IHttpActionResult CreateTalent([FromBody] TalentBindingModel talent) {
      Exception ex = null;

      try {
        _playerConnector.SaveTalent(_bindingModelFactory.GetTalentFromModel(talent));
      } catch (Exception e) {
        ex = e;
      }

      return GetHttpActionResult(ex);
    }

    [HttpPut]
    [Route("Talents/{id:int}")]
    public IHttpActionResult UpdateTalent([FromUri] int id, [FromBody] TalentBindingModel talent) {
      Exception ex = null;

      try {
        _playerConnector.SaveTalent(_bindingModelFactory.GetTalentFromModel(talent));
      } catch (Exception e) {
        ex = e;
      }

      return GetHttpActionResult(ex);
    }

    [HttpDelete]
    [Route("Talents/{id:int}")]
    public IHttpActionResult DeleteTalent([FromUri] int id) {
      Exception ex = null;

      try {
        _playerConnector.DeleteTalent(id);
      } catch (Exception e) {
        ex = e;
      }

      return GetHttpActionResult(ex);
    }

    #endregion

    #endregion

  }
}
