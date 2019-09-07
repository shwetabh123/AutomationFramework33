using AutomationFramework33.AutomationFramework33.Interfaces;
using AutomationFramework33.AutomationFramework33.Settings;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework33.AutomationFramework33.Configuration
{
    public class AppConfigReader : IConfig
    {
        public BrowserType GetBrowser()
        {
          string browser= ConfigurationManager.AppSettings.Get(AppConfigKeys.Browser);

           return (BrowserType) Enum.Parse(typeof(BrowserType), browser);


        }
        public int GetElementLoadTimeOut()
        {
            string timeout = ConfigurationManager.AppSettings.Get(AppConfigKeys.ElementLoadTimeout);
            if (timeout == null)
                return 30;
            return Convert.ToInt32(timeout);
        }

        public int GetPageLoadTimeOut()
        {
            string timeout = ConfigurationManager.AppSettings.Get(AppConfigKeys.PageLoadTimeout);
            if (timeout == null)
                return 30;
            return Convert.ToInt32(timeout);
        }


        public string GetUrlone()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.Urlone);
        }



        public string GetUrltwo()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.Urltwo);
        }

        public string GetUrlthree()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.Urlthree);
        }

        public string GetUrlfour()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.Urlfour);
        }


        public string GetPassword()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.Password);
        }

        public string GetUsername()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.UserName);
        }



    


    }
}
