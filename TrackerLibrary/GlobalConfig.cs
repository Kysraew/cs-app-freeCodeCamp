using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.DataAccess;
using System.Configuration;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static IDataConnection Connection { get; private set; }
        public static void InitializeConnections(DatabaseType connectionType)
        {
            switch (connectionType)
            {
                case DatabaseType.Sql:
                    //TODO Set up the SQL Connector properly
                    SqlConnector sqlConnector = new SqlConnector();
                    Connection = sqlConnector;
                    break;

                case DatabaseType.TextFile:
                    //TODO Set up the text connector propery
                    TextConnector textConnector = new TextConnector();
                    Connection = textConnector;
                    break;

                default:
                    break;
            }
        }

        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }

}
