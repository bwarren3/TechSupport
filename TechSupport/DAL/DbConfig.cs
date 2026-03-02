using System.Configuration;

namespace TechSupport.DAL
{
    public class DbConfig
    {
        public string ConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["TechSupport"].ConnectionString;
            }
        }
    }
}