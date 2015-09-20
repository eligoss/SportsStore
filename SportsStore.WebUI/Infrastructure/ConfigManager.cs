using System.Configuration;
using SportsStore.Domain.Abstract;

namespace SportsStore.WebUI.Infrastructure
{
    public class ConfigManager : IConfigManager
    {
        #region IConfigManager Members

        public bool Email_WriteAsFile
        {
            get
            {
                bool result = false;

                bool.TryParse(ConfigurationManager.AppSettings["Email.WriteAsFile"], out result);

                return result;
            }
        }
        #endregion
    }
}