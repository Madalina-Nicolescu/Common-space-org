﻿using System.Web;
using System.Web.Optimization;

namespace Common_Space_Org
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/template/js").Include(
                      "~/Scripts/jquery.min.js",
                      "~/Scripts/bootstrap.bundle.min.js",
                      "~/Scripts/jquery-3.0.0.min.js",
                      "~/Scripts/plugin.js"));
            bundles.Add(new StyleBundle("~/template/css").Include(
                     "~/Content/css/bootstrap.min.css",
                     "~/Content/css/jquery.mCustomScrollbar.min.css",
                     "~/Content/css/style.css",
                     "~/Content/css/responsive.css",
                     "~/Content/css/style.css",
                     "~/Content/site.css",
                     "~/Content/groupProfile.css"));
        }
    }
}
