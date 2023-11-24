using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class ConfigurationManager
    {
        private static ConfigurationManager _instance;
        private string loggingMode;
        private string databaseConnectionString;

        private ConfigurationManager() { }

        public static ConfigurationManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ConfigurationManager();
                }
                return _instance;
            }
        }

        public string LoggingMode
        {
            get { return loggingMode; }
            set
            {
                loggingMode = value;
                Console.WriteLine("Logging mode set to: " + loggingMode);
            }
        }

        public string DatabaseConnectionString
        {
            get { return databaseConnectionString; }
            set
            {
                databaseConnectionString = value;
                Console.WriteLine("Database connection string set to: " + databaseConnectionString);
            }
        }
    }

}

