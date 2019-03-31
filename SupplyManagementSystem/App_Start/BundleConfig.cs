﻿using System.Web.Optimization;

namespace SCM
{
    public class BundleConfig
    {
        // Дополнительные сведения об объединении см. на странице https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/Content/vendor/jquery/jquery.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                "~/Scripts/jquery.validate*"));

            // Используйте версию Modernizr для разработчиков, чтобы учиться работать. Когда вы будете готовы перейти к работе,
            // готово к выпуску, используйте средство сборки по адресу https://modernizr.com, чтобы выбрать только необходимые тесты.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                "~/Content/vendor/bootstrap/js/bootstrap.bundle.min.js"));
            
            bundles.Add(new ScriptBundle("~/bundles/kendo").Include(
                "~/Scripts/kendo/kendo.all.min.js",
                // uncomment below if using the Scheduler
                // "~/Scripts/kendo/kendo.timezones.min.js",
                "~/Scripts/kendo/kendo.aspnetmvc.min.js"));

            
            bundles.Add(new StyleBundle("~/Content/kendo/css").Include(
                /*"~/Content/kendo/kendo.common-bootstrap.min.css",*/
                "~/Content/kendo/kendo.bootstrap-v4.min.css"));
            

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/Vendor/bootstrap/css/bootstrap.min.css",
                "~/Content/site.css",
                "~/Content/simple-sidebar.css",
                "~/Content/bootstrap-vertical-tabs.css"));
        }
    }
}