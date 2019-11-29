using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Grzadka.Infrastructure
{
    public class AppConfig
    {
        private static string _categoryIconsFolderRelative = ConfigurationManager.AppSettings["CategoryIconFolder"];
        public static string CategoryIconsFolderRelative
        {
            get
            {
                return _categoryIconsFolderRelative;
            }
        }

        private static string _photosFolderRelative = ConfigurationManager.AppSettings["PhotosFolder"];
        public static string PhotosFolderRelative
        {
            get
            {
                return _photosFolderRelative;
            }
        }
    }
}