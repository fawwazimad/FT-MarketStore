#pragma checksum "C:\Users\Administrator\source\repos\FT_MarketStore\FT_MarketStore\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "25ce3931cb778c5c03cd9ff517851ec3306429df"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
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
#line 1 "C:\Users\Administrator\source\repos\FT_MarketStore\FT_MarketStore\Views\_ViewImports.cshtml"
using FT_MarketStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrator\source\repos\FT_MarketStore\FT_MarketStore\Views\_ViewImports.cshtml"
using FT_MarketStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25ce3931cb778c5c03cd9ff517851ec3306429df", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9288e880cb6766a3551de22c392c52e40f1bf994", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assists/img/notification-01.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Avatar Image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assists/img/notification-02.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assists/img/notification-03.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("reportsPage"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Administrator\source\repos\FT_MarketStore\FT_MarketStore\Views\Admin\Index.cshtml"
   
    
    ViewData["Title"] = "Dashboard"; 
    Layout = "~/Views/Shared/_ AdminLayout.cshtml"; 
    var userId = ViewBag.userId; 


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25ce3931cb778c5c03cd9ff517851ec3306429df5984", async() => {
                WriteLiteral(" ");
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25ce3931cb778c5c03cd9ff517851ec3306429df6951", async() => {
                WriteLiteral(@"

        <div class=""container"">
            <div class=""row"">
                <div class=""col"">
                    <p class=""text-white mt-5 mb-5"">Welcome back,<b>Fawwaz</b></p>
                </div>
            </div>
            <!-- row -->
            <div class=""row tm-content-row"">
                <div class=""col-sm-12 col-md-12 col-lg-6 col-xl-6 tm-block-col"">
                    <div class=""tm-bg-primary-dark tm-block"">
                        <h2 class=""tm-block-title"">Latest Hits</h2>
                        <canvas id=""lineChart""></canvas>
                    </div>
                </div>
                <div class=""col-sm-12 col-md-12 col-lg-6 col-xl-6 tm-block-col"">
                    <div class=""tm-bg-primary-dark tm-block"">
                        <h2 class=""tm-block-title"">Performance</h2>
                        <canvas id=""barChart""></canvas>
                    </div>
                </div>
                <div class=""col-sm-12 col-md-12 col-lg-6 col-xl-6 tm-block");
                WriteLiteral(@"-col"">
                    <div class=""tm-bg-primary-dark tm-block tm-block-taller"">
                        <h2 class=""tm-block-title"">Storage Information</h2>
                        <div id=""pieChartContainer"">
                            <canvas id=""pieChart"" class=""chartjs-render-monitor"" width=""200"" height=""200""></canvas>
                        </div>                        
                    </div>
                </div>
                <div class=""col-sm-12 col-md-12 col-lg-6 col-xl-6 tm-block-col"">
                    <div class=""tm-bg-primary-dark tm-block tm-block-taller tm-block-overflow"">
                        <h2 class=""tm-block-title"">Notification List</h2>
                        <div class=""tm-notification-items"">
                            <div class=""media tm-notification-item"">
                                <div class=""tm-gray-circle"">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "25ce3931cb778c5c03cd9ff517851ec3306429df9208", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"</div>
                                <div class=""media-body"">
                                    <p class=""mb-2""><b>Jessica</b> and <b>6 others</b> sent you new <a href=""#""
                                            class=""tm-notification-link"">product updates</a>. Check new orders.</p>
                                    <span class=""tm-small tm-text-color-secondary"">6h ago.</span>
                                </div>
                            </div>
                            <div class=""media tm-notification-item"">
                                <div class=""tm-gray-circle"">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "25ce3931cb778c5c03cd9ff517851ec3306429df11081", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"</div>
                                <div class=""media-body"">
                                    <p class=""mb-2""><b>Oliver Too</b> and <b>6 others</b> sent you existing <a href=""#""
                                            class=""tm-notification-link"">product updates</a>. Read more reports.</p>
                                    <span class=""tm-small tm-text-color-secondary"">6h ago.</span>
                                </div>
                            </div>
                            <div class=""media tm-notification-item"">
                                <div class=""tm-gray-circle"">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "25ce3931cb778c5c03cd9ff517851ec3306429df12964", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"</div>
                                <div class=""media-body"">
                                    <p class=""mb-2""><b>Victoria</b> and <b>6 others</b> sent you <a href=""#""
                                            class=""tm-notification-link"">order updates</a>. Read order information.</p>
                                    <span class=""tm-small tm-text-color-secondary"">6h ago.</span>
                                </div>
                            </div>
                            <div class=""media tm-notification-item"">
                                <div class=""tm-gray-circle"">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "25ce3931cb778c5c03cd9ff517851ec3306429df14839", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"</div>
                                <div class=""media-body"">
                                    <p class=""mb-2""><b>Laura Cute</b> and <b>6 others</b> sent you <a href=""#""
                                            class=""tm-notification-link"">product records</a>.</p>
                                    <span class=""tm-small tm-text-color-secondary"">6h ago.</span>
                                </div>
                            </div>
                            <div class=""media tm-notification-item"">
                                <div class=""tm-gray-circle"">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "25ce3931cb778c5c03cd9ff517851ec3306429df16694", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"</div>
                                <div class=""media-body"">
                                    <p class=""mb-2""><b>Samantha</b> and <b>6 others</b> sent you <a href=""#""
                                            class=""tm-notification-link"">order stuffs</a>.</p>
                                    <span class=""tm-small tm-text-color-secondary"">6h ago.</span>
                                </div>
                            </div>
                            <div class=""media tm-notification-item"">
                                <div class=""tm-gray-circle"">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "25ce3931cb778c5c03cd9ff517851ec3306429df18544", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"</div>
                                <div class=""media-body"">
                                    <p class=""mb-2""><b>Sophie</b> and <b>6 others</b> sent you <a href=""#""
                                            class=""tm-notification-link"">product updates</a>.</p>
                                    <span class=""tm-small tm-text-color-secondary"">6h ago.</span>
                                </div>
                            </div>
                            <div class=""media tm-notification-item"">
                                <div class=""tm-gray-circle"">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "25ce3931cb778c5c03cd9ff517851ec3306429df20395", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"</div>
                                <div class=""media-body"">
                                    <p class=""mb-2""><b>Lily A</b> and <b>6 others</b> sent you <a href=""#""
                                            class=""tm-notification-link"">product updates</a>.</p>
                                    <span class=""tm-small tm-text-color-secondary"">6h ago.</span>
                                </div>
                            </div>
                            <div class=""media tm-notification-item"">
                                <div class=""tm-gray-circle"">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "25ce3931cb778c5c03cd9ff517851ec3306429df22246", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"</div>
                                <div class=""media-body"">
                                    <p class=""mb-2""><b>Amara</b> and <b>6 others</b> sent you <a href=""#""
                                            class=""tm-notification-link"">product updates</a>.</p>
                                    <span class=""tm-small tm-text-color-secondary"">6h ago.</span>
                                </div>
                            </div>
                            <div class=""media tm-notification-item"">
                                <div class=""tm-gray-circle"">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "25ce3931cb778c5c03cd9ff517851ec3306429df24096", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"</div>
                                <div class=""media-body"">
                                    <p class=""mb-2""><b>Cinthela</b> and <b>6 others</b> sent you <a href=""#""
                                            class=""tm-notification-link"">product updates</a>.</p>
                                    <span class=""tm-small tm-text-color-secondary"">6h ago.</span>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col-12 tm-block-col"">
                    <div class=""tm-bg-primary-dark tm-block tm-block-taller tm-block-scroll"">
                        <h2 class=""tm-block-title"">Orders List</h2>
                        <table class=""table"">
                            <thead>
                                <tr>
                                    <th scope=""col"">ORDER NO.</th>
                                    <th scope=""col"">STATUS</th>
                    ");
                WriteLiteral(@"                <th scope=""col"">OPERATORS</th>
                                    <th scope=""col"">LOCATION</th>
                                    <th scope=""col"">DISTANCE</th>
                                    <th scope=""col"">START DATE</th>
                                    <th scope=""col"">EST DELIVERY DUE</th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <th scope=""row""><b>#122349</b></th>
                                    <td>
                                        <div class=""tm-status-circle moving"">
                                        </div>Moving
                                    </td>
                                    <td><b>Oliver Trag</b></td>
                                    <td><b>London, UK</b></td>
                                    <td><b>485 km</b></td>
                                    <td>16:00, 12 NOV 2018</td>
 ");
                WriteLiteral(@"                                   <td>08:00, 18 NOV 2018</td>
                                </tr>
                                <tr>
                                    <th scope=""row""><b>#122348</b></th>
                                    <td>
                                        <div class=""tm-status-circle pending"">
                                        </div>Pending
                                    </td>
                                    <td><b>Jacob Miller</b></td>
                                    <td><b>London, UK</b></td>
                                    <td><b>360 km</b></td>
                                    <td>11:00, 10 NOV 2018</td>
                                    <td>04:00, 14 NOV 2018</td>
                                </tr>
                                <tr>
                                    <th scope=""row""><b>#122347</b></th>
                                    <td>
                                        <div class=""tm-status-circle cancelled");
                WriteLiteral(@""">
                                        </div>Cancelled
                                    </td>
                                    <td><b>George Wilson</b></td>
                                    <td><b>London, UK</b></td>
                                    <td><b>340 km</b></td>
                                    <td>12:00, 22 NOV 2018</td>
                                    <td>06:00, 28 NOV 2018</td>
                                </tr>
                                <tr>
                                    <th scope=""row""><b>#122346</b></th>
                                    <td>
                                        <div class=""tm-status-circle moving"">
                                        </div>Moving
                                    </td>
                                    <td><b>William Aung</b></td>
                                    <td><b>London, UK</b></td>
                                    <td><b>218 km</b></td>
                                    <td>1");
                WriteLiteral(@"5:00, 10 NOV 2018</td>
                                    <td>09:00, 14 NOV 2018</td>
                                </tr>
                                <tr>
                                    <th scope=""row""><b>#122345</b></th>
                                    <td>
                                        <div class=""tm-status-circle pending"">
                                        </div>Pending
                                    </td>
                                    <td><b>Harry Ryan</b></td>
                                    <td><b>London, UK</b></td>
                                    <td><b>280 km</b></td>
                                    <td>15:00, 11 NOV 2018</td>
                                    <td>09:00, 17 NOV 2018</td>
                                </tr>
                                <tr>
                                    <th scope=""row""><b>#122344</b></th>
                                    <td>
                                        <div class=""tm-");
                WriteLiteral(@"status-circle pending"">
                                        </div>Pending
                                    </td>
                                    <td><b>Michael Jones</b></td>
                                    <td><b>London, UK</b></td>
                                    <td><b>218 km</b></td>
                                    <td>18:00, 12 OCT 2018</td>
                                    <td>06:00, 18 OCT 2018</td>
                                </tr>
                                <tr>
                                    <th scope=""row""><b>#122343</b></th>
                                    <td>
                                        <div class=""tm-status-circle moving"">
                                        </div>Moving
                                    </td>
                                    <td><b>Timmy Davis</b></td>
                                    <td><b>London, UK</b></td>
                                    <td><b>218 km</b></td>
                       ");
                WriteLiteral(@"             <td>12:00, 10 OCT 2018</td>
                                    <td>08:00, 18 OCT 2018</td>
                                </tr>
                                <tr>
                                    <th scope=""row""><b>#122342</b></th>
                                    <td>
                                        <div class=""tm-status-circle moving"">
                                        </div>Moving
                                    </td>
                                    <td><b>Oscar Phyo</b></td>
                                    <td><b>London, UK</b></td>
                                    <td><b>420 km</b></td>
                                    <td>15:30, 06 OCT 2018</td>
                                    <td>09:30, 16 OCT 2018</td>
                                </tr>
                                <tr>
                                    <th scope=""row""><b>#122341</b></th>
                                    <td>
                                       ");
                WriteLiteral(@" <div class=""tm-status-circle moving"">
                                        </div>Moving
                                    </td>
                                    <td><b>Charlie Brown</b></td>
                                    <td><b>London, UK</b></td>
                                    <td><b>300 km</b></td>
                                    <td>11:00, 10 OCT 2018</td>
                                    <td>03:00, 14 OCT 2018</td>
                                </tr>
                                <tr>
                                    <th scope=""row""><b>#122340</b></th>
                                    <td>
                                        <div class=""tm-status-circle cancelled"">
                                        </div>Cancelled
                                    </td>
                                    <td><b>Wilson Cookies</b></td>
                                    <td><b>London, UK</b></td>
                                    <td><b>218 km</b></td>
");
                WriteLiteral(@"                                    <td>17:30, 12 OCT 2018</td>
                                    <td>08:30, 22 OCT 2018</td>
                                </tr>
                                <tr>
                                    <th scope=""row""><b>#122339</b></th>
                                    <td>
                                        <div class=""tm-status-circle moving"">
                                        </div>Moving
                                    </td>
                                    <td><b>Richard Clamon</b></td>
                                    <td><b>London, UK</b></td>
                                    <td><b>150 km</b></td>
                                    <td>15:00, 12 OCT 2018</td>
                                    <td>09:20, 26 OCT 2018</td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        </div>  
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>\r\n\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
