using LootListManager.Logic.Entities.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LootListManager.Logic.DataProviders {
  internal class PlayerDataProvider : DataProvider, IPlayerDataProvider {

    #region - Character -

    public Character GetCharacter(int id) {
      return GetById<Character>(id);
    }

    public IList<Character> GetCharacters() {
      return GetList<Character>();
    }

    public Character SaveCharacter(Character character) {
      Save(character);
      return GetById<Character>(character.CharacterId);
    }

    public bool DeleteCharacter(int id) {
      var character = GetCharacter(id);
      Delete(character);
      return GetById<Character>(character.CharacterId) == null;
    }

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
