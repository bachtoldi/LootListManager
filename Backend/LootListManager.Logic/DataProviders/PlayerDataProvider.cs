using LootListManager.Logic.Entities.Player;
using System.Collections.Generic;
using System.Linq;

namespace LootListManager.Logic.DataProviders {
  internal class PlayerDataProvider : DataProvider, IPlayerDataProvider {

    #region - Character -

    public Character GetCharacter(int id) {
      return GetById<Character>(id);
    }

    public IList<Character> GetCharacters() {
      return GetList<Character>();
    }

    public IList<Character> GetCharacters(int userId) {
      return GetList<Character>().Where(x => x.UserRef.Id == userId).ToList();
    }

    public Character SaveCharacter(Character character) {
      Save(character);
      return GetById<Character>(character.CharacterId);
    }

    public bool DeleteCharacter(int id) {
      var character = GetCharacter(id);
      Delete(character);
      return GetById<Character>(id) == null;
    }

    #endregion

    #region - Class -

    public Class GetClass(int id) {
      return GetById<Class>(id);
    }

    public IList<Class> GetClasses() {
      return GetList<Class>();
    }

    public IList<Class> GetClasses(int raceId) {
      return GetList<ClassRaceSetting>().Where(x => x.RaceRef.RaceId == raceId).Select(x => x.ClassRef).ToList();
    }

    public IList<Class> GetClasses(string raceLogicalId) {
      return GetList<ClassRaceSetting>().Where(x => x.RaceRef.RaceLogicalId.Equals(raceLogicalId)).Select(x => x.ClassRef).ToList();
    }

    public Class SaveClass(Class c) {
      Save(c);
      return GetById<Class>(c.ClassId);
    }

    public bool DeleteClass(int id) {
      var c = GetClass(id);
      Delete(c);
      return GetById<Class>(id) == null;
    }

    #endregion

    #region - ClassRaceSetting -

    public ClassRaceSetting GetClassRaceSetting(int id) {
      return GetById<ClassRaceSetting>(id);
    }

    public IList<ClassRaceSetting> GetClassRaceSettings() {
      return GetList<ClassRaceSetting>();
    }

    public ClassRaceSetting SaveClassRaceSetting(ClassRaceSetting classRaceSetting) {
      Save(classRaceSetting);
      return GetById<ClassRaceSetting>(classRaceSetting.ClassRaceSettingId);
    }

    public bool DeleteClassRaceSetting(int id) {
      var classRaceSetting = GetClassRaceSetting(id);
      Delete(classRaceSetting);
      return GetById<ClassRaceSetting>(id) == null;
    }

    #endregion

    #region - Faction -

    public Faction GetFaction(int id) {
      return GetById<Faction>(id);
    }

    public IList<Faction> GetFactions() {
      return GetList<Faction>();
    }

    public Faction SaveFaction(Faction faction) {
      Save(faction);
      return GetById<Faction>(faction.FactionId);
    }

    public bool DeleteFaction(int id) {
      var faction = GetFaction(id);
      Delete(faction);
      return GetById<Faction>(id) == null;
    }

    #endregion

    #region - Need -

    public Need GetNeed(int id) {
      return GetById<Need>(id);
    }

    public IList<Need> GetNeeds() {
      return GetList<Need>();
    }

    public Need SaveNeed(Need need) {
      Save(need);
      return GetById<Need>(need.NeedId);
    }

    public bool DeleteNeed(int id) {
      var need = GetNeed(id);
      Delete(need);
      return GetById<Need>(id) == null;
    }

    #endregion

    #region - Race -

    public Race GetRace(int id) {
      return GetById<Race>(id);
    }

    public IList<Race> GetRaces() {
      return GetList<Race>();
    }

    public IList<Race> GetRaces(int factionId) {
      return GetList<Race>().Where(x => x.FactionRef.FactionId == factionId).ToList();
    }

    public IList<Race> GetRaces(string factionLogicalId) {
      return GetList<Race>().Where(x => x.FactionRef.FactionLogicalId.Equals(factionLogicalId)).ToList();
    }

    public Race SaveRace(Race race) {
      Save(race);
      return GetById<Race>(race.RaceId);
    }

    public bool DeleteRace(int id) {
      var race = GetRace(id);
      Delete(race);
      return GetById<Race>(id) == null;
    }

    #endregion

    #region - Talent -

    public Talent GetTalent(int id) {
      return GetById<Talent>(id);
    }

    public IList<Talent> GetTalents() {
      return GetList<Talent>();
    }

    public IList<Talent> GetTalents(int classId) {
      return GetList<Talent>().Where(x => x.ClassRef.ClassId == classId).ToList();
    }

    public IList<Talent> GetTalents(string classLogicalId) {
      return GetList<Talent>().Where(x => x.ClassRef.ClassLogicalId.Equals(classLogicalId)).ToList();
    }

    public Talent SaveTalent(Talent talent) {
      Save(talent);
      return GetById<Talent>(talent.TalentId);
    }

    public bool DeleteTalent(int id) {
      var talent = GetTalent(id);
      Delete(talent);
      return GetById<Talent>(id) == null;
    }

    #endregion

  }
}
