using System.Web;
using System.Web.Optimization;

namespace Mic.Almost.WebUI
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.Add(new StyleBundle("~/bundles/styles").Include(
                    "~/Content/Bundles/assets/vendor-styles*",
                    "~/Content/Bundles/assets/main-styles*"
                ));

            bundles.Add(new ScriptBundle("~/bundles/scripts").Include(
                    "~/Content/Bundles/assets/vendor-scripts*",
                    "~/Content/Bundles/assets/main-scripts*"
                ));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/bower_components/modernizr/modernizr.js"));

            BundleTable.EnableOptimizations = false;
            


        }
    }
}
