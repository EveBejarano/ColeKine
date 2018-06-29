using System.Web;
using System.Web.Optimization;

namespace ColeKineWebApplication
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            BundleTable.EnableOptimizations = true;
            ScriptBundle scriptBundle = new ScriptBundle("~/js");
            string[] scriptArray =
            {
                "~/Scripts/bootstrap-checkbox-radio.js",
                "~/Scripts/bootstrap-notify.js",
                "~/Scripts/bootstrap.min.js",
                "~/Scripts/chartist.min.js",
                "~/Scripts/demo.js",
                "~/Scripts/jquery-2.1.1.min.js",
                "~/Scripts/jquery.unobtrusive-ajax.min.js",
                "~/Scripts/paper-dashboard.js"
                //"~/Scripts/bootbox.min.js",
                //"~/Scripts/toastr.js",
                //"~/Scripts/DataTables/jquery.datatables.min.js",
                //"~/Scripts/DataTables/datatables.bootstrap.min.js",
                //"~/Scripts/pestañas.js",
                //"~/Scripts/select2.js",
                //"~/Scripts/jquery.steps.js",
                //"~/Scripts/layoutScripts.js",
                //"~/Scripts/Datepicker.js",
                //"~/Scripts/Scripts/jquery-ui-1.12.1.min.js",
                //"~/Scripts/Scripts/jquery-ui.multidatespicker.js",
                //"~/Scripts/DatatableBase.js"


            };
            scriptBundle.Include(scriptArray);
            scriptBundle.IncludeDirectory("~/Scripts/", "*.js");
            bundles.Add(scriptBundle);

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/Styles/css").Include(
            "~/Content/css/animate.min.css",
            "~/Content/css/bootstrap.min.css",
            "~/Content/css/demo.css",
            "~/Content/css/paper-dashboard.css",
            //"~/Content/Site.css",
           "~/Content/css/themify-icons.css"


            //"~/content/toastr.css",
            //"~/Content/Layout/css/material-dashboard.css",
            //"~/Content/Layout/css/demo.css",
         
            //"~/Content/css/select2.css",
            //"~/Content/DataTables/css/dataTables.bootstrap.min.css",
            //"~/Content/jquery.steps.css",
            //"~/Content/jquery-ui.multidatespicker.css"

            ));
        }
    }
}
