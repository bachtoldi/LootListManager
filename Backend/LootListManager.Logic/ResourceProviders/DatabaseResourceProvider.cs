using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;

namespace LootListManager.Logic.ResourceProviders {
  public class DatabaseResourceProvider {

    #region - Instance Variables -

    private static Dictionary<string, ResourceEntry> _resources;
    private static object _lockResources;
    private bool _cache;
    private static string _connectionString;
    private static string[] _supportedCultures;

    #endregion

    #region - Constructor -

    public DatabaseResourceProvider(string[] supportetCultures, string connectionString) {
      _cache = true;
      _lockResources = new object();
      _supportedCultures = supportetCultures;
      _connectionString = connectionString;
    }

    #endregion

    #region - Public Methods -

    public object GetResource(string logicalId, CultureInfo cultureInfo) {
      if (string.IsNullOrWhiteSpace(logicalId)) {
        throw new ArgumentException("Resource logicalId cannot be null or empty");
      }

      if (cultureInfo == null) {
        throw new ArgumentException("Resource cultureInfo cannot be null");
      }

      if (_cache && _resources == null) {
        lock (_lockResources) {
          if (_resources == null) {
            _resources = ReadResources().ToDictionary(r => string.Format("{0}.{1}", r.Culture.ToLowerInvariant(), r.LogicalId));
          }
        }
      }

      return ReadResource(logicalId, cultureInfo).Value;
    }

    #endregion

    #region - Protected Methods -

    protected IList<ResourceEntry> ReadResources() {
      return null;
      var resources = new List<ResourceEntry>();

      const string sql = "select Culture, LogicalId, Value from dbo.InstanceNames;";

      using (var con = new SqlConnection(_connectionString)) {
        var cmd = new SqlCommand(sql, con);

        con.Open();

        using (var reader = cmd.ExecuteReader()) {
          while (reader.Read()) {
            resources.Add(new ResourceEntry {
              LogicalId = reader["LogicalId"].ToString(),
              Value = reader["Value"].ToString(),
              Culture = reader["Culture"].ToString()
            });
          }

          if (!reader.HasRows)
            throw new Exception("No resources were found");
        }
      }

      return resources;
    }
    private ResourceEntry ReadResource(string logicalId, CultureInfo cultureInfo) {
      ResourceEntry resource = null;
      var culture = (_supportedCultures.Contains(cultureInfo.Name)) ? cultureInfo.Name : (_supportedCultures.Contains(cultureInfo.Parent.Name)) ? cultureInfo.Parent.Name : "en";

      if (_cache && _resources != null) {
        resource = _resources[string.Format("{0}.{1}", culture, logicalId)];
      } else {

        const string sql = "select Culture, LogicalId, Value from dbo.InstanceNames where culture = @culture and logicalId = @logicalId;";

        using (var con = new SqlConnection(_connectionString)) {
          var cmd = new SqlCommand(sql, con);

          cmd.Parameters.AddWithValue("@culture", culture);
          cmd.Parameters.AddWithValue("@logicalId", logicalId);

          con.Open();

          using (var reader = cmd.ExecuteReader()) {
            if (reader.Read()) {
              resource = new ResourceEntry {
                LogicalId = reader["LogicalId"].ToString(),
                Value = reader["Value"].ToString(),
                Culture = reader["Culture"].ToString()
              };
            }

            if (!reader.HasRows)
              throw new Exception(string.Format("Resource {0} for culture {1} was not found", logicalId, culture));
          }
        }
      }

      return resource;
    }

    #endregion

  }
}