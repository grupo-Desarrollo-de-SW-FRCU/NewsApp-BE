using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Identity;
using NewsApp.News;
using NewsApp.Themes;
using Volo.Abp.Domain.Repositories;

namespace NewsApp.Articles;
/* ARTICULOS QUE SE GUARDAN EN LA BD*/
public class ArticleAppService : NewsAppAppService, IArticleAppService
{
    private readonly IRepository<Article, int> _articleRepository;
    private readonly IRepository<Theme, int> _themeRepository;
    private readonly UserManager<Volo.Abp.Identity.IdentityUser> _userManager;


    public ArticleAppService(IRepository<Article, int> articleRepository, UserManager<Volo.Abp.Identity.IdentityUser> userManager, IRepository<Theme, int> themeRepository)
    {
        _articleRepository = articleRepository;
        _userManager = userManager;
        _themeRepository = themeRepository;
    }

    //public async Task<ArticleDto> SaveArticleAsync(CreateUpdateNewsDto input, int themeId)
    //{
    //    var userGuid = CurrentUser.Id.GetValueOrDefault();

    //    var identityUser = await _userManager.FindByIdAsync(userGuid.ToString());

    //    var theme = await _themeRepository.GetAsync(themeId);
        
    //    Article article = ObjectMapper.Map<CreateUpdateNewsDto,Article>(input);

    //    article = await _articleRepository.InsertAsync(article, autoSave: true);

    //    theme.Articles.Add(article);

    //    return ObjectMapper.Map<Article, ArticleDto>(article);
    //}

    public async Task<ArticleDto> SaveArticleAsync(CreateUpdateNewsDto input, int themeId)
    {
        Article article = null;

        var userGuid = CurrentUser.Id.GetValueOrDefault();

        var identityUser = await _userManager.FindByIdAsync(userGuid.ToString());

        var theme = await _themeRepository.GetAsync(themeId);

        // Article article = ObjectMapper.Map<CreateUpdateNewsDto, Article>(input);

        article = new Article 
        {
            Author = input.Author,
            Title = input.Title,
            Description = input.Description,
            Url = input.Url,
            UrlToImage = input.UrlToImage,
            PublishedAt = input.PublishedAt,
            SourceName = input.SourceName,
            Content = input.Content,
            Language = input.Language,
            Theme = theme            
        };

        article = await _articleRepository.InsertAsync(article, autoSave: true);

        theme.Articles.Add(article);

        return ObjectMapper.Map<Article, ArticleDto>(article);
    }
}