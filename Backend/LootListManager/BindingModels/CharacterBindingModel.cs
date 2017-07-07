namespace LootListManager.BindingModels {
  public class CharacterBindingModel {

    #region - Properties -

    public string CharacterName { get; set; }
    public int RaceFk { get; set; }
    public int TalentFk { get; set; }

    #endregion

  }
}