﻿using BlazorWorld.Core.Constants;
using BlazorWorld.Core.Entities.Configuration;
using BlazorWorld.Core.Repositories;
using BlazorWorld.Web.Client.Modules.Common.Services;
using BlazorWorld.Web.Client.Modules.Videos.Models;
using BlazorWorld.Web.Client.Shell;
using BlazorWorld.Web.Client.Shell.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using System.Threading.Tasks;

namespace BlazorWorld.Web.Client.Modules.Videos.Pages.Channel
{
    public partial class Details : ComponentBase
    {
        [Inject]
        protected INodeService NodeService { get; set; }
        [Inject]
        protected ISecurityService SecurityService { get; set; }
        [Inject]
        protected NavigationManager NavigationManager { get; set; }
        [Parameter]
        public string Slug { get; set; }
        [CascadingParameter]
        Task<AuthenticationState> AuthenticationStateTask { get; set; }
        private Models.Channel Channel { get; set; }
        private VideosModel Videos { get; set; }
        private bool CanEditChannel { get; set; } = false;
        private bool CanAddVideo { get; set; } = false;

        protected override async Task OnParametersSetAsync()
        {
            var node = await NodeService.GetBySlugAsync(
                Constants.VideosModule,
                Constants.ChannelType,
                Slug);
            Channel = Models.Channel.Create(node);
            var loggedInUserId = (await AuthenticationStateTask).LoggedInUserId();
            var createdBy = node.CreatedBy;
            CanEditChannel = await SecurityService.AllowedAsync(
                loggedInUserId,
                createdBy,
                Constants.VideosModule,
                Constants.ChannelType,
                Actions.Add
            );
            CanAddVideo = await SecurityService.AllowedAsync(
                loggedInUserId,
                createdBy,
                Constants.VideosModule,
                Constants.VideoType,
                Actions.Add
            );
            Videos = new VideosModel(NodeService)
            {
                NodeSearch = new NodeSearch()
                {
                    Module = Constants.VideosModule,
                    Type = Constants.VideoType,
                    OrderBy = new string[]
                    {
                            OrderBy.Weight,
                            OrderBy.Latest,
                            OrderBy.Title
                    }
                }
            };
            await Videos.InitAsync();
        }
    }
}
