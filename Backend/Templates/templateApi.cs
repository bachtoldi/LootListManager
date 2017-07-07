[HttpGet]
    [Route("Tables")]
    public IHttpActionResult GetTables() {
      Exception ex = null;
      LinkContainer<TableViewModel> tables = null;

      try {
        var requestUri = Request.RequestUri;
        tables = new LinkContainer<TableViewModel>(_moduleConnector.GetTables().Select(x => new TableViewModel(x)).ToList());

        foreach (var table in tables.Items) {
          table.AddLink(new Link(requestUri, HttpMethod.Get, RelValues.Self, ActionValues.Load, "modules/tables/" + table.tableId));
        }

        tables.AddLink(new Link(requestUri, HttpMethod.Post, RelValues.Child, ActionValues.Create, "modules/tables"));
      } catch (Exception e) {
        ex = e;
      }

      return GetHttpActionResult(tables, ex);
    }