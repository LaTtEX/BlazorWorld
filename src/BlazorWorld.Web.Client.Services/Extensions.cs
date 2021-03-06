﻿using BlazorWorld.Web.Shared.Services;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorWorld.Web.Client.Services
{
    public static class Extensions
    {
        public static void AddBlazorWorldWebClientServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IWebConfigurationService, ClientConfigurationService>();
            serviceCollection.AddTransient<IWebGroupService, ClientGroupService>();
            serviceCollection.AddScoped<IWebHubClientService, ClientHubClientService>();
            serviceCollection.AddTransient<IWebInvitationService, ClientInvitationService>();
            serviceCollection.AddTransient<IWebMarkdownService, ClientMarkdownService>();
            serviceCollection.AddTransient<IWebMessageService, ClientMessageService>();
            serviceCollection.AddTransient<IWebMomentService, ClientMomentService>();
            serviceCollection.AddTransient<IWebNodeService, ClientNodeService>();
            serviceCollection.AddTransient<IWebSecurityService, ClientSecurityService>();
            serviceCollection.AddTransient<IWebTitleService, ClientTitleService>();
            serviceCollection.AddTransient<IWebToastrService, ClientToastrService>();
            serviceCollection.AddTransient<IWebUserService, ClientUserService>();
            serviceCollection.AddTransient<IWebVoteService, ClientVoteService>();
        }
    }
}
