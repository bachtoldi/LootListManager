[HttpGet]
[Route("TABLEs")]
public IHttpActionResult GetTABLEs() {
  Exception ex = null;
  LinkContainer<TABLEViewModel> TABLEs = null;

  try {
    var requestUri = Request.RequestUri;
    TABLEs = new LinkContainer<TABLEViewModel>(_MODULEConnector.GetTABLEs().Select(x => new TABLEViewModel(x)).ToList());

    foreach (var TABLE in TABLEs.Items) {
      TABLE.AddLink(new Link(requestUri, HttpMethod.Get, RelValues.Self, ActionValues.Load, "MODULES/TABLEs/" + TABLE.TABLEId));
    }

    TABLEs.AddLink(new Link(requestUri, HttpMethod.Post, RelValues.Child, ActionValues.Create, "MODULES/TABLEs"));
  } catch (Exception e) {
    ex = e;
  }

  return GetHttpActionResult(TABLEs, ex);
}

[HttpGet]
[Route("TABLEs/{id:int}")]
public IHttpActionResult GetTABLE([FromUri] int id) {
  Exception ex = null;
  TABLEViewModel TABLE = null;

  try {
    var requestUri = Request.RequestUri;
    // todo -> save in auth token after authorization is implemented
    var cultureInfo = new CultureInfo("de-CH");
    TABLE = new TABLEViewModel(_MODULEConnector.GetTABLE(id), cultureInfo);

    TABLE.AddLink(new Link(requestUri, HttpMethod.Get, RelValues.Self, ActionValues.Refresh, "MODULES/TABLEs/" + TABLE.TABLEId));
    TABLE.AddLink(new Link(requestUri, HttpMethod.Put, RelValues.Self, ActionValues.Update, "MODULES/TABLEs/" + TABLE.TABLEId));
    TABLE.AddLink(new Link(requestUri, HttpMethod.Delete, RelValues.Self, ActionValues.Delete, "MODULES/TABLEs/" + TABLE.TABLEId));
  }catch(Exception e) {
    ex = e;
  }

  return GetHttpActionResult(TABLE, ex);
}