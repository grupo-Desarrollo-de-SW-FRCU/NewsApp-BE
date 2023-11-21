using System;
using System.Threading.Tasks;
using NewsApp.Themes;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Identity;

namespace NewsApp;

public class NewsAppTestDataSeedContributor : IDataSeedContributor, ITransientDependency
{
    private readonly IRepository<Theme, int> _themeRepository;
    private readonly IdentityUserManager _identityUserManager;


    public NewsAppTestDataSeedContributor(IRepository<Theme, int> themeRepository, IdentityUserManager identityUserManager)
    {
        _themeRepository = themeRepository;
        _identityUserManager = identityUserManager;
    }

    public async Task SeedAsync(DataSeedContext context)
    {
        // Add User        
        IdentityUser identityUser = new IdentityUser(Guid.Parse("2e701e62-0953-4dd3-910b-dc6cc93ccb0d"), "admin", "admin@abp.io");
        await _identityUserManager.CreateAsync(identityUser, "1q2w3E*");
        // await _identityUserManager.AddToRoleAsync(identityUser, "Admin");

        // Add Themes
        await _themeRepository.InsertAsync(new Theme { Name = "Primer tema", User = identityUser });

        await _themeRepository.InsertAsync(new Theme { Name = "Segundo tema", User = identityUser });

        await _themeRepository.InsertAsync(new Theme { Name = "Tercer tema", User = identityUser });
    }
}
