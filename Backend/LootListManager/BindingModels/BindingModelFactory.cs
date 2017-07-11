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
    private readonly ConfigDataConnector _configConnector;

    #endregion

    #region - Constructor -

    public BindingModelFactory() {
      _playerConnector = new PlayerDataConnector();
      _authConnector = new AuthDataConnector();
      _environmentConnector = new EnvironmentDataConnector();
      _configConnector = new ConfigDataConnector();
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

    public ClassRaceSetting GetClassRaceSettingFromModel(ClassRaceSettingBindingModel model) {
      return new ClassRaceSetting {
        ClassRef = _playerConnector.GetClass(model.ClassFk),
        RaceRef = _playerConnector.GetRace(model.RaceFk),
      };
    }

    public Need GetNeedFromModel(NeedBindingModel model) {
      return new Need {
        CharacterRef = _playerConnector.GetCharacter(model.CharacterFk),
        ItemRef = _environmentConnector.GetItem(model.ItemFk),
        NeedTypeRef = _configConnector.GetNeedType(model.NeedTypeFk),
        PriorityRef = _configConnector.GetPriority(model.PriorityFk)
      };
    }

    public Race GetRaceFromModel(RaceBindingModel model) {
      return new Race {
        FactionRef = _playerConnector.GetFaction(model.FactionFk)
      };
    }

    public Talent GetTalentFromModel(TalentBindingModel model) {
      return new Talent {
        TalentLogicalId = model.TalentLogicalId,
        ClassRef = _playerConnector.GetClass(model.ClassFk)
      };
    }

    #endregion

  }
}