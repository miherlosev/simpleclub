using System.Web;
using System.Web.Optimization;

namespace SimpleClub.Web {
    public class BundleConfig {
        public static void RegisterBundles(BundleCollection bundles) {
            bundles.Add(new StyleBundle("~/bundles/shared-styles").Include(
                "~/Content/shared-styles.css"));
            
            BundleTable.EnableOptimizations = true;
        }
    }
}
