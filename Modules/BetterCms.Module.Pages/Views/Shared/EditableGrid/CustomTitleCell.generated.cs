﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/EditableGrid/CustomTitleCell.cshtml")]
    public partial class _Views_Shared_EditableGrid_CustomTitleCell_cshtml : System.Web.Mvc.WebViewPage<BetterCms.Module.Pages.Mvc.EditableGrid.CustomTitleEditableGridColumn>
    {
        public _Views_Shared_EditableGrid_CustomTitleCell_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

WriteLiteral("<td>\r\n    <div>\r\n        <a");

WriteLiteral(" data-bind=\"\r\n            text: ");

            
            #line 32 "..\..\Views\Shared\EditableGrid\CustomTitleCell.cshtml"
              Write(Model.ValueBind);

            
            #line default
            #line hidden
WriteLiteral("(),\r\n            href: ");

            
            #line 33 "..\..\Views\Shared\EditableGrid\CustomTitleCell.cshtml"
              Write(Model.CustomBindings["url"]);

            
            #line default
            #line hidden
WriteLiteral("()\r\n             \"");

WriteLiteral("></a>\r\n        <div");

WriteLiteral(" data-bind=\"\r\n            text: ");

            
            #line 36 "..\..\Views\Shared\EditableGrid\CustomTitleCell.cshtml"
              Write(Model.CustomBindings["createdOn"]);

            
            #line default
            #line hidden
WriteLiteral("()\r\n            \"");

WriteLiteral("></div>\r\n        <div");

WriteLiteral(" data-bind=\"\r\n            text: ");

            
            #line 39 "..\..\Views\Shared\EditableGrid\CustomTitleCell.cshtml"
              Write(Model.CustomBindings["modifiedOn"]);

            
            #line default
            #line hidden
WriteLiteral(" ()\r\n            \"");

WriteLiteral("></div>\r\n        <div");

WriteLiteral(" data-bind=\"\r\n            text: ");

            
            #line 42 "..\..\Views\Shared\EditableGrid\CustomTitleCell.cshtml"
              Write(Model.CustomBindings["modifiedBy"]);

            
            #line default
            #line hidden
WriteLiteral(" ()\r\n            \"");

WriteLiteral("></div>\r\n    </div>\r\n    <div");

WriteLiteral(" style=\"width: 85px; text-align: center\"");

WriteLiteral(" class=\"bcms-page-ispublished\"");

WriteLiteral(" data-bind=\"\r\n         text: ");

            
            #line 46 "..\..\Views\Shared\EditableGrid\CustomTitleCell.cshtml"
           Write(Model.CustomBindings["pageStatus"]);

            
            #line default
            #line hidden
WriteLiteral(" ()\r\n         \"");

WriteLiteral("></div>\r\n</td>");

        }
    }
}
#pragma warning restore 1591