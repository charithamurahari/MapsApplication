<<<<<<< HEAD
#pragma checksum "C:\Users\670264172\Desktop\LocalGIT\MapsApplication\MapsApplication\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c31ae26efd9d5c800e6adfe68c2f11cc55c1e0c5"
=======
#pragma checksum "C:\Users\670264172\Desktop\LocalGIT\MapsApplication\MapsApplication\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c203d96f6120248d126179f6390da9a14e571b2"
>>>>>>> MapsV1
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\670264172\Desktop\LocalGIT\MapsApplication\MapsApplication\Views\_ViewImports.cshtml"
using MapsApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\670264172\Desktop\LocalGIT\MapsApplication\MapsApplication\Views\_ViewImports.cshtml"
using MapsApplication.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\670264172\Desktop\LocalGIT\MapsApplication\MapsApplication\Views\Home\Index.cshtml"
using MapsApplication.Controllers;

#line default
#line hidden
#nullable disable
<<<<<<< HEAD
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c31ae26efd9d5c800e6adfe68c2f11cc55c1e0c5", @"/Views/Home/Index.cshtml")]
=======
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c203d96f6120248d126179f6390da9a14e571b2", @"/Views/Home/Index.cshtml")]
>>>>>>> MapsV1
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55afe54347ec9debb026e70c2dddfc20741481fc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<html>\r\n");
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c31ae26efd9d5c800e6adfe68c2f11cc55c1e0c53479", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c203d96f6120248d126179f6390da9a14e571b23479", async() => {
>>>>>>> MapsV1
                WriteLiteral(@"
    <title>Maps Application</title>

    <meta charset=""utf-8"" />
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <link rel=""stylesheet"" href=""https://unpkg.com/leaflet@1.7.1/dist/leaflet.css"" integrity=""sha512-xodZBNTC5n17Xt2atTPuE1HxjVMSvLVW9ocqUKLsCC5CXdbqCmblAshOMAS6/keqq/sMZMZ19scR4PsZChSR7A==""");
<<<<<<< HEAD
                BeginWriteAttribute("crossorigin", " crossorigin=\"", 400, "\"", 414, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <script src=\"https://unpkg.com/leaflet@1.7.1/dist/leaflet.js\" integrity=\"sha512-XQoYMqMTK8LvdxXYG3nZ448hOEQiglfqkJs1NOQV44cWnUrBc8PkAOcXy20w0vlaXaVUearIOBhiXZ5V3ynxwA==\"");
                BeginWriteAttribute("crossorigin", " crossorigin=\"", 593, "\"", 607, 0);
=======
                BeginWriteAttribute("crossorigin", " crossorigin=\"", 389, "\"", 403, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <script src=\"https://unpkg.com/leaflet@1.7.1/dist/leaflet.js\" integrity=\"sha512-XQoYMqMTK8LvdxXYG3nZ448hOEQiglfqkJs1NOQV44cWnUrBc8PkAOcXy20w0vlaXaVUearIOBhiXZ5V3ynxwA==\"");
                BeginWriteAttribute("crossorigin", " crossorigin=\"", 582, "\"", 596, 0);
>>>>>>> MapsV1
                EndWriteAttribute();
                WriteLiteral(@"></script>

    <style>
        body {
            font-family: Arial, Arial, Helvetica, sans-serif;
        }

        .button {
            background-color: darkcyan;
            border: none;
            color: white;
            padding: 15px 32px;
            text-align: center;
            text-decoration: none;
            display: inline-block;
            font-size: 16px;
            margin: 4px 2px;
            cursor: pointer;
        }
    </style>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c31ae26efd9d5c800e6adfe68c2f11cc55c1e0c55790", async() => {
                WriteLiteral("\r\n    <div class=\"container\">\r\n\r\n        <div class=\"row\">\r\n            <div class=\"col-md-9\">\r\n\r\n                <div id=\"mapid\" style=\"width: 800px; height: 400px;\"></div>\r\n            </div>\r\n            <div class=\"col-md-3\">\r\n");
#nullable restore
#line 41 "C:\Users\670264172\Desktop\LocalGIT\MapsApplication\MapsApplication\Views\Home\Index.cshtml"
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c203d96f6120248d126179f6390da9a14e571b25790", async() => {
                WriteLiteral("\r\n    <div class=\"container\">\r\n\r\n        <div class=\"row\">\r\n            <div class=\"col-md-9\">\r\n\r\n                <div id=\"mapid\" style=\"width: 800px; height: 400px;\"></div>\r\n            </div>\r\n            <div class=\"col-md-3\">\r\n");
#nullable restore
#line 40 "C:\Users\670264172\Desktop\LocalGIT\MapsApplication\MapsApplication\Views\Home\Index.cshtml"
>>>>>>> MapsV1
                 using (Html.BeginForm())
                {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    <table>

                        <tr>
                            <td><label for=""Name"">Name</label></td>
                            <td><input type=""text"" id=""Name"" name=""Name""></td>
                        </tr>
                        <tr>
                            <td><label for=""Latitude"">Latitude</label></td>
                            <td><input type=""text"" id=""Latitude"" name=""Latitude""></td>
                        </tr>
                        <tr>
                            <td><label for=""Longitude"">Longitude</label></td>
                            <td><input type=""text"" id=""Longitude"" name=""Longitude""></td>
                        </tr>
                        <tr></tr>
                    </table>
                    <br />
                    <input type=""submit"" class=""button"" value=""Add Location"">
                    <br />
                    <br />
");
#nullable restore
<<<<<<< HEAD
#line 63 "C:\Users\670264172\Desktop\LocalGIT\MapsApplication\MapsApplication\Views\Home\Index.cshtml"
=======
#line 62 "C:\Users\670264172\Desktop\LocalGIT\MapsApplication\MapsApplication\Views\Home\Index.cshtml"
>>>>>>> MapsV1

                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n\r\n");
#nullable restore
<<<<<<< HEAD
#line 69 "C:\Users\670264172\Desktop\LocalGIT\MapsApplication\MapsApplication\Views\Home\Index.cshtml"
=======
#line 68 "C:\Users\670264172\Desktop\LocalGIT\MapsApplication\MapsApplication\Views\Home\Index.cshtml"
>>>>>>> MapsV1
      
        int i = 0;
        foreach (var locationDetails in HomeController.locationDetailsFromDatabases)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <p>\r\n                ");
#nullable restore
<<<<<<< HEAD
#line 74 "C:\Users\670264172\Desktop\LocalGIT\MapsApplication\MapsApplication\Views\Home\Index.cshtml"
=======
#line 73 "C:\Users\670264172\Desktop\LocalGIT\MapsApplication\MapsApplication\Views\Home\Index.cshtml"
>>>>>>> MapsV1
           Write(locationDetails.id);

#line default
#line hidden
#nullable disable
                WriteLiteral(" | ");
#nullable restore
<<<<<<< HEAD
#line 74 "C:\Users\670264172\Desktop\LocalGIT\MapsApplication\MapsApplication\Views\Home\Index.cshtml"
=======
#line 73 "C:\Users\670264172\Desktop\LocalGIT\MapsApplication\MapsApplication\Views\Home\Index.cshtml"
>>>>>>> MapsV1
                                 Write(locationDetails.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" | ");
#nullable restore
<<<<<<< HEAD
#line 74 "C:\Users\670264172\Desktop\LocalGIT\MapsApplication\MapsApplication\Views\Home\Index.cshtml"
=======
#line 73 "C:\Users\670264172\Desktop\LocalGIT\MapsApplication\MapsApplication\Views\Home\Index.cshtml"
>>>>>>> MapsV1
                                                         Write(locationDetails.Latitude);

#line default
#line hidden
#nullable disable
                WriteLiteral(" | ");
#nullable restore
<<<<<<< HEAD
#line 74 "C:\Users\670264172\Desktop\LocalGIT\MapsApplication\MapsApplication\Views\Home\Index.cshtml"
=======
#line 73 "C:\Users\670264172\Desktop\LocalGIT\MapsApplication\MapsApplication\Views\Home\Index.cshtml"
>>>>>>> MapsV1
                                                                                     Write(locationDetails.Longitude);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <br />\r\n            </p>\r\n");
#nullable restore
<<<<<<< HEAD
#line 77 "C:\Users\670264172\Desktop\LocalGIT\MapsApplication\MapsApplication\Views\Home\Index.cshtml"
=======
#line 76 "C:\Users\670264172\Desktop\LocalGIT\MapsApplication\MapsApplication\Views\Home\Index.cshtml"
>>>>>>> MapsV1
           i++;
        }
    

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
<script>
        var location;

        var mymap = L.map('mapid').setView([28.7041, 77.1025], 13);

        L.tileLayer('https://api.mapbox.com/styles/v1/{id}/tiles/{z}/{x}/{y}?access_token=pk.eyJ1IjoibWFwYm94IiwiYSI6ImNpejY4NXVycTA2emYycXBndHRqcmZ3N3gifQ.rJcFIG214AriISLbB6B5aw', {
            maxZoom: 18,
            attribution: 'Map data &copy; <a href=""https://www.openstreetmap.org/copyright"">OpenStreetMap</a> contributors, ' +
                'Imagery ?? <a href=""https://www.mapbox.com/"">Mapbox</a>',
            id: 'mapbox/streets-v11',
            tileSize: 512,
            zoomOffset: -1
        }).addTo(mymap);

        
        var names = [];
        var latitudes = [];
        var longitudes = [];

");
#nullable restore
<<<<<<< HEAD
#line 100 "C:\Users\670264172\Desktop\LocalGIT\MapsApplication\MapsApplication\Views\Home\Index.cshtml"
=======
#line 99 "C:\Users\670264172\Desktop\LocalGIT\MapsApplication\MapsApplication\Views\Home\Index.cshtml"
>>>>>>> MapsV1
         foreach(var detailsFromList in HomeController.locationDetailsFromDatabases)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                ");
                WriteLiteral("names.push(\"");
#nullable restore
<<<<<<< HEAD
#line 102 "C:\Users\670264172\Desktop\LocalGIT\MapsApplication\MapsApplication\Views\Home\Index.cshtml"
=======
#line 101 "C:\Users\670264172\Desktop\LocalGIT\MapsApplication\MapsApplication\Views\Home\Index.cshtml"
>>>>>>> MapsV1
                         Write(detailsFromList.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\");\r\n                ");
                WriteLiteral("latitudes.push(\"");
#nullable restore
<<<<<<< HEAD
#line 103 "C:\Users\670264172\Desktop\LocalGIT\MapsApplication\MapsApplication\Views\Home\Index.cshtml"
=======
#line 102 "C:\Users\670264172\Desktop\LocalGIT\MapsApplication\MapsApplication\Views\Home\Index.cshtml"
>>>>>>> MapsV1
                             Write(detailsFromList.Latitude);

#line default
#line hidden
#nullable disable
                WriteLiteral("\");\r\n                ");
                WriteLiteral("longitudes.push(\"");
#nullable restore
<<<<<<< HEAD
#line 104 "C:\Users\670264172\Desktop\LocalGIT\MapsApplication\MapsApplication\Views\Home\Index.cshtml"
=======
#line 103 "C:\Users\670264172\Desktop\LocalGIT\MapsApplication\MapsApplication\Views\Home\Index.cshtml"
>>>>>>> MapsV1
                              Write(detailsFromList.Longitude);

#line default
#line hidden
#nullable disable
                WriteLiteral("\");\r\n");
#nullable restore
<<<<<<< HEAD
#line 105 "C:\Users\670264172\Desktop\LocalGIT\MapsApplication\MapsApplication\Views\Home\Index.cshtml"
=======
#line 104 "C:\Users\670264172\Desktop\LocalGIT\MapsApplication\MapsApplication\Views\Home\Index.cshtml"
>>>>>>> MapsV1
            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"        
    for (var i = 0; i < names.length; i++) {
        var lat = latitudes[i];
        var lon = longitudes[i];
        var city = names[i];
        var markerLocation = new L.LatLng(lat, lon);
        var marker = new L.Marker(markerLocation);
        mymap.addLayer(marker);
        marker.bindPopup(city);
    }
</script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n \r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
