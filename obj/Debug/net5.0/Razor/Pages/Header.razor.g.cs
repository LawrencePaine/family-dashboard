#pragma checksum "C:\Users\lpain\family-dashboard\Pages\Header.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cada92b31c8c9b6399f6dae972fb2542f8ce64b6"
// <auto-generated/>
#pragma warning disable 1591
namespace Family_Dashboard.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\lpain\family-dashboard\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lpain\family-dashboard\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\lpain\family-dashboard\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\lpain\family-dashboard\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\lpain\family-dashboard\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\lpain\family-dashboard\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\lpain\family-dashboard\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\lpain\family-dashboard\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\lpain\family-dashboard\_Imports.razor"
using Family_Dashboard;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\lpain\family-dashboard\_Imports.razor"
using Family_Dashboard.Shared;

#line default
#line hidden
#nullable disable
    public partial class Header : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<html lang=\"en\"><head><title>DAKboard</title>\n    <link rel=\"stylesheet\" href=\"https://fonts.googleapis.com/css?family=Roboto:300,400\">\n    <link rel=\"stylesheet\" href=\"/css/app.css?20180124\">\n    <link rel=\"stylesheet\" href=\"/css/screen-layout-big-calendar.css?20180109\">\n\n    <link rel=\"stylesheet\" href=\"https://pro.fontawesome.com/releases/v5.8.2/css/all.css\" integrity=\"sha384-xVVam1KS4+Qt2OrFa+VdRUoXygyKIuNWUUUBZYv+n27STsJ7oDOHJgfF0bNKLMJF\" crossorigin=\"anonymous\">\n\n    <meta charset=\"UTF-8\">\n    <meta http-equiv=\"refresh\" content=\"14400\">\n    <meta name=\"apple-mobile-web-app-capable\" content=\"yes\">\n    <meta name=\"mobile-web-app-capable\" content=\"yes\">\n    <link rel=\"apple-touch-icon\" href=\"https://static.dakboard.com/assets/img/dakboard-logos/apple-touch-icon.png\">\n    <link rel=\"icon\" sizes=\"192x192\" href=\"https://static.dakboard.com/assets/img/dakboard-logos/apple-touch-icon.png\"></head>\n<body data-new-gr-c-s-check-loaded=\"8.871.0\" data-gr-ext-installed><style>\n\n        .time-ampm {\n            left: -1.4em\n        }\n\n        .brightness {\n            background: rgba(0,0,0, 0);\n        }\n    </style>\n    <div class=\"font-large\"><a href=\"/screens\" class=\"options-link xsmall dark\" style=\"opacity: 0;\"><span class=\"fas fa-cog\"></span>&nbsp;&nbsp;<span class=\"options-desc font-light\">Options</span></a>\n\n        <header style=\"height: 446px;\"><div class=\"weather-container weather-parent\"><div id=\"weather\" style=\"padding: 45px 0 0 0;\"><div class=\"weather-container\"><div class=\"weather-item weather-current\"><div class=\"weather-current-alt font-light\">\n                                18 <small>mph</small> NW&nbsp;&nbsp;<span class=\"far fa-wind\"></span><br>\n\n                                5:50&nbsp;&nbsp;<span class=\"far fa-sunset\"></span></div>\n                            <div class=\"bright large\">\n                                38<sup>°</sup>\n                                <span class=\"weather-current-icon fal fa-sun\" title></span></div></div>\n\n\n                        <div class=\"text-center weather-item weather-forecast weather-forecast-1\"><div class=\"day\">Today</div>\n                            <span class=\"fas fa-sun bright medium\"></span><br>\n                            <span class=\"bright weather-forecast-item-high\">40</span>\n                            <span class=\"bright weather-forecast-item-low\">29</span></div>\n                        <div class=\"text-center weather-item weather-forecast weather-forecast-2\"><div class=\"day\">Fri</div>\n                            <span class=\"fas fa-sun-cloud bright medium\"></span><br>\n                            <span class=\"bright weather-forecast-item-high\">34</span>\n                            <span class=\"bright weather-forecast-item-low\">31</span></div>\n                        <div class=\"text-center weather-item weather-forecast weather-forecast-3\"><div class=\"day\">Sat</div>\n                            <span class=\"fas fa-sun bright medium\"></span><br>\n                            <span class=\"bright weather-forecast-item-high\">37</span>\n                            <span class=\"bright weather-forecast-item-low\">30</span></div>\n                        <div class=\"text-center weather-item weather-forecast weather-forecast-4\"><div class=\"day\">Sun</div>\n                            <span class=\"fas fa-sun bright medium\"></span><br>\n                            <span class=\"bright weather-forecast-item-high\">35</span>\n                            <span class=\"bright weather-forecast-item-low\">29</span></div></div></div></div>\n\n            <div id=\"weather-alert\" class=\"translucent-alert weather-alert hide\" style=\"display: none;\"><div class=\"weather-alert-inside\"><div class=\"pull-left big\"><span id=\"weather-alert-icon\" class=\"wi\"></span></div>\n                    <div style=\"margin-left: 70px;\"><div id=\"weather-alert-expires\" class=\"xsmall font-light pull-right\"></div>\n                        <div id=\"weather-alert-description\" class=\"small font-light\"></div>\n\n                        <div id=\"weather-alert-message\" class=\"xxsmall\"></div></div>\n                    <div class=\"clearfix\"></div></div></div>\n\n            <div class=\"clock clock-container bright\" style><div style><div class=\"time large\">5:16<span class=\"sec\">39</span></div></div></div>\n            <div class=\"fade bright date-container \" style><div class=\"date\" style><div class=\"day-of-week\">Thursday,</div><div class=\"month\">March 4</div></div></div>\n\n            <div id=\"todo-loading\" class style=\"margin: 30px 0px 0px 20px; display: none;\"><span class=\"dark font-light\">Loading To-do...</span></div>\n            <div id=\"todo\" class=\"todo bright\"><ul class=\"task-list\"></ul></div></header>\n\n\n\n        <div id=\"calendar\" class=\"events\" style=\" \"><table class><thead><tr><th><div class=\"event-date \">M</div></th>\n                        <th><div class=\"event-date \">T</div></th>\n                        <th><div class=\"event-date \">W</div></th>\n                        <th><div class=\"event-date today-header\">T</div></th>\n                        <th><div class=\"event-date \">F</div></th>\n                        <th><div class=\"event-date \">S</div></th>\n                        <th><div class=\"event-date \">S</div></th></tr></thead>\n                <tbody><tr><td><div class=\"event-day disabled\"><div class=\"event-date \">Mar </div><ul><li class=\"event-all-day event-#039be5\" style=\"background-color: #039be5\">\n\n\n\n                                        Holiday\t\t\t\t\t\t\t\t<span class=\"location\"></span></li></ul></div></td>\n                        <td><div class=\"event-day disabled\"><div class=\"event-date \">3</div><ul><li class=\"event-all-day event-#039be5\" style=\"background-color: #039be5\">\n\n\n\n                                        Holiday\t\t\t\t\t\t\t\t<span class=\"location\"></span></li></ul></div></td>\n                        <td><div class=\"event-day \"><div class=\"event-date \">5</div><ul><li class=\"event-all-day event-#039be5\" style=\"background-color: #039be5\">\n\n\n\n                                        Holiday\t\t\t\t\t\t\t\t<span class=\"location\"></span></li></ul></div></td>\n                        <td><div class=\"event-day \"><div class=\"event-date \">9</div><ul><li class=\"event-all-day event-#039be5\" style=\"background-color: #039be5\">\n\n\n\n                                        Holiday\t\t\t\t\t\t\t\t<span class=\"location\"></span></li></ul></div></td>\n                        <td><div class=\"event-day \"><div class=\"event-date \">11</div><ul><li class=\"event-all-day event-#039be5\" style=\"background-color: #039be5\">\n\n\n\n                                        Holiday\t\t\t\t\t\t\t\t<span class=\"location\"></span></li></ul></div></td>\n                        <td><div class=\"event-day \"><div class=\"event-date \">13</div><ul></ul></div></td>\n                        <td><div class=\"event-day \"><div class=\"event-date \">14</div><ul></ul></div></td></tr>\n                    <tr><td><div class=\"event-day \"><div class=\"event-date \">15</div><ul><li class=\"event-all-day event-#039be5\" style=\"background-color: #039be5\">\n\n\n\n                                        Holiday\t\t\t\t\t\t\t\t<span class=\"location\"></span></li></ul></div></td>\n                        <td><div class=\"event-day \"><div class=\"event-date \">17</div><ul><li class=\"event-all-day event-#039be5\" style=\"background-color: #039be5\">\n\n\n\n                                        Holiday\t\t\t\t\t\t\t\t<span class=\"location\"></span></li></ul></div></td>\n                        <td><div class=\"event-day \"><div class=\"event-date \">19</div><ul><li class=\"event-all-day event-#039be5\" style=\"background-color: #039be5\">\n\n\n\n                                        Holiday\t\t\t\t\t\t\t\t<span class=\"location\"></span></li></ul></div></td>\n                        <td><div class=\"event-day \"><div class=\"event-date \">23</div><ul><li class=\"event-all-day event-#039be5\" style=\"background-color: #039be5\">\n\n\n\n                                        Holiday\t\t\t\t\t\t\t\t<span class=\"location\"></span></li></ul></div></td>\n                        <td><div class=\"event-day \"><div class=\"event-date \">25</div><ul><li class=\"event-all-day event-#039be5\" style=\"background-color: #039be5\">\n\n\n\n                                        Holiday\t\t\t\t\t\t\t\t<span class=\"location\"></span></li></ul></div></td>\n                        <td><div class=\"event-day \"><div class=\"event-date \">27</div><ul></ul></div></td>\n                        <td><div class=\"event-day \"><div class=\"event-date \">28</div><ul></ul></div></td></tr></tbody>\n\n                <tfoot><tr><td colspan=\"100%\"><div class=\"legend\"><small>LEGEND&nbsp;&nbsp;&nbsp;&nbsp;</small>\n                                <span class=\"event-bullet event-#039be5\"></span> lawrence.paine95@gmail.com&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class=\"event-bullet event-#f4511e\"></span> Family&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;\n                            </div></td></tr></tfoot></table></div>\n\n\n        <div id=\"progress\" class=\"hide\"><svg viewBox=\"0 0 100 3\" preserveAspectRatio=\"none\" style=\"display: block; width: 100%;\"><path d=\"M 0,1.5 L 100,1.5\" stroke=\"#888888\" stroke-width=\"3\" fill-opacity=\"0\" style=\"stroke-dasharray: 100px, 100px; stroke-dashoffset: 1.08833px;\"></path></svg></div></div>\n\n\n    <div class=\"brightness abs-zero\" style=\"height: 100%; width: 38.2%;\"></div>\n\n    <div id=\"content\" class=\"abs-zero\" style=\"height: 100%; width: 38.2%;\"><div id=\"background-underlay-1\" class=\"abs-zero\" style=\"display: none; background: rgba(0, 0, 0, 0) none repeat scroll 0% 0%; z-index: 9;\"></div>\n        <div id=\"background-underlay-2\" class=\"abs-zero\" style=\"background: rgb(0, 0, 0) url(&quot;https://lh3.googleusercontent.com/lr/AFBm1_YuOOgjNEHC8twKYUC6qF2hA0nVQj4LXvEh3_j8wwy-9CGzBr6Bp1TLnkyJTM-gQ05NVLuATYuYmP1JRLfDguLY6DtPh5X1fWBVn3STwLB61CF0fNoLWw36xuixsfKSTbOuOR22rNaaD1OWmoscnlor2lky6z2Ukon8nQxRpCpSn6xSuWHCRWGTmd1YkW9gCnjYC7xlP1QrD-DQU_6Wn-u6sw2GMPzhpjA4VXssVZSbates0hYHa4F70WKmLyoL9MrxS9zYaWWXU2to7MCMTA9QVciyE3-DsYb_8knjaYPWTK5gN5Lj_FJt3OVLfLHxuxk0lJ9gUsFqE5_Vcei2RHOOi2MJI-QBw65TnaiA1mMXHo0xtjbMRgqzRiG1u_3Mt70RpdO7ONOW3A0aMk0fBFu8aM6-eFiCvgjo8HYKCfnzyRoL_RgLvtcAn__DOAAW6IeLUHl7qTn8Z9XogVw5vDp_LPEMXujsBPDrtE1Hux_bd7gMGv3f-_ToS3IuQIfVJhQ1vv4gkD9bJZPE4AjvLKUDWN7M9VIS7Yqzd62C1V7Tr_fQ6MhXrWqOpsQYf6U7CfQE3hf7TYdoT1NmM2r11qJ6Q69hJWsQJk9yufpcGAHGi-o8iDzIIuEnnGOYRnGANq49S4hW8frcncvQt-YMko9pnVULcY2ahKuS9HzaTFTwrqU6t9LSXDJ_JrQ-POjmLe9TGEHWt9MGhquWTDroI_wePHHGDSbKRrM-GbFrLRHi8WVyZYY5lZrS7nTCfpauHBJ2YfJTPMPRx-8IRotg7hiQJvyzmdEj2s7gI7FWcw5zLGcuDmyPKAZjMQO2sFG_1XIiWAiUUrg=w2048-h2048&quot;) no-repeat scroll center center / cover; z-index: 10; display: block;\"></div></div>\n\n    <div id=\"dak-banner\" style=\"position: fixed; bottom: 0; right: 0; text-align: right; height: 45px; background: #000; z-index:1000; \"><div style=\"padding: 10px 20px;\"><a href=\"https://dakboard.com/pricing\"><span style=\"opacity: .6; \">Powered by </span>&nbsp;&nbsp;\n                <img src=\"https://static.dakboard.com/assets/img/dakboard-logos/dakboard-color-horiz.svg\" style=\"height: 24px; opacity: .8\"></a></div></div>\n    <style>#rss { bottom: 40px; }\n\t\t#dak-banner { width: 100%; }\n\t\t}\n    </style></body></html>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
