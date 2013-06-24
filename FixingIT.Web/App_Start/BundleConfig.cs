using System.Web;
using System.Web.Optimization;

namespace FixingIT.Web
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            //bundles.ResetAll();

            // SCRIPTS

            bundles.Add(new ScriptBundle("~/bundles/scripts/jquery").Include(
                        "~/Scripts/jquery-{version}.min.js")
            );

            bundles.Add(new ScriptBundle("~/bundles/scripts/jquery-ui").Include(
                        "~/Scripts/jquery-ui-{version}.min.js")
            );

            bundles.Add(new ScriptBundle("~/bundles/scripts/jquery-val").Include(
                        "~/Scripts/jquery.unobtrusive*",
                        "~/Scripts/jquery.validate*")
            );

            //bundles.Add(new ScriptBundle("~/bundles/scripts/bootstrap").Include(
            //            "~/Scripts/bootstrap.min.js"
            //            ));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/scripts/modernizr").Include(
                        "~/Scripts/modernizr-*"
            ));

            bundles.Add(new ScriptBundle("~/bundles/scripts/knockout").Include(
                        "~/Scripts/knockout-{version}.js"
            ));

            bundles.Add(new ScriptBundle("~/bundles/scripts/own-scripts").Include(
                        "~/Scripts/OwnScripts/*.js"
            ));

            // STYLES

            //bundles.Add(new StyleBundle("~/bundles/styles/bootstrap-responsive").Include(
            //            "~/Content/bootstrap.min.css",
            //            "~/Content/bootstrap-responsive.min.css"
            //            ));

            bundles.Add(new StyleBundle("~/bundles/styles/jquery-ui").Include(
                        "~/Content/themes/base/minified/jquery.ui.min.css",
                        "~/Content/themes/base/minified/jquery.ui.accordion.min.css",
                        "~/Content/themes/base/minified/jquery.ui.all.min.css",
                        "~/Content/themes/base/minified/jquery.ui.autocomplete.min.css",
                        "~/Content/themes/base/minified/jquery.ui.base.min.css",
                        "~/Content/themes/base/minified/jquery.ui.button.min.css",
                        "~/Content/themes/base/minified/jquery.ui.core.min.css",
                        "~/Content/themes/base/minified/jquery.ui.datepicker.min.css",
                        "~/Content/themes/base/minified/jquery.ui.dialog.min.css",
                        "~/Content/themes/base/minified/jquery.ui.progressbar.min.css",
                        "~/Content/themes/base/minified/jquery.ui.resizable.min.css",
                        "~/Content/themes/base/minified/jquery.ui.selectable.min.css",
                        "~/Content/themes/base/minified/jquery.ui.slider.min.css",
                        "~/Content/themes/base/minified/jquery.ui.spinner.min.css",
                        "~/Content/themes/base/minified/jquery.ui.tabs.min.css",
                        "~/Content/themes/base/minified/jquery.ui.theme.min.css",
                        "~/Content/themes/base/minified/jquery.ui.tooltip.min.css"
            ));

            bundles.Add(new StyleBundle("~/bundles/styles/own-style").Include(
                        "~/Content/Site.css"
            ));
        }
    }
}