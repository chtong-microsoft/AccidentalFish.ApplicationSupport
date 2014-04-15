﻿// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments
#pragma warning disable 1591
#region T4MVC

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4MVC;

[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
public static partial class MVC
{
    public static AccidentalFish.Operations.Website.Controllers.AccountController Account = new AccidentalFish.Operations.Website.Controllers.T4MVC_AccountController();
    public static AccidentalFish.Operations.Website.Controllers.AlertsController Alerts = new AccidentalFish.Operations.Website.Controllers.T4MVC_AlertsController();
    public static AccidentalFish.Operations.Website.Controllers.HomeController Home = new AccidentalFish.Operations.Website.Controllers.T4MVC_HomeController();
    public static AccidentalFish.Operations.Website.Controllers.LogController Log = new AccidentalFish.Operations.Website.Controllers.T4MVC_LogController();
    public static T4MVC.SharedController Shared = new T4MVC.SharedController();
}

namespace T4MVC
{
}

namespace T4MVC
{
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class Dummy
    {
        private Dummy() { }
        public static Dummy Instance = new Dummy();
    }
}

[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
internal partial class T4MVC_System_Web_Mvc_ActionResult : System.Web.Mvc.ActionResult, IT4MVCActionResult
{
    public T4MVC_System_Web_Mvc_ActionResult(string area, string controller, string action, string protocol = null): base()
    {
        this.InitMVCT4Result(area, controller, action, protocol);
    }
     
    public override void ExecuteResult(System.Web.Mvc.ControllerContext context) { }
    
    public string Controller { get; set; }
    public string Action { get; set; }
    public string Protocol { get; set; }
    public RouteValueDictionary RouteValueDictionary { get; set; }
}



namespace Links
{
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static class Scripts {
        private const string URLPATH = "~/Scripts";
        public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
        public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
        public static readonly string _references_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/_references.min.js") ? Url("_references.min.js") : Url("_references.js");
        public static readonly string bootstrap_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/bootstrap.min.js") ? Url("bootstrap.min.js") : Url("bootstrap.js");
        public static readonly string bootstrap_min_js = Url("bootstrap.min.js");
        public static readonly string handlebars_amd_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/handlebars.amd.min.js") ? Url("handlebars.amd.min.js") : Url("handlebars.amd.js");
        public static readonly string handlebars_amd_min_js = Url("handlebars.amd.min.js");
        public static readonly string handlebars_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/handlebars.min.js") ? Url("handlebars.min.js") : Url("handlebars.js");
        public static readonly string handlebars_min_js = Url("handlebars.min.js");
        public static readonly string handlebars_runtime_amd_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/handlebars.runtime.amd.min.js") ? Url("handlebars.runtime.amd.min.js") : Url("handlebars.runtime.amd.js");
        public static readonly string handlebars_runtime_amd_min_js = Url("handlebars.runtime.amd.min.js");
        public static readonly string handlebars_runtime_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/handlebars.runtime.min.js") ? Url("handlebars.runtime.min.js") : Url("handlebars.runtime.js");
        public static readonly string handlebars_runtime_min_js = Url("handlebars.runtime.min.js");
        public static readonly string handlebarsHelpers_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/handlebarsHelpers.min.js") ? Url("handlebarsHelpers.min.js") : Url("handlebarsHelpers.js");
        public static readonly string jquery_1_10_2_intellisense_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery-1.10.2.intellisense.min.js") ? Url("jquery-1.10.2.intellisense.min.js") : Url("jquery-1.10.2.intellisense.js");
        public static readonly string jquery_2_1_0_intellisense_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery-2.1.0.intellisense.min.js") ? Url("jquery-2.1.0.intellisense.min.js") : Url("jquery-2.1.0.intellisense.js");
        public static readonly string jquery_2_1_0_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery-2.1.0.min.js") ? Url("jquery-2.1.0.min.js") : Url("jquery-2.1.0.js");
        public static readonly string jquery_2_1_0_min_js = Url("jquery-2.1.0.min.js");
        public static readonly string jquery_2_1_0_min_map = Url("jquery-2.1.0.min.map");
        public static readonly string modernizr_2_6_2_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/modernizr-2.6.2.min.js") ? Url("modernizr-2.6.2.min.js") : Url("modernizr-2.6.2.js");
        public static readonly string modernizr_2_7_2_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/modernizr-2.7.2.min.js") ? Url("modernizr-2.7.2.min.js") : Url("modernizr-2.7.2.js");
        public static readonly string moment_with_langs_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/moment-with-langs.min.js") ? Url("moment-with-langs.min.js") : Url("moment-with-langs.js");
        public static readonly string moment_with_langs_min_js = Url("moment-with-langs.min.js");
        public static readonly string moment_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/moment.min.js") ? Url("moment.min.js") : Url("moment.js");
        public static readonly string moment_min_js = Url("moment.min.js");
        public static readonly string respond_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/respond.min.js") ? Url("respond.min.js") : Url("respond.js");
        public static readonly string respond_matchmedia_addListener_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/respond.matchmedia.addListener.min.js") ? Url("respond.matchmedia.addListener.min.js") : Url("respond.matchmedia.addListener.js");
        public static readonly string respond_matchmedia_addListener_min_js = Url("respond.matchmedia.addListener.min.js");
        public static readonly string respond_min_js = Url("respond.min.js");
        public static readonly string simplePagingGrid_0_6_0_0_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/simplePagingGrid-0.6.0.0.min.js") ? Url("simplePagingGrid-0.6.0.0.min.js") : Url("simplePagingGrid-0.6.0.0.js");
        public static readonly string simplePagingGrid_0_7_0_0_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/simplePagingGrid-0.7.0.0.min.js") ? Url("simplePagingGrid-0.7.0.0.min.js") : Url("simplePagingGrid-0.7.0.0.js");
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static class Content {
        private const string URLPATH = "~/Content";
        public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
        public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
        public static readonly string bootstrap_theme_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/bootstrap-theme.min.css") ? Url("bootstrap-theme.min.css") : Url("bootstrap-theme.css");
             
        public static readonly string bootstrap_theme_css_map = Url("bootstrap-theme.css.map");
        public static readonly string bootstrap_theme_min_css = Url("bootstrap-theme.min.css");
        public static readonly string bootstrap_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/bootstrap.min.css") ? Url("bootstrap.min.css") : Url("bootstrap.css");
             
        public static readonly string bootstrap_css_map = Url("bootstrap.css.map");
        public static readonly string bootstrap_min_css = Url("bootstrap.min.css");
        public static readonly string Site_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/Site.min.css") ? Url("Site.min.css") : Url("Site.css");
             
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static partial class Bundles
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static partial class Scripts {}
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static partial class Styles {}
    }
}

[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
internal static class T4MVCHelpers {
    // You can change the ProcessVirtualPath method to modify the path that gets returned to the client.
    // e.g. you can prepend a domain, or append a query string:
    //      return "http://localhost" + path + "?foo=bar";
    private static string ProcessVirtualPathDefault(string virtualPath) {
        // The path that comes in starts with ~/ and must first be made absolute
        string path = VirtualPathUtility.ToAbsolute(virtualPath);
        
        // Add your own modifications here before returning the path
        return path;
    }

    // Calling ProcessVirtualPath through delegate to allow it to be replaced for unit testing
    public static Func<string, string> ProcessVirtualPath = ProcessVirtualPathDefault;

    // Calling T4Extension.TimestampString through delegate to allow it to be replaced for unit testing and other purposes
    public static Func<string, string> TimestampString = System.Web.Mvc.T4Extensions.TimestampString;

    // Logic to determine if the app is running in production or dev environment
    public static bool IsProduction() { 
        return (HttpContext.Current != null && !HttpContext.Current.IsDebuggingEnabled); 
    }
}





#endregion T4MVC
#pragma warning restore 1591


