using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace BlogApp
{
    public class BundleConfig
    {
        public static void RegisterRoutes(BundleCollection bundles)
        {

            var appScripts = new ScriptBundle("~/bundles/appscripts");

            appScripts.Include("~/Scripts/modernizr-{version}.js");
            appScripts.Include("~/Scripts/jquery-{version}.js");
            appScripts.Include("~/Scripts/jquery.validate.js");
            appScripts.Include("~/Scripts/jquery.validate.unobtrusive.js");
            appScripts.Include("~/Scripts/jquery.unobtrusive-ajax.js");

            bundles.Add(appScripts);

        }
    }
}