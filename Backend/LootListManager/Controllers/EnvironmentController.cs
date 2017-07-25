﻿using LootListManager.BindingModels;
using LootListManager.Connectors;
using LootListManager.Util;
using LootListManager.ViewModels;
using System;
using System.Linq;
using System.Net.Http;
using System.Web.Http;

namespace LootListManager.Controllers {
  [RoutePrefix("Environments")]
  public class EnvironmentController : BaseController {

    #region - Instance Variables -

    private readonly EnvironmentDataConnector _dataConnector;

    #endregion

    #region - Constructor -

    public EnvironmentController() : base() {
      _dataConnector = new EnvironmentDataConnector();
    }

    #endregion

    #region - Instance -

    [HttpGet]
    [Route("Instances")]
    public IHttpActionResult GetInstances() {
      Exception ex = null;
      LinkContainer<InstanceViewModel> instances = null;

      try {
        var requestUri = Request.RequestUri;
        instances = new LinkContainer<InstanceViewModel>(_dataConnector.GetInstances().Select(x => new InstanceViewModel(x)).ToList());

        foreach (var instance in instances.Items) {
          instance.AddLink(new Link(requestUri, HttpMethod.Get, RelValues.Self, ActionValues.Load, "environments/instances/" + instance.InstanceId));
        }

        instances.AddLink(new Link(requestUri, HttpMethod.Post, RelValues.Child, ActionValues.Create, "environments/instances"));
      } catch (Exception e) {
        ex = e;
      }

      return GetHttpActionResult(instances, ex);
    }

    [HttpGet]
    [Route("Instances/{id:int}")]
    public IHttpActionResult GetInstance([FromUri] int id) {
      Exception ex = null;
      InstanceViewModel instance = null;

      try {
        var requestUri = Request.RequestUri;
        instance = new InstanceViewModel(_dataConnector.GetInstance(id));

        instance.AddLink(new Link(requestUri, HttpMethod.Get, RelValues.Self, ActionValues.Refresh, "environments/instances/" + instance.InstanceId));
        instance.AddLink(new Link(requestUri, HttpMethod.Put, RelValues.Self, ActionValues.Update, "environments/instances/" + instance.InstanceId));
        instance.AddLink(new Link(requestUri, HttpMethod.Delete, RelValues.Self, ActionValues.Delete, "environments/instances/" + instance.InstanceId));
      } catch (Exception e) {
        ex = e;
      }

      return GetHttpActionResult(instance, ex);
    }

    [HttpPost]
    [Route("Instances")]
    public IHttpActionResult CreateInstance([FromBody] InstanceBindingModel instance) {
      Exception ex = null;

      try {
        _dataConnector.SaveInstance(instance.GetEntity());
      } catch (Exception e) {
        ex = e;
      }

      return GetHttpActionResult(ex);
    }

    [HttpPut]
    [Route("Instances/{id:int}")]
    public IHttpActionResult UpdateInstance([FromUri] int id, [FromBody] InstanceBindingModel instance) {
      Exception ex = null;

      try {
        _dataConnector.SaveInstance(instance.GetEntity());
      } catch (Exception e) {
        ex = e;
      }

      return GetHttpActionResult(ex);
    }

    [HttpDelete]
    [Route("Instances/{id:int}")]
    public IHttpActionResult DeleteInstance([FromUri] int id) {
      Exception ex = null;

      try {
        _dataConnector.DeleteInstance(id);
      } catch (Exception e) {
        ex = e;
      }

      return GetHttpActionResult(ex);
    }

    #endregion

  }
}
