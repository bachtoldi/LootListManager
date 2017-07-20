using LootListManager.Logic.Entities.Player;
using System.Collections.Generic;

namespace LootListManager.Logic.DataProviders {
  public interface IPlayerDataProvider {

    #region - Character -

    Character GetCharacter(int id);
    IList<Character> GetCharacters();
    IList<Character> GetCharacters(int userId);
    Character SaveCharacter(Character character);
    bool DeleteCharacter(int id);

    #endregion

    #region - Class -

    Class GetClass(int id);
    IList<Class> GetClasses();
    IList<Class> GetClasses(int raceId);
    Class SaveClass(Class c);
    bool DeleteClass(int id);

    #endregion

    #region - ClassRaceSetting -

    ClassRaceSetting GetClassRaceSetting(int id);
    IList<ClassRaceSetting> GetClassRaceSettings();
    ClassRaceSetting SaveClassRaceSetting(ClassRaceSetting classRaceSetting);
    bool DeleteClassRaceSetting(int id);

    #endregion

    #region - Faction -

    Faction GetFaction(int id);
    IList<Faction> GetFactions();
    Faction SaveFaction(Faction faction);
    bool DeleteFaction(int id);

    #endregion

    #region - Need -

    Need GetNeed(int id);
    IList<Need> GetNeeds();
    Need SaveNeed(Need need);
    bool DeleteNeed(int id);

    #endregion

    #region - Race -

    Race GetRace(int id);
    IList<Race> GetRaces();
    IList<Race> GetRaces(int factionId);
    Race SaveRace(Race race);
    bool DeleteRace(int id);

    #endregion

    #region - Talent -

    Talent GetTalent(int id);
    IList<Talent> GetTalents();
    IList<Talent> GetTalents(int classId);
    Talent SaveTalent(Talent talent);
    bool DeleteTalent(int id);

    #endregion

  }
}
