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
            appScripts.Include("~/Scripts/main-script.js");


            var appStyles = new StyleBundle("~/Content/themes/basic/css");

            appStyles.Include("~/Content/themes/basic/font-awesome.css");
            appStyles.Include("~/Content/themes/basic/basic-style.css");
            appStyles.Include("~/Content/themes/basic/basic-style-colors.css");


            bundles.Add(appScripts);
            bundles.Add(appStyles);

        }
    }
}