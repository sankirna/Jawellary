using System.Web.Optimization;

namespace Jewellery.Web
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            #region "Scrips"

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/jquery-migrate-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Scripts/jquery-ui-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.unobtrusive*",
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/knockout").Include(
                        "~/Scripts/knockout-{version}.js",
                        "~/Scripts/knockout.mapping*"));

            bundles.Add(new ScriptBundle("~/bundles/layout").Include(
                        "~/Scripts/bootstrap*",
                        "~/Content/Plugins/breakpoints/breakpoints.js",
                        "~/Scripts/Shared/Common*",
                        "~/Scripts/Shared/Url*",
                        "~/Scripts/Shared/DateFormat*",
                        "~/Scripts/jquery.loadTemplate-*"
                        ));

            #region "Kendo UI Bundle(s)"

            bundles.Add(new ScriptBundle("~/bundle/kendo-knockout").Include(
         "~/Scripts/knockout-kendo*"));

            bundles.Add(new ScriptBundle("~/bundle/kendotabstrip").Include(
                "~/Scripts/kendoui/kendo.web*",
                "~/Scripts/kendoui/kendo.tabstrip*"));

            bundles.Add(new ScriptBundle("~/bundle/grid").Include(
                "~/Scripts/kendoui/kendo.web*",
                "~/Scripts/kendoui/kendo.grid*"));

            bundles.Add(new ScriptBundle("~/bundle/kendodropdownlist").Include(
                "~/Scripts/kendoui/kendo.web*",
                "~/Scripts/kendoui/kendo.dropdownlist*"));

            #endregion "Kendo UI Bundle(s)"


            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            #endregion "Scrips"

            #region "Style"

            bundles.Add(new StyleBundle("~/Content/layout").Include(
                "~/Content/bootstrap*",
                "~/Content/Plugins/font-awesome/css/font-awesome*",
                "~/Content/Site*",
                "~/Content/Search.css",
                "~/Content/Plugins/kendoui/styles/kendo.common*",
                 "~/Content/Plugins/kendoui/styles/kendo.flat*"));

            bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
                        "~/Content/themes/base/jquery.ui.core.css",
                        "~/Content/themes/base/jquery.ui.resizable.css",
                        "~/Content/themes/base/jquery.ui.selectable.css",
                        "~/Content/themes/base/jquery.ui.accordion.css",
                        "~/Content/themes/base/jquery.ui.autocomplete.css",
                        "~/Content/themes/base/jquery.ui.button.css",
                        "~/Content/themes/base/jquery.ui.dialog.css",
                        "~/Content/themes/base/jquery.ui.slider.css",
                        "~/Content/themes/base/jquery.ui.tabs.css",
                        "~/Content/themes/base/jquery.ui.datepicker.css",
                        "~/Content/themes/base/jquery.ui.progressbar.css",
                        "~/Content/themes/base/jquery.ui.theme.css"));

            #endregion "Style"

        }
    }
}