#pragma checksum "D:\Users\Bdk11\Desktop\Emir\WebApiProjectEmir\EmirhanAvci.Project.WebApi\EmirhanAvci.Project.UI\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c26420e7abe6be25a41139c722d1a3a2223a6a8"
// <auto-generated/>
#pragma warning disable 1591
namespace EmirhanAvci.Project.UI.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 3 "D:\Users\Bdk11\Desktop\Emir\WebApiProjectEmir\EmirhanAvci.Project.WebApi\EmirhanAvci.Project.UI\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Users\Bdk11\Desktop\Emir\WebApiProjectEmir\EmirhanAvci.Project.WebApi\EmirhanAvci.Project.UI\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Users\Bdk11\Desktop\Emir\WebApiProjectEmir\EmirhanAvci.Project.WebApi\EmirhanAvci.Project.UI\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Users\Bdk11\Desktop\Emir\WebApiProjectEmir\EmirhanAvci.Project.WebApi\EmirhanAvci.Project.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Users\Bdk11\Desktop\Emir\WebApiProjectEmir\EmirhanAvci.Project.WebApi\EmirhanAvci.Project.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Users\Bdk11\Desktop\Emir\WebApiProjectEmir\EmirhanAvci.Project.WebApi\EmirhanAvci.Project.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Users\Bdk11\Desktop\Emir\WebApiProjectEmir\EmirhanAvci.Project.WebApi\EmirhanAvci.Project.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Users\Bdk11\Desktop\Emir\WebApiProjectEmir\EmirhanAvci.Project.WebApi\EmirhanAvci.Project.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Users\Bdk11\Desktop\Emir\WebApiProjectEmir\EmirhanAvci.Project.WebApi\EmirhanAvci.Project.UI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Users\Bdk11\Desktop\Emir\WebApiProjectEmir\EmirhanAvci.Project.WebApi\EmirhanAvci.Project.UI\_Imports.razor"
using EmirhanAvci.Project.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Users\Bdk11\Desktop\Emir\WebApiProjectEmir\EmirhanAvci.Project.WebApi\EmirhanAvci.Project.UI\_Imports.razor"
using EmirhanAvci.Project.UI.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Users\Bdk11\Desktop\Emir\WebApiProjectEmir\EmirhanAvci.Project.WebApi\EmirhanAvci.Project.UI\_Imports.razor"
using EmirhanAvci.Project.EntityLayer.Dtos.ProductDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Users\Bdk11\Desktop\Emir\WebApiProjectEmir\EmirhanAvci.Project.WebApi\EmirhanAvci.Project.UI\_Imports.razor"
using EmirhanAvci.Project.EntityLayer.Dtos.BrandDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\Users\Bdk11\Desktop\Emir\WebApiProjectEmir\EmirhanAvci.Project.WebApi\EmirhanAvci.Project.UI\_Imports.razor"
using EmirhanAvci.Project.EntityLayer.Dtos.ColorDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\Users\Bdk11\Desktop\Emir\WebApiProjectEmir\EmirhanAvci.Project.WebApi\EmirhanAvci.Project.UI\_Imports.razor"
using EmirhanAvci.Project.EntityLayer.Dtos.OrderDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\Users\Bdk11\Desktop\Emir\WebApiProjectEmir\EmirhanAvci.Project.WebApi\EmirhanAvci.Project.UI\_Imports.razor"
using EmirhanAvci.Project.EntityLayer.Dtos.OfferDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\Users\Bdk11\Desktop\Emir\WebApiProjectEmir\EmirhanAvci.Project.WebApi\EmirhanAvci.Project.UI\_Imports.razor"
using EmirhanAvci.Project.EntityLayer.Dtos.CategoryDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "D:\Users\Bdk11\Desktop\Emir\WebApiProjectEmir\EmirhanAvci.Project.WebApi\EmirhanAvci.Project.UI\_Imports.razor"
using EmirhanAvci.Project.SharedLayer.Utilities.Results.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Users\Bdk11\Desktop\Emir\WebApiProjectEmir\EmirhanAvci.Project.WebApi\EmirhanAvci.Project.UI\Pages\Login.razor"
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Login</h3>\r\n<hr><br>\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 8 "D:\Users\Bdk11\Desktop\Emir\WebApiProjectEmir\EmirhanAvci.Project.WebApi\EmirhanAvci.Project.UI\Pages\Login.razor"
                  User

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 8 "D:\Users\Bdk11\Desktop\Emir\WebApiProjectEmir\EmirhanAvci.Project.WebApi\EmirhanAvci.Project.UI\Pages\Login.razor"
                                        Submit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n    ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "form-group");
                __builder2.AddMarkupContent(9, "<label for=\"Email\">Email:</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(10);
                __builder2.AddAttribute(11, "class", "from-control");
                __builder2.AddAttribute(12, "id", "Email");
                __builder2.AddAttribute(13, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 12 "D:\Users\Bdk11\Desktop\Emir\WebApiProjectEmir\EmirhanAvci.Project.WebApi\EmirhanAvci.Project.UI\Pages\Login.razor"
                                                                User.Username

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => User.Username = __value, User.Username))));
                __builder2.AddAttribute(15, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => User.Username));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\r\n        ");
                __Blazor.EmirhanAvci.Project.UI.Pages.Login.TypeInference.CreateValidationMessage_0(__builder2, 17, 18, 
#nullable restore
#line 13 "D:\Users\Bdk11\Desktop\Emir\WebApiProjectEmir\EmirhanAvci.Project.WebApi\EmirhanAvci.Project.UI\Pages\Login.razor"
                                ()=>User.Username

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\r\n    ");
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", "form-group");
                __builder2.AddMarkupContent(22, "<label for=\"Password\">Password:</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(23);
                __builder2.AddAttribute(24, "class", "form-control");
                __builder2.AddAttribute(25, "id", "Password");
                __builder2.AddAttribute(26, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 17 "D:\Users\Bdk11\Desktop\Emir\WebApiProjectEmir\EmirhanAvci.Project.WebApi\EmirhanAvci.Project.UI\Pages\Login.razor"
                                                                   User.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => User.Password = __value, User.Password))));
                __builder2.AddAttribute(28, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => User.Password));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(29, "\r\n        ");
                __Blazor.EmirhanAvci.Project.UI.Pages.Login.TypeInference.CreateValidationMessage_1(__builder2, 30, 31, 
#nullable restore
#line 18 "D:\Users\Bdk11\Desktop\Emir\WebApiProjectEmir\EmirhanAvci.Project.WebApi\EmirhanAvci.Project.UI\Pages\Login.razor"
                                ()=>User.Password

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n    ");
                __builder2.AddMarkupContent(33, "<div class=\"row\"><input class=\"btn btn-success\" type=\"submit\" value=\"Login\"></div>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 24 "D:\Users\Bdk11\Desktop\Emir\WebApiProjectEmir\EmirhanAvci.Project.WebApi\EmirhanAvci.Project.UI\Pages\Login.razor"
       
    private EmirhanAvci.Project.EntityLayer.Authentication.Models.LoginModel User = new();

    private async Task Submit()
    {
        var client = ClientFactory.CreateClient();

        var response = await client.PostAsJsonAsync("http://localhost:5001/Login", User);

        if (response.IsSuccessStatusCode)
        {
            string token = await response.Content.ReadAsStringAsync();
            await Storage.SetAsync("token", token);
        }
        NavManager.NavigateTo("product");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProtectedLocalStorage Storage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpClientFactory ClientFactory { get; set; }
    }
}
namespace __Blazor.EmirhanAvci.Project.UI.Pages.Login
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
