using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Grzadka.Infrastructure
{
    public static class UrlHelpers
    {
        public static string CategoryIconPath(this UrlHelper helper, string categoryIconFilename)
        {
            var categoryIconFolder = AppConfig.CategoryIconsFolderRelative;
            var path = Path.Combine(categoryIconFolder, categoryIconFilename);
            var absolutePath = helper.Content(path);
            return absolutePath;
        }

        public static string PlantCoverPath(this UrlHelper helper, string plantFilename)
        {
            var planntCoverFolder = AppConfig.PhotosFolderRelative;
            var path = Path.Combine(planntCoverFolder, plantFilename);
            var absolutePath = helper.Content(path);
            return absolutePath;
        }

    }
}