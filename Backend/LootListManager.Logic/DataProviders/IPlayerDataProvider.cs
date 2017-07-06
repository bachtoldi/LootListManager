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

    #endregion

    #region - ClassRaceSetting -

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
