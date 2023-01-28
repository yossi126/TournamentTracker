using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.DataAcces;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static IDataConnection Connection { get; private set; }

        public static void InitializeConnections(DatabaseType db)
        {
            if(db == DatabaseType.Sql)
            { 
                //TODO - Create the sql connetion
                SqlConnector sql = new SqlConnector();
                Connection = sql;
            }
            else if(db == DatabaseType.TextFile)
            {
                //TODO - create the text files connection 
                TextConnector text = new TextConnector();
                Connection = text;
            }
        }
        
        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
 