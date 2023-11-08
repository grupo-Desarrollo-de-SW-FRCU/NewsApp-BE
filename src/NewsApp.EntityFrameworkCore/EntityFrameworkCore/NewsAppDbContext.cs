using Microsoft.EntityFrameworkCore;
using NewsApp.Reads;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.BackgroundJobs.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Volo.Abp.FeatureManagement.EntityFrameworkCore;
using Volo.Abp.Identity;
using Volo.Abp.Identity.EntityFrameworkCore;
using Volo.Abp.OpenIddict.EntityFrameworkCore;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;
using Volo.Abp.TenantManagement;
using Volo.Abp.TenantManagement.EntityFrameworkCore;
using NewsApp.Searches;
using NewsApp.Alerts;
using NewsApp.Notifications;
using NewsApp.Failures;
using NewsApp.Articles;
using NewsApp.Themes;

namespace NewsApp.EntityFrameworkCore;

[ReplaceDbContext(typeof(IIdentityDbContext))]
[ReplaceDbContext(typeof(ITenantManagementDbContext))]
[ConnectionStringName("Default")]
public class NewsAppDbContext :
    AbpDbContext<NewsAppDbContext>,
    IIdentityDbContext,
    ITenantManagementDbContext
{
    /* Add DbSet properties for your Aggregate Roots / Entities here. */

    #region Entities from the modules

    /* Notice: We only implemented IIdentityDbContext and ITenantManagementDbContext
     * and replaced them for this DbContext. This allows you to perform JOIN
     * queries for the entities of these modules over the repositories easily. You
     * typically don't need that for other modules. But, if you need, you can
     * implement the DbContext interface of the needed module and use ReplaceDbContext
     * attribute just like IIdentityDbContext and ITenantManagementDbContext.
     *
     * More info: Replacing a DbContext of a module ensures that the related module
     * uses this DbContext on runtime. Otherwise, it will use its own DbContext class.
     */

    //Identity
    public DbSet<IdentityUser> Users { get; set; }
    public DbSet<IdentityRole> Roles { get; set; }
    public DbSet<IdentityClaimType> ClaimTypes { get; set; }
    public DbSet<OrganizationUnit> OrganizationUnits { get; set; }
    public DbSet<IdentitySecurityLog> SecurityLogs { get; set; }
    public DbSet<IdentityLinkUser> LinkUsers { get; set; }
    public DbSet<IdentityUserDelegation> UserDelegations { get; set; }

    // Tenant Management
    public DbSet<Tenant> Tenants { get; set; }
    public DbSet<TenantConnectionString> TenantConnectionStrings { get; set; }

    #endregion

    public NewsAppDbContext(DbContextOptions<NewsAppDbContext> options)
        : base(options)
    {

    }

    #region DB-SETS
    // DbSets de entidades
    public DbSet<Article> Articles { get; set; }
    public DbSet<Read> Reads { get; set; }
    public DbSet<Search> Searches { get; set; }
    public DbSet<AlertSearch> AlertsThemes { get; set; }
    public DbSet<AlertSearch> AlertsSearches { get; set; }
    public DbSet<Failure> Errors { get; set; }
    public DbSet<NotificationApp> NotificationsApp { get; set; }
    public DbSet<NotificationMail> NotificationsMail { get; set; }
    #endregion
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        /* Include modules to your migration db context */

        builder.ConfigurePermissionManagement();
        builder.ConfigureSettingManagement();
        builder.ConfigureBackgroundJobs();
        builder.ConfigureAuditLogging();
        builder.ConfigureIdentity();
        builder.ConfigureOpenIddict();
        builder.ConfigureFeatureManagement();
        builder.ConfigureTenantManagement();

        #region builders entidades de dominio
        // Entidad Article
        builder.Entity<Article>(b =>
        {
            b.ToTable(NewsAppConsts.DbTablePrefix + "Articles", NewsAppConsts.DbSchema);
            b.ConfigureByConvention();
            b.Property(x => x.Author).IsRequired().HasMaxLength(100);
            b.Property(x => x.Title).IsRequired().HasMaxLength(100);
            b.Property(x => x.Description).IsRequired();
            b.Property(x => x.Url).IsRequired();
            b.Property(x => x.UrlToImage);
            b.Property(x => x.Language);
            b.Property(x => x.PublishedAt).IsRequired();
            b.Property(x => x.Content).IsRequired();


            // definiendo relacion con el tema que contiene al articulo
            b.HasOne<Theme>(a => a.Theme)
                .WithMany(s => s.Articles);
        });

        // Entidad Theme
        builder.Entity<Theme>(b => {
            b.ToTable(NewsAppConsts.DbTablePrefix + "Themes", NewsAppConsts.DbSchema);
            b.ConfigureByConvention();
            b.Property(x => x.Name).IsRequired().HasMaxLength(100);
            b.Ignore(x => x.KeyWords);

            // definiendo relacion para la lista de temas que el tema contiene
            b.HasMany<Theme>(t => t.Themes)
                .WithOne(t => t.ParentTheme);

            // definiendo relacion para la lista de articulos que el tema contiene
            b.HasMany<Article>(t => t.Articles)
                .WithOne(a => a.Theme);

            // definiendo relacion con una alerta del tema
            b.HasOne<AlertTheme>(t => t.AlertTheme)
                .WithOne(a => a.Theme);

            // definiendo relacion con el usuario
            //b.HasOne<IdentityUser>(t => t.User)
            //    .WithOne(a => a.Theme);
        });

        // Entidad busqueda
        builder.Entity<Search>(b =>
        {
            b.ToTable(NewsAppConsts.DbTablePrefix + "Searchs", NewsAppConsts.DbSchema);
            b.ConfigureByConvention();
            b.Property(x => x.SearchString).IsRequired().HasMaxLength(200);
            b.Property(x => x.StartDateTime).IsRequired();
            b.Property(x => x.ResultsAmount).IsRequired();
            b.Property(x => x.EndDateTime).IsRequired();
          //  b.Property(x =>x.Failure).IsRequired();
           // b.Property(x => x.User).IsRequired();
           // b.Property(x => x.Articles).IsRequired();


            //definiendo relacion con Failure
            b.HasOne<Failure>(s => s.Failure)
                .WithOne(f => f.Search)
                .HasForeignKey<Failure>(f => f.SearchOfFailureId);

            // definiendo relacion con Alert
            b.HasOne<AlertSearch>(s => s.AlertSearch)
                .WithOne(a => a.Search)
                .HasForeignKey<AlertSearch>(a => a.SearchOfAlertId);

            // definiendo relacion con Article
            b.HasMany<Article>(s => s.Articles);
                //.HasForeignKey<Alert>(f => f.SearchOfAlertId); creo que no lleva ForeignKey, por ser navegable solo a un lado
        });

        // Entidad AlertSearch
        builder.Entity<AlertSearch>(b =>
        {
            b.ToTable(NewsAppConsts.DbTablePrefix + "Alertas", NewsAppConsts.DbSchema);
            b.ConfigureByConvention();
           // b.Property(x => x.Search).IsRequired();
            b.Property(x => x.SearchOfAlertId).IsRequired();
         
           

            // definiendo relacion con Search
            b.HasOne<Search>(f => f.Search)
                .WithOne(s => s.AlertSearch)
                .HasForeignKey<AlertSearch>(f => f.SearchOfAlertId);
        });

        // Entidad AlertTheme
        builder.Entity<AlertTheme>(b =>
        {
            b.ToTable(NewsAppConsts.DbTablePrefix + "Alertas", NewsAppConsts.DbSchema);
            b.ConfigureByConvention();
            //b.Property(x => x.Theme).IsRequired();
            b.Property(x => x.ThemeOfAlertId).IsRequired();

            // definiendo relacion con Theme
            b.HasOne<Theme>(f => f.Theme)
            .WithOne(s => s.AlertTheme)
            .HasForeignKey<AlertTheme>(f => f.ThemeOfAlertId);

        });

        // Entidad Read
        builder.Entity<Read>(b => {
            b.ToTable(NewsAppConsts.DbTablePrefix + "Reads", NewsAppConsts.DbSchema);
            b.ConfigureByConvention(); 
            //...
        });

        // Entidad Error
        builder.Entity<Failure>(b =>
        {
            b.ToTable(NewsAppConsts.DbTablePrefix + "Errors",
                NewsAppConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props
            b.Property(x => x.ErrorDateTime).IsRequired();
            //b.Property(x => x.Exception).IsRequired().HasMaxLength(120);
            //definiendo relacion con Search
            b.HasOne<Search>(f => f.Search)
                .WithOne(s => s.Failure)
                .HasForeignKey<Failure>(f => f.SearchOfFailureId);
        });

        // Entidad NotificationApp
        builder.Entity<NotificationApp>(b =>
        {
            b.ToTable(NewsAppConsts.DbTablePrefix + "NotificationsApp",
                NewsAppConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props
            b.Property(x => x.Title).IsRequired().HasMaxLength(150);
            b.Property(x => x.DateTime).IsRequired();
            b.Property(x => x.Active).IsRequired();
            b.Property(x => x.UrlToImage);
        });

        // Entidad NotificationMail
        builder.Entity<NotificationMail>(b =>
        {
            b.ToTable(NewsAppConsts.DbTablePrefix + "NotificationsMail",
                NewsAppConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props
            b.Property(x => x.Title).IsRequired().HasMaxLength(150);
            b.Property(x => x.DateTime).IsRequired();
            b.Property(x => x.Message).IsRequired();
        });
        /* Configure your own tables/entities inside here */

        //builder.Entity<YourEntity>(b =>
        //{
        //    b.ToTable(NewsAppConsts.DbTablePrefix + "YourEntities", NewsAppConsts.DbSchema);
        //    b.ConfigureByConvention(); //auto configure for the base class props
        //    //...
        //});

        #endregion 
    }
}





