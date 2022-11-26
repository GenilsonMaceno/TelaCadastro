using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace GTI.CADASTRO.WEB.App_Config
{
    public static class ConfigSettings
    {
        public static string EndPointApi
        {
            get { return ConfigurationManager.AppSettings["Api"].ToString();  }
        }
    }
}