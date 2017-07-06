using LootListManager.Logic.DataProviders;
using LootListManager.Logic.Entities.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LootListManager.Connectors {
  public class PlayerDataConnector {

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

  }
}