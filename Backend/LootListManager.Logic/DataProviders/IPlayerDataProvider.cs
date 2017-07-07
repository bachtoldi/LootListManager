using LootListManager.Logic.Entities.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LootListManager.Logic.DataProviders {
  public interface IPlayerDataProvider {

    #region - Character -

    Character GetCharacter(int id);
    IList<Character> GetCharacters();
    Character SaveCharacter(Character character);
    bool DeleteCharacter(int id);

    #endregion

    #region - Class -

    Class GetClass(int id);
    IList<Class> GetClasses();
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

    #endregion

    #region - Need -

    #endregion

    #region - Race -

    #endregion

    #region - Talent -

    #endregion

  }
}
