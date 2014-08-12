﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BetterCms.Module.Root.Views.Shared
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 1 "..\..\Views\Shared\BaseLayout.cshtml"
    using BetterCms.Module.Root.Mvc;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Shared\BaseLayout.cshtml"
    using BetterCms.Module.Root.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Views\Shared\BaseLayout.cshtml"
    using BetterCms.Module.Root.ViewModels.Cms;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/BaseLayout.cshtml")]
    public partial class BaseLayout : System.Web.Mvc.WebViewPage<RenderPageViewModel>
    {
        public BaseLayout()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 6 "..\..\Views\Shared\BaseLayout.cshtml"
  
    Layout = "RootLayout.cshtml";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 10 "..\..\Views\Shared\BaseLayout.cshtml"
 if (Model.CanManageContent)
{
    
            
            #line default
            #line hidden
            
            #line 12 "..\..\Views\Shared\BaseLayout.cshtml"
Write(Html.Partial("~/Areas/bcms-root/Views/Shared/Partial/SupportBrowser.cshtml"));

            
            #line default
            #line hidden
            
            #line 12 "..\..\Views\Shared\BaseLayout.cshtml"
                                                                                 
    
            
            #line default
            #line hidden
            
            #line 13 "..\..\Views\Shared\BaseLayout.cshtml"
Write(Html.Partial("~/Areas/bcms-root/Views/Shared/Partial/SupportJavascript.cshtml"));

            
            #line default
            #line hidden
            
            #line 13 "..\..\Views\Shared\BaseLayout.cshtml"
                                                                                    
}

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 16 "..\..\Views\Shared\BaseLayout.cshtml"
Write(RenderBody());

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 18 "..\..\Views\Shared\BaseLayout.cshtml"
 if (Model.CanManageContent)
{
    
            
            #line default
            #line hidden
            
            #line 20 "..\..\Views\Shared\BaseLayout.cshtml"
Write(Html.Partial("~/Areas/bcms-root/Views/Shared/Partial/MasterPagesPath.cshtml"));

            
            #line default
            #line hidden
            
            #line 20 "..\..\Views\Shared\BaseLayout.cshtml"
                                                                                  
}

            
            #line default
            #line hidden
WriteLiteral("\r\n");

DefineSection("CmsMetaTitle", () => {

WriteLiteral("\r\n    <title>");

            
            #line 24 "..\..\Views\Shared\BaseLayout.cshtml"
      Write(Model.MetaTitle);

            
            #line default
            #line hidden
WriteLiteral("</title>\r\n");

});

WriteLiteral("\r\n");

DefineSection("CmsMeta", () => {

WriteLiteral("    \r\n");

            
            #line 28 "..\..\Views\Shared\BaseLayout.cshtml"
    
            
            #line default
            #line hidden
            
            #line 28 "..\..\Views\Shared\BaseLayout.cshtml"
     if (Model.Metadata != null)
    {
        foreach (var metaData in Model.Metadata)
        {
            metaData.Render(Model, (ViewContext.Controller as CmsControllerBase).SecurityService, Html);
        }
    }

            
            #line default
            #line hidden
});

DefineSection("CmsHeadStyles", () => {

WriteLiteral("   \r\n    <style");

WriteLiteral(" type=\"text/css\"");

WriteLiteral(">\r\n        .bcms-clearfix:after {\r\n            content: \"\";\r\n            visibili" +
"ty: hidden;\r\n            display: block;\r\n            height: 0;\r\n            cl" +
"ear: both;\r\n        }\r\n    </style>\r\n");

            
            #line 46 "..\..\Views\Shared\BaseLayout.cshtml"
    
            
            #line default
            #line hidden
            
            #line 46 "..\..\Views\Shared\BaseLayout.cshtml"
     if (Model.CanManageContent)
    {

            
            #line default
            #line hidden
WriteLiteral("        <link");

WriteLiteral(" href=\'//fonts.googleapis.com/css?family=Open+Sans:400italic,700italic,400,700\'");

WriteLiteral(" rel=\'stylesheet\'");

WriteLiteral(" type=\'text/css\'");

WriteLiteral(" async />\r\n");

            
            #line 49 "..\..\Views\Shared\BaseLayout.cshtml"
        
            
            #line default
            #line hidden
            
            #line 49 "..\..\Views\Shared\BaseLayout.cshtml"
   Write(Html.Action("RenderStyleSheetIncludes", "Rendering"));

            
            #line default
            #line hidden
            
            #line 49 "..\..\Views\Shared\BaseLayout.cshtml"
                                                             
    }

            
            #line default
            #line hidden
});

WriteLiteral("\r\n");

DefineSection("CmsHeadScripts", () => {

WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 54 "..\..\Views\Shared\BaseLayout.cshtml"
Write(RenderSection("CmsHeadScripts", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 56 "..\..\Views\Shared\BaseLayout.cshtml"
    
            
            #line default
            #line hidden
            
            #line 56 "..\..\Views\Shared\BaseLayout.cshtml"
     if (Model.CanManageContent)
    {

            
            #line default
            #line hidden
WriteLiteral("        <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(@">
            function loadBetterCmsScriptAsync(url, callback) {
                var head = document.getElementsByTagName(""head"")[0];
                var scriptTag = document.createElement(""script"");
                scriptTag.type = 'text/javascript';
                scriptTag.src = url;
                scriptTag.async = true;

                // Attach handlers for all browsers
                var done = false;
                scriptTag.onload = scriptTag.onreadystatechange = function() {
                    if (!done && (!this.readyState || this.readyState == ""loaded"" || this.readyState == ""complete"")) {
                        done = true;
                        try {
                            if (callback) {
                                callback();
                            }
                        } finally {
                            scriptTag.onload = scriptTag.onreadystatechange = null;
                            head.removeChild(scriptTag);
                        }
                    }
                };

                head.appendChild(scriptTag);
            }

            (function() {
                loadBetterCmsScriptAsync('");

            
            #line 86 "..\..\Views\Shared\BaseLayout.cshtml"
                                     Write(Model.RequireJsPath);

            
            #line default
            #line hidden
WriteLiteral("\', function() {\r\n                    loadBetterCmsScriptAsync(\'");

            
            #line 87 "..\..\Views\Shared\BaseLayout.cshtml"
                                         Write(Model.MainJsPath);

            
            #line default
            #line hidden
WriteLiteral("\');\r\n                });\r\n            })();\r\n        </script>\r\n");

WriteLiteral("        <!--[if lt IE 9]>\r\n            <script src=\"");

            
            #line 92 "..\..\Views\Shared\BaseLayout.cshtml"
                    Write(Model.Html5ShivJsPath);

            
            #line default
            #line hidden
WriteLiteral("\"></script>\r\n        <![endif]-->\r\n");

            
            #line 94 "..\..\Views\Shared\BaseLayout.cshtml"
    }

            
            #line default
            #line hidden
});

WriteLiteral("\r\n");

DefineSection("CmsScripts", () => {

WriteLiteral("\r\n");

            
            #line 98 "..\..\Views\Shared\BaseLayout.cshtml"
    
            
            #line default
            #line hidden
            
            #line 98 "..\..\Views\Shared\BaseLayout.cshtml"
     if (Model.CanManageContent)
    {
        
            
            #line default
            #line hidden
            
            #line 100 "..\..\Views\Shared\BaseLayout.cshtml"
   Write(Html.Partial("Partial/Region"));

            
            #line default
            #line hidden
            
            #line 100 "..\..\Views\Shared\BaseLayout.cshtml"
                                       
        
            
            #line default
            #line hidden
            
            #line 101 "..\..\Views\Shared\BaseLayout.cshtml"
   Write(Html.Partial("Partial/ContentOverlay"));

            
            #line default
            #line hidden
            
            #line 101 "..\..\Views\Shared\BaseLayout.cshtml"
                                               
        
            
            #line default
            #line hidden
            
            #line 102 "..\..\Views\Shared\BaseLayout.cshtml"
   Write(Html.Action("Container", "Sidebar"));

            
            #line default
            #line hidden
            
            #line 102 "..\..\Views\Shared\BaseLayout.cshtml"
                                            
        
            
            #line default
            #line hidden
            
            #line 103 "..\..\Views\Shared\BaseLayout.cshtml"
   Write(Html.Partial("Partial/Modal"));

            
            #line default
            #line hidden
            
            #line 103 "..\..\Views\Shared\BaseLayout.cshtml"
                                      
        
            
            #line default
            #line hidden
            
            #line 104 "..\..\Views\Shared\BaseLayout.cshtml"
   Write(Html.Partial("Partial/Alert"));

            
            #line default
            #line hidden
            
            #line 104 "..\..\Views\Shared\BaseLayout.cshtml"
                                      
        
            
            #line default
            #line hidden
            
            #line 105 "..\..\Views\Shared\BaseLayout.cshtml"
   Write(Html.Partial("Partial/Confirm"));

            
            #line default
            #line hidden
            
            #line 105 "..\..\Views\Shared\BaseLayout.cshtml"
                                        
        
            
            #line default
            #line hidden
            
            #line 106 "..\..\Views\Shared\BaseLayout.cshtml"
   Write(Html.Partial("Partial/Info"));

            
            #line default
            #line hidden
            
            #line 106 "..\..\Views\Shared\BaseLayout.cshtml"
                                     
        
            
            #line default
            #line hidden
            
            #line 107 "..\..\Views\Shared\BaseLayout.cshtml"
   Write(Html.Partial("Partial/Tooltip"));

            
            #line default
            #line hidden
            
            #line 107 "..\..\Views\Shared\BaseLayout.cshtml"
                                        
        
            
            #line default
            #line hidden
            
            #line 108 "..\..\Views\Shared\BaseLayout.cshtml"
   Write(Html.Partial("Partial/ImagePreview"));

            
            #line default
            #line hidden
            
            #line 108 "..\..\Views\Shared\BaseLayout.cshtml"
                                             
        
            
            #line default
            #line hidden
            
            #line 109 "..\..\Views\Shared\BaseLayout.cshtml"
   Write(Html.Partial("Partial/SiteSettingTab"));

            
            #line default
            #line hidden
            
            #line 109 "..\..\Views\Shared\BaseLayout.cshtml"
                                               
        
            
            #line default
            #line hidden
            
            #line 110 "..\..\Views\Shared\BaseLayout.cshtml"
   Write(Html.Partial("Partial/ContentsTree"));

            
            #line default
            #line hidden
            
            #line 110 "..\..\Views\Shared\BaseLayout.cshtml"
                                             
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 113 "..\..\Views\Shared\BaseLayout.cshtml"
    
            
            #line default
            #line hidden
            
            #line 113 "..\..\Views\Shared\BaseLayout.cshtml"
     if (Model.JavaScripts != null)
    {
        
            
            #line default
            #line hidden
            
            #line 115 "..\..\Views\Shared\BaseLayout.cshtml"
   Write(Html.RenderPageCustomJavaScript(Model.JavaScripts));

            
            #line default
            #line hidden
            
            #line 115 "..\..\Views\Shared\BaseLayout.cshtml"
                                                           
    }

            
            #line default
            #line hidden
});

WriteLiteral("\r\n");

DefineSection("Styles", () => {

WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 120 "..\..\Views\Shared\BaseLayout.cshtml"
Write(RenderSection("Styles", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 122 "..\..\Views\Shared\BaseLayout.cshtml"
    
            
            #line default
            #line hidden
            
            #line 122 "..\..\Views\Shared\BaseLayout.cshtml"
     if (Model.Stylesheets != null)
    {
        
            
            #line default
            #line hidden
            
            #line 124 "..\..\Views\Shared\BaseLayout.cshtml"
   Write(Html.RenderPageCustomCss(Model.Stylesheets));

            
            #line default
            #line hidden
            
            #line 124 "..\..\Views\Shared\BaseLayout.cshtml"
                                                    
    }

            
            #line default
            #line hidden
});

DefineSection("HeadScripts", () => {

WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 128 "..\..\Views\Shared\BaseLayout.cshtml"
Write(RenderSection("HeadScripts", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

});

DefineSection("Scripts", () => {

WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 131 "..\..\Views\Shared\BaseLayout.cshtml"
Write(RenderSection("Scripts", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

});

DefineSection("DoctypeTag", () => {

WriteLiteral(" \r\n");

            
            #line 134 "..\..\Views\Shared\BaseLayout.cshtml"
    
            
            #line default
            #line hidden
            
            #line 134 "..\..\Views\Shared\BaseLayout.cshtml"
     if (IsSectionDefined("DoctypeTag"))
    {
        
            
            #line default
            #line hidden
            
            #line 136 "..\..\Views\Shared\BaseLayout.cshtml"
   Write(RenderSection("DoctypeTag", false));

            
            #line default
            #line hidden
            
            #line 136 "..\..\Views\Shared\BaseLayout.cshtml"
                                           
    }
    else
    {

            
            #line default
            #line hidden
WriteLiteral("        ");

WriteLiteral("<!DOCTYPE html>\r\n");

            
            #line 141 "..\..\Views\Shared\BaseLayout.cshtml"
    }

            
            #line default
            #line hidden
});

DefineSection("HtmlTag", () => {

WriteLiteral(" \r\n");

            
            #line 144 "..\..\Views\Shared\BaseLayout.cshtml"
    
            
            #line default
            #line hidden
            
            #line 144 "..\..\Views\Shared\BaseLayout.cshtml"
     if (IsSectionDefined("HtmlTag"))
    {
        
            
            #line default
            #line hidden
            
            #line 146 "..\..\Views\Shared\BaseLayout.cshtml"
   Write(RenderSection("HtmlTag", false));

            
            #line default
            #line hidden
            
            #line 146 "..\..\Views\Shared\BaseLayout.cshtml"
                                        
    }
    else
    {

            
            #line default
            #line hidden
WriteLiteral("        ");

WriteLiteral("<html>\r\n");

            
            #line 151 "..\..\Views\Shared\BaseLayout.cshtml"
    }

            
            #line default
            #line hidden
});

DefineSection("BodyTag", () => {

WriteLiteral(" \r\n");

            
            #line 154 "..\..\Views\Shared\BaseLayout.cshtml"
    
            
            #line default
            #line hidden
            
            #line 154 "..\..\Views\Shared\BaseLayout.cshtml"
     if (IsSectionDefined("BodyTag"))
    {
        
            
            #line default
            #line hidden
            
            #line 156 "..\..\Views\Shared\BaseLayout.cshtml"
   Write(RenderSection("BodyTag", false));

            
            #line default
            #line hidden
            
            #line 156 "..\..\Views\Shared\BaseLayout.cshtml"
                                        
    }
    else
    {

            
            #line default
            #line hidden
WriteLiteral("        ");

WriteLiteral("<body ");

            
            #line 160 "..\..\Views\Shared\BaseLayout.cshtml"
           Write(Html.RenderBodyAttributes());

            
            #line default
            #line hidden
            
            #line 160 "..\..\Views\Shared\BaseLayout.cshtml"
                                       Write(RenderSection("BodyAttributes", false));

            
            #line default
            #line hidden
WriteLiteral(">\r\n");

            
            #line 161 "..\..\Views\Shared\BaseLayout.cshtml"
    }

            
            #line default
            #line hidden
});

        }
    }
}
#pragma warning restore 1591
