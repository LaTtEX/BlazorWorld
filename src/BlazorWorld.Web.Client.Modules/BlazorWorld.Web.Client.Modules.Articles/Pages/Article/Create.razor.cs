﻿using BlazorWorld.Web.Client.Shell;
using BlazorWorld.Web.Shared.Models;
using BlazorWorld.Web.Shared.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Forms;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorWorld.Web.Client.Modules.Articles.Pages.Article
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
        [Parameter]
        public string CategorySlug { get; set; }
        [CascadingParameter]
        Task<AuthenticationState> AuthenticationStateTask { get; set; }
        private IEnumerable<Models.Category> Categories { get; set; } = new List<Models.Category>();
        private Models.Article Article { get; set; } = new Models.Article();
        private string Weight
        {
            get
            {
                return Article.Weight > 0 ? Article.Weight.ToString() : string.Empty;
            }
            set
            {
                var weight = 0;
                int.TryParse(value, out weight);
                Article.Weight = weight;
            }
        }
        private string ValidationMessage { get; set; } = string.Empty;
        private EditContext _editContext;
        private ValidationMessageStore _messages;

        protected override void OnInitialized()
        {
            _editContext = new EditContext(Article);
            _messages = new ValidationMessageStore(_editContext);
            base.OnInitialized();
        }

        protected override async Task OnParametersSetAsync()
        {
            var category = await NodeService.GetBySlugAsync(Constants.ArticlesModule, Constants.CategoryType, CategorySlug);
            Article.CategoryId = category.Id;
        }

        protected async Task SubmitAsync()
        {
            Article.Slug = Article.Title.ToSlug();
            var existingArticle = await NodeService.GetBySlugAsync(
                Constants.ArticlesModule,
                Constants.ArticleType,
                Article.Slug,
                true);

            if (existingArticle == null)
            {
                var contentActivity = new ContentActivity()
                {
                    Node = Article,
                    Message = $"Added a new article: {Article.Title}."
                };
                await NodeService.AddAsync(contentActivity);
                NavigationManager.NavigateTo($"article/{Article.Slug}");
            }
            else
            {
                ValidationMessage = "A similar title already exists.";
            }
        }
    }
}
