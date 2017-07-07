using LootListManager.Logic.DataProviders;
using LootListManager.Logic.Entities.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LootListManager.Connectors {
  internal class PlayerDataConnector {

    #region - Instance Variables -

    private readonly IPlayerDataProvider _dataProvider;

    #endregion

    #region - Constructor -

    public PlayerDataConnector() {
      _dataProvider = DataProviderFactory.GetPlayerDataProvider();
    }

    #endregion

    #region - Character -

    public Character GetCharacter(int id) {
      return _dataProvider.GetCharacter(id);
    }

    public IList<Character> GetCharacters() {
      return _dataProvider.GetCharacters();
    }

    public void SaveCharacter(Character character) {
      _dataProvider.SaveCharacter(character);
    }

    public void DeleteCharacter(int id) {
      _dataProvider.DeleteCharacter(id);
    }

    #endregion

    #region - Class -

    public Class GetClass(int id) {
      return _dataProvider.GetClass(id);
    }

    public IList<Class> GetClasses() {
      return _dataProvider.GetClasses();
    }

    public void SaveClass(Class c) {
      _dataProvider.SaveClass(c);
    }

    public void DeleteClass(int id) {
      _dataProvider.DeleteClass(id);
    }

    #endregion

    #region - ClassRaceSetting -

    public ClassRaceSetting GetClassRaceSetting(int id) {
      return _dataProvider.GetClassRaceSetting(id);
    }

    public IList<ClassRaceSetting> GetClassRaceSettings() {
      return _dataProvider.GetClassRaceSettings();
    }

    public void SaveClassRaceSetting(ClassRaceSetting classRaceSetting) {
      _dataProvider.SaveClassRaceSetting(classRaceSetting);
    }

    public void DeleteClassRaceSetting(int id) {
      _dataProvider.DeleteClassRaceSetting(id);
    }

    #endregion

    #region - Faction -

    public Faction GetFaction(int id) {
      return _dataProvider.GetFaction(id);
    }

    public IList<Faction> GetFactions() {
      return _dataProvider.GetFactions();
    }

    public void SaveFaction(Faction faction) {
      _dataProvider.SaveFaction(faction);
    }

    public void DeleteFaction(int id) {
      _dataProvider.DeleteFaction(id);
    }

    #endregion

    #region - Need -

    public Need GetNeed(int id) {
      return _dataProvider.GetNeed(id);
    }

    public IList<Need> GetNeeds() {
      return _dataProvider.GetNeeds();
    }

    public void SaveNeed(Need need) {
      _dataProvider.SaveNeed(need);
    }

    public void DeleteNeed(int id) {
      _dataProvider.DeleteNeed(id);
    }

    #endregion

    #region - Race -

    public Race GetRace(int id) {
      return _dataProvider.GetRace(id);
    }

    public IList<Race> GetRaces() {
      return _dataProvider.GetRaces();
    }

    public void SaveRace(Race race) {
      _dataProvider.SaveRace(race);
    }

    public void DeleteRace(Race race) {
      _dataProvider.DeleteRace(race);
    }

    #endregion

    #region - Talent -

    public Talent GetTalent(int id) {
      return _dataProvider.GetTalent(id);
    }

    public IList<Talent> GetTalents() {
      return _dataProvider.GetTalents();
    }

    public void SaveTalent(Talent talent) {
      _dataProvider.SaveTalent(talent);
    }

    public void DeleteTalent(int id) {
      _dataProvider.DeleteTalent(id);
    }

    #endregion

  }
}