#pragma checksum "C:\projeler\firstBlazorApp\Pages\AddEmployee.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64ae14d9b7a436b66dbc68513918df79a7f8f2e8"
// <auto-generated/>
#pragma warning disable 1591
namespace firstBlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\projeler\firstBlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\projeler\firstBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\projeler\firstBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\projeler\firstBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\projeler\firstBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\projeler\firstBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\projeler\firstBlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\projeler\firstBlazorApp\_Imports.razor"
using firstBlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\projeler\firstBlazorApp\_Imports.razor"
using firstBlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\projeler\firstBlazorApp\Pages\AddEmployee.razor"
using firstBlazorApp.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AddEmployee")]
    public partial class AddEmployee : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Add Employee</h2>\r\n");
            __builder.OpenElement(1, "form");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col-md-8");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "form-group");
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.AddMarkupContent(12, "<label for=\"Name\" class=\"control-label\">Name</label>\r\n                ");
            __builder.OpenElement(13, "input");
            __builder.AddAttribute(14, "form", "Name");
            __builder.AddAttribute(15, "class", "form-control");
            __builder.AddAttribute(16, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 12 "C:\projeler\firstBlazorApp\Pages\AddEmployee.razor"
                                                                objEmp.Name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objEmp.Name = __value, objEmp.Name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "form-group");
            __builder.AddMarkupContent(22, "\r\n                ");
            __builder.AddMarkupContent(23, "<label for=\"SurName\" class=\"control-label\">SurName</label>\r\n                ");
            __builder.OpenElement(24, "input");
            __builder.AddAttribute(25, "form", "SurName");
            __builder.AddAttribute(26, "class", "form-control");
            __builder.AddAttribute(27, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "C:\projeler\firstBlazorApp\Pages\AddEmployee.razor"
                                                                   objEmp.SurName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objEmp.SurName = __value, objEmp.SurName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n            ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "form-group");
            __builder.AddMarkupContent(33, "\r\n                <label for=\"Gender\" class=\"control-label\"></label>\r\n                ");
            __builder.OpenElement(34, "select");
            __builder.AddAttribute(35, "class", "form-control");
            __builder.AddAttribute(36, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 20 "C:\projeler\firstBlazorApp\Pages\AddEmployee.razor"
                                objEmp.Gender

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(37, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objEmp.Gender = __value, objEmp.Gender));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(38, "\r\n                    ");
            __builder.OpenElement(39, "option");
            __builder.AddAttribute(40, "value", true);
            __builder.AddContent(41, "--Select Gender--");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                    ");
            __builder.OpenElement(43, "option");
            __builder.AddAttribute(44, "value", "Male");
            __builder.AddContent(45, "Male");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                    ");
            __builder.OpenElement(47, "option");
            __builder.AddAttribute(48, "value", "Female");
            __builder.AddContent(49, "Female");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n            ");
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "class", "form-group");
            __builder.AddMarkupContent(55, "\r\n                ");
            __builder.AddMarkupContent(56, "<label for=\"Country\" class=\"control-label\">Country</label>\r\n                ");
            __builder.OpenElement(57, "input");
            __builder.AddAttribute(58, "form", "Country");
            __builder.AddAttribute(59, "class", "form-control");
            __builder.AddAttribute(60, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 28 "C:\projeler\firstBlazorApp\Pages\AddEmployee.razor"
                                                                   objEmp.Country

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(61, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objEmp.Country = __value, objEmp.Country));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n            ");
            __builder.OpenElement(64, "div");
            __builder.AddAttribute(65, "class", "form-group");
            __builder.AddMarkupContent(66, "\r\n                ");
            __builder.AddMarkupContent(67, "<label for=\"City\" class=\"control-label\">City</label>\r\n                ");
            __builder.OpenElement(68, "input");
            __builder.AddAttribute(69, "form", "City");
            __builder.AddAttribute(70, "class", "form-control");
            __builder.AddAttribute(71, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 32 "C:\projeler\firstBlazorApp\Pages\AddEmployee.razor"
                                                                objEmp.City

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(72, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objEmp.City = __value, objEmp.City));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n    ");
            __builder.OpenElement(77, "div");
            __builder.AddAttribute(78, "class", "row");
            __builder.AddMarkupContent(79, "\r\n        ");
            __builder.OpenElement(80, "div");
            __builder.AddAttribute(81, "class", "col-md-4");
            __builder.AddMarkupContent(82, "\r\n            ");
            __builder.OpenElement(83, "div");
            __builder.AddAttribute(84, "class", "form-group");
            __builder.AddMarkupContent(85, "\r\n                ");
            __builder.OpenElement(86, "input");
            __builder.AddAttribute(87, "type", "button");
            __builder.AddAttribute(88, "class", "btn btn-primary");
            __builder.AddAttribute(89, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 39 "C:\projeler\firstBlazorApp\Pages\AddEmployee.razor"
                                                                        CreateEmployee

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(90, "value", "Save");
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n                ");
            __builder.OpenElement(92, "input");
            __builder.AddAttribute(93, "type", "button");
            __builder.AddAttribute(94, "class", "btn btn-primary");
            __builder.AddAttribute(95, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "C:\projeler\firstBlazorApp\Pages\AddEmployee.razor"
                                                                        Cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(96, "value", "Cancel");
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(100, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "C:\projeler\firstBlazorApp\Pages\AddEmployee.razor"
       
    EmployeeInfo objEmp = new EmployeeInfo();

    protected void CreateEmployee()
    {
        objEmpService.Create(objEmp);
        NavigationManager.NavigateTo("Employee");
    }
    void Cancel()
    {
        NavigationManager.NavigateTo("Employee");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private EmployeeService objEmpService { get; set; }
    }
}
#pragma warning restore 1591
