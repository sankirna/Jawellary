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

            //bundles.Add(new ScriptBundle("~/bundles/layout").Include(
            //            "~/Scripts/bootstrap*",
            //            "~/Content/Plugins/breakpoints/breakpoints.js",
            //            "~/Scripts/Shared/Common*",
            //            "~/Scripts/Shared/Url*",
            //            "~/Scripts/Shared/DateFormat*",
            //            "~/Scripts/jquery.loadTemplate-*"
            //            ));

            bundles.Add(new ScriptBundle("~/Content/assets/js").Include(
             "~/Content/assets/plugins/jquery-1.8.3.min.js",
             "~/Content/assets/plugins/jquery-ui/jquery-ui-1.10.1.custom.min.js",
             "~/Content/assets/plugins/bootstrap/js/bootstrap.min.js",
             "~/Content/assets/plugins/breakpoints/breakpoints.js",
             "~/Content/assets/plugins/jquery-slimscroll/jquery.slimscroll.min.js",
             "~/Content/assets/plugins/jquery.blockui.js",
             "~/Content/assets/plugins/jquery.cookie.js",
             "~/Content/assets/plugins/uniform/jquery.uniform.min.js",
             "~/Content/assets/scripts/app.js",
             "~/Content/Uploadify/swfobject.js",
              "~/Content/Uploadify/jquery.uploadify.v2.1.4.min.js"
             ));

            #region "Kendo UI Bundle(s)"

            //bundles.Add(new ScriptBundle("~/bundle/kendo-knockout").Include(
            //                             "~/Scripts/knockout-kendo*"));

            //bundles.Add(new ScriptBundle("~/bundle/kendotabstrip").Include(
            //    "~/Scripts/kendoui/kendo.web*",
            //    "~/Scripts/kendoui/kendo.tabstrip*"));

            //bundles.Add(new ScriptBundle("~/bundle/grid").Include(
            //    "~/Scripts/kendoui/kendo.web*",
            //    "~/Scripts/kendoui/kendo.grid*"));

            //bundles.Add(new ScriptBundle("~/bundle/kendodropdownlist").Include(
            //    "~/Scripts/kendoui/kendo.web*",
            //    "~/Scripts/kendoui/kendo.dropdownlist*"));

            #endregion "Kendo UI Bundle(s)"


            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            #endregion "Scrips"

            #region "Style"

            //bundles.Add(new StyleBundle("~/Content/layout").Include(
            //    "~/Content/bootstrap*",
            //    "~/Content/Plugins/font-awesome/css/font-awesome*",
            //    "~/Content/Site*",
            //    "~/Content/Search.css",
            //    "~/Content/Plugins/kendoui/styles/kendo.common*",
            //    "~/Content/Plugins/kendoui/styles/kendo.flat*"));
            
            bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
                        "~/Areas/Admin/Content/themes/base/jquery.ui.core.css",
                        "~/Areas/Admin/Content/themes/base/jquery.ui.resizable.css",
                        "~/Areas/Admin/Content/themes/base/jquery.ui.selectable.css",
                        "~/Areas/Admin/Content/themes/base/jquery.ui.accordion.css",
                        "~/Areas/Admin/Content/themes/base/jquery.ui.autocomplete.css",
                        "~/Areas/Admin/Content/themes/base/jquery.ui.button.css",
                        "~/Areas/Admin/Content/themes/base/jquery.ui.dialog.css",
                        "~/Areas/Admin/Content/themes/base/jquery.ui.slider.css",
                        "~/Areas/Admin/Content/themes/base/jquery.ui.tabs.css",
                        "~/Areas/Admin/Content/themes/base/jquery.ui.datepicker.css",
                        "~/Areas/Admin/Content/themes/base/jquery.ui.progressbar.css",
                        "~/Areas/Admin/Content/themes/base/jquery.ui.theme.css"));

            //######################## Start LOGIN ASSETS #######################
            bundles.Add(new StyleBundle("~/Content/assets/css/Login").Include(
             "~/Areas/Admin/Content/assets/css/pages/login.css"
                ));

            bundles.Add(new ScriptBundle("~/Content/assets/js/Login").Include(
             "~/Areas/Admin/Content/assets/plugins/jquery-validation/dist/jquery.validate.min.js",
             "~/Areas/Admin/Content/assets/scripts/app.js",
             "~/Areas/Admin/Content/assets/scripts/login.js"
             ));

            //######################## END LOGIN ASSETS #########################



            bundles.Add(new StyleBundle("~/Content/assets/css").Include(
                   "~/Areas/Admin/Content/assets/plugins/jquery-ui/jquery-ui-1.10.1.custom.min.css",
                   "~/Areas/Admin/Content/assets/plugins/bootstrap/css/bootstrap.min.css",
                   "~/Areas/Admin/Content/assets/plugins/bootstrap/css/bootstrap-responsive.min.css",
                   "~/Areas/Admin/Content/assets/plugins/font-awesome/css/font-awesome.min.css",
                   "~/Areas/Admin/Content/assets/css/style-metro.css",
                   "~/Areas/Admin/Content/assets/css/style.css",
                   "~/Areas/Admin/Content/assets/css/style-responsive.css",
                   "~/Areas/Admin/Content/assets/css/themes/default.css",
                   "~/Areas/Admin/Content/assets/plugins/uniform/css/uniform.default.css"
                 
                   ));

            #endregion "Style"

        }
    }
}