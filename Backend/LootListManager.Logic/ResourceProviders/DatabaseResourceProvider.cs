using System;
using System.Collections.Generic;
using System.Data;
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
    private static IList<string> _supportedCultures;
    private static string[] _resourceTables;

    #endregion

    #region - Constructor -

    public DatabaseResourceProvider(string[] resourceTables, string connectionString) {
      _cache = true;
      _lockResources = new object();
      _supportedCultures = new List<string>();
      _resourceTables = resourceTables;
      _connectionString = connectionString;
    }

    #endregion

    #region - Public Methods -

    public string GetResource(string tableName, string logicalId, CultureInfo cultureInfo) {
      if(string.IsNullOrWhiteSpace(logicalId)) {
        throw new ArgumentException("Resource logicalId cannot be null or empty");
      }

      if(cultureInfo == null) {
        throw new ArgumentException("Resource cultureInfo cannot be null");
      }

      if(_cache && _resources == null) {
        lock(_lockResources) {
          if(_resources == null) {
            _resources = ReadResources().ToDictionary(r => string.Format("{0}.{1}.{2}", r.TableName, r.Culture.ToLowerInvariant(), r.LogicalId));
          }
        }
      }

      return ReadResource(tableName, logicalId, cultureInfo).Value;
    }

    public void AddResource(string tableName, string logicalId, string value, CultureInfo cultureInfo) {
      if(ReadResource(tableName, logicalId, cultureInfo) == null) {
        SetResource(tableName, logicalId, value, cultureInfo);
      }
    }

    public void AddResource(ResourceEntry resourceEntry) {
      if(ReadResource(resourceEntry.TableName, resourceEntry.LogicalId, new CultureInfo(resourceEntry.Culture)) == null) {
        SetResource(resourceEntry.TableName, resourceEntry.LogicalId, resourceEntry.Value, new CultureInfo(resourceEntry.Culture));
      }
    }

    #endregion

    #region - Protected Methods -

    private IList<ResourceEntry> ReadResources() {
      var resources = new List<ResourceEntry>();

      using(var con = new SqlConnection(_connectionString)) {
        foreach(var table in _resourceTables) {
          var sql = "select Culture, LogicalId, Value from dbo." + table + ";";

          var cmd = new SqlCommand(sql, con);

          con.Open();

          using(var reader = cmd.ExecuteReader()) {
            while(reader.Read()) {
              var culture = reader["Culture"].ToString();

              resources.Add(new ResourceEntry {
                LogicalId = reader["LogicalId"].ToString(),
                Value = reader["Value"].ToString(),
                Culture = culture,
                TableName = table
              });
              if(!_supportedCultures.Contains(culture)) {
                _supportedCultures.Add(culture);
              }
            }
          }

          con.Close();

        }
      }

      return resources;
    }
    private ResourceEntry ReadResource(string tableName, string logicalId, CultureInfo cultureInfo) {
      ResourceEntry resource = null;

      var culture = (_supportedCultures.Contains(cultureInfo.Name)) ? cultureInfo.Name : (_supportedCultures.Contains(cultureInfo.Parent.Name)) ? cultureInfo.Parent.Name : "en";

      if(_cache && _resources != null) {
        resource = _resources[string.Format("{0}.{1}.{2}", tableName, culture, logicalId)];
      } else {

        var sql = "select Culture, LogicalId, Value from dbo." + tableName + " where culture = @culture and logicalId = @logicalId;";

        using(var con = new SqlConnection(_connectionString)) {
          var cmd = new SqlCommand(sql, con);

          cmd.Parameters.AddWithValue("@culture", culture);
          cmd.Parameters.AddWithValue("@logicalId", logicalId);

          con.Open();

          using(var reader = cmd.ExecuteReader()) {
            if(reader.Read()) {
              resource = new ResourceEntry {
                LogicalId = reader["LogicalId"].ToString(),
                Value = reader["Value"].ToString(),
                Culture = reader["Culture"].ToString(),
                TableName = tableName,
              };
            }
          }
        }
      }

      return resource;
    }

    private void SetResource(string tableName, string logicalId, string value, CultureInfo cultureInfo) {
      using(var con = new SqlConnection(_connectionString)) {
        var sql = "insert into dbo." + tableName + " ( [LogicalId], [Culture], [Value] ) VALUES (@logicalId, @culture, @value)";

        con.Open();

        var cmd = new SqlCommand(sql, con);
        cmd.Parameters.Add("@logicalId", SqlDbType.NVarChar, 10).Value = logicalId;
        cmd.Parameters.Add("@culture", SqlDbType.NVarChar, 10).Value = cultureInfo.Name;
        cmd.Parameters.Add("@value", SqlDbType.NVarChar, 100).Value = value;
        cmd.ExecuteNonQuery();
      }
    }

    #endregion

  }
}