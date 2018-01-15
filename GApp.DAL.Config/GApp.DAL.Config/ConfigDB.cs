using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GApp.DAL.Configuration
{
    /// <summary>
    /// DataBase connexion configuration
    /// </summary>
    public class ConfigDb
    {
        public string ServerName { set; get; }
        public string Login { set; get; }
        public string Password { set; get; }
        public string DataBaseName { set; get; }
    }
}
