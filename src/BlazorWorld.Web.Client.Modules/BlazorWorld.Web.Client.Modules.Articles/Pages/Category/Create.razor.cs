﻿using BlazorWorld.Web.Client.Modules.Common;
using BlazorWorld.Web.Shared.Models;
using BlazorWorld.Web.Shared.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Forms;
using System.Net;
using System.Threading.Tasks;

namespace BlazorWorld.Web.Client.Modules.Articles.Pages.Category
{
    [Authorize]
    public partial class Create : ComponentBase
    {
        [Inject]
        protected IWebNodeService NodeService { get; set; }
        [Inject]
        protected IWebSecurityService SecurityService { get; set; }
        [Inject]
        protected NavigationManager NavigationManager { get; set; }
        [CascadingParameter]
        Task<AuthenticationState> AuthenticationStateTask { get; set; }
        private Models.Category Category { get; set; } = new Models.Category()
        {
            Module = Constants.ArticlesModule
        };
        private string Name
        {
            get
            {
                return Category.Name;
            }
            set
            {
                Category.Name = value;
                Category.Slug = value.ToSlug();
            }
        }
        private string Weight
        {
            get
            {
                return Category.Weight > 0 ? Category.Weight.ToString() : string.Empty;
            }
            set
            {
                var weight = 0;
                int.TryParse(value, out weight);
                Category.Weight = weight;
            }
        }
        private string ValidationMessage { get; set; } = string.Empty;
        private EditContext _editContext;
        private ValidationMessageStore _messages;

        protected override void OnInitialized()
        {
            _editContext = new EditContext(Category);
            _messages = new ValidationMessageStore(_editContext);
            base.OnInitialized();
        }

        protected async Task SubmitAsync()
        {
            Category.Slug = Category.Name.ToSlug();
            var existingCategory = await NodeService.GetBySlugAsync(
                Constants.ArticlesModule,
                Constants.CategoryType,
                Category.Slug);

            if (existingCategory == null)
            {
                var contentActivity = new ContentActivity()
                {
                    Node = Category,
                    Message = $"Added a new article category: {Category.Name}."
                };
                var response = await NodeService.AddAsync(contentActivity);
                if (response.StatusCode == HttpStatusCode.OK)
                    NavigationManager.NavigateTo($"articles/{Category.Slug}");
                else
                    ValidationMessage = "Unable to save.";
            }
            else
            {
                ValidationMessage = "A similar name already exists.";
            }
        }
    }
}
