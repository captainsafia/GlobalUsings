﻿#pragma checksum "/Users/captainsafia/Verifications/GlobalUsings/Pages/Index.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "76ebed78f67c8a88967d524b89d43d743d96efab7f7da705833c4000a3df2952"
// <auto-generated/>
#pragma warning disable 1591
namespace GlobalUsings.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Hello, world!</h1>\r\n\r\nWelcome to your new app.\r\n\r\n");
            __builder.OpenElement(1, "SurveyPrompt");
            __builder.AddAttribute(2, "Title", "How is Blazor working for you?");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591