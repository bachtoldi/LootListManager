using LootListManager.Connectors;
using LootListManager.Logic.Entities.Auth;
using LootListManager.Logic.Entities.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LootListManager.BindingModels {
  internal class BindingModelFactory {

    #region - Instance Variables -

    private readonly PlayerDataConnector _playerConnector;
    private readonly AuthDataConnector _authConnector;
    private readonly EnvironmentDataConnector _environmentConnector;

    #endregion

    #region - Constructor -

    public BindingModelFactory() {
      _playerConnector = new PlayerDataConnector();
      _authConnector = new AuthDataConnector();
      _environmentConnector = new EnvironmentDataConnector();
    }

    #endregion

    #region - Public Methods -

    public Character GetCharacterFromModel(CharacterBindingModel model, int userId) {
      return new Character {
        CharacterName = model.CharacterName,
        UserRef = _authConnector.GetUser(userId),
        RaceRef = _playerConnector.GetRace(model.RaceFk),
        TalentRef = _playerConnector.GetTalent(model.TalentFk)
      };
    }

    #endregion

  }
}