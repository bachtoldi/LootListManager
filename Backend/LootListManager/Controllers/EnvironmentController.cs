using LootListManager.BindingModels;
using LootListManager.Connectors;
using LootListManager.Util;
using LootListManager.ViewModels;
using System;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Web.Http;

namespace LootListManager.Controllers {
  [RoutePrefix("Environment")]
  public class EnvironmentController : BaseController {

    #region - Instance Variables -

    private readonly EnvironmentDataConnector _dataConnector;
    private readonly ResourceDataConnector _resourceConnector;

    #endregion

    #region - Constructor -

    public EnvironmentController() : base() {
      _dataConnector = new EnvironmentDataConnector();
      _resourceConnector = new ResourceDataConnector();
    }

    #endregion

    #region - Instance -

    [HttpGet]
    [Route("Instance")]
    public IHttpActionResult GetInstances() {

      Exception ex = null;
      LinkContainer<InstanceViewModel> instances = null;

      try {

        var requestUri = Request.RequestUri;
        // todo -> save in auth token after authorization is implemented
        var cultureInfo = new CultureInfo("de-CH");
        instances = new LinkContainer<InstanceViewModel>(_dataConnector.GetInstances().Select(x => new InstanceViewModel(x, cultureInfo)).ToList());

        foreach(var instance in instances.Items) {
          instance.AddLink(new Link(requestUri, HttpMethod.Get, RelValues.Self, ActionValues.Load, "environment/instance/" + instance.InstanceId));
        }

        instances.AddLink(new Link(requestUri, HttpMethod.Post, RelValues.Child, ActionValues.Create, "environment/instance"));

      } catch(Exception e) {
        ex = e;
      }

      return GetHttpActionResult(instances, ex);

    }

    [HttpGet]
    [Route("Instance/{id:int}")]
    public IHttpActionResult GetInstance([FromUri] int id) {

      Exception ex = null;
      InstanceViewModel instance = null;

      try {

        var requestUri = Request.RequestUri;
        // todo -> save in auth token after authorization is implemented
        var cultureInfo = new CultureInfo("de-CH");
        instance = new InstanceViewModel(_dataConnector.GetInstance(id), cultureInfo);

        instance.AddLink(new Link(requestUri, HttpMethod.Get, RelValues.Self, ActionValues.Refresh, "environment/instance/" + instance.InstanceId));
        instance.AddLink(new Link(requestUri, HttpMethod.Put, RelValues.Self, ActionValues.Update, "environment/instance/" + instance.InstanceId));
        instance.AddLink(new Link(requestUri, HttpMethod.Delete, RelValues.Self, ActionValues.Delete, "environment/instance/" + instance.InstanceId));

      } catch(Exception e) {
        ex = e;
      }

      return GetHttpActionResult(instance, ex);

    }

    [HttpPost]
    [Route("Instance/{id:int}")]
    public IHttpActionResult CreateInstance([FromBody] InstanceBindingModel instance, [FromBody] ResourceEntryBindingModel instanceName) {

      Exception ex = null;

      try {
        _dataConnector.SaveInstance(instance.GetEntity());
        _resourceConnector.AddResource(instanceName.GetResourceEntry(instance.GetEntity().GetType().Name));
      } catch(Exception e) {
        ex = e;
      }

      return GetHttpActionResult(ex);

    }

    [HttpPut]
    [Route("Instance/{id:int}")]
    public IHttpActionResult UpdateInstance([FromUri] int id, [FromBody] InstanceBindingModel instance) {

      Exception ex = null;

      try {
        _dataConnector.SaveInstance(instance.GetEntity());
      } catch(Exception e) {
        ex = e;
      }

      return GetHttpActionResult(ex);

    }

    [HttpDelete]
    [Route("Instance/{id:int}")]
    public IHttpActionResult DeleteInstance([FromUri] int id) {

      Exception ex = null;

      try {
        _dataConnector.DeleteInstance(id);
      } catch(Exception e) {
        ex = e;
      }

      return GetHttpActionResult(ex);

    }

    #endregion

  }
}
