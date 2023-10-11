using Microsoft.EntityFrameworkCore;
using NewsApp.Articles;
using NewsApp.Reads;
using NewsApp.Errors;
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
using NewsApp.Busquedas;
using NewsApp.Alertas;
using Volo.Abp.EntityFrameworkCore.Modeling;
using static System.Runtime.InteropServices.JavaScript.JSType;
using NewsApp.Notifications;


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

    #region Entidades de dominio

    public DbSet<Busqueda> Busquedas { get; set; }

    public DbSet<Alerta> Alertas { get; set; }

    #endregion

    public NewsAppDbContext(DbContextOptions<NewsAppDbContext> options)
        : base(options)
    {

    }

    #region DB-SETS
    // DbSets de entidades
    public DbSet<Article> Articles { get; set; }
    public DbSet<Read> Reads { get; set; }
    public DbSet<Errors.Error> Errors { get; set; }
    public DbSet<NotificationMail> NotificationsApp { get; set; }
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

        builder.Entity<Article>(b =>
        {
            b.ToTable(NewsAppConsts.DbTablePrefix + "Articles", NewsAppConsts.DbSchema);
            b.ConfigureByConvention();


            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(NewsAppConsts.DbTablePrefix + "YourEntities", NewsAppConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});


            // Entidad busqueda
            builder.Entity<Busqueda>(b =>
            {
                b.ToTable(NewsAppConsts.DbTablePrefix + "Busquedas", NewsAppConsts.DbSchema);
                b.ConfigureByConvention();
                b.Property(x => x.Cadena_Buscada).IsRequired().HasMaxLength(100);
            });

            builder.Entity<Alerta>(b =>
            {
                b.ToTable(NewsAppConsts.DbTablePrefix + "Alertas", NewsAppConsts.DbSchema);
                b.ConfigureByConvention();
            });
        });


        builder.Entity<Read>(b => {
            b.ToTable(NewsAppConsts.DbTablePrefix + "Reads", NewsAppConsts.DbSchema);
            b.ConfigureByConvention(); 
            //...
        });

        builder.Entity<Errors.Error>(b =>
        {
            b.ToTable(NewsAppConsts.DbTablePrefix + "Errors",
                NewsAppConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props
            b.Property(x => x.Name).IsRequired().HasMaxLength(100);
            b.Property(x => x.ErrorCode).IsRequired().HasMaxLength(100);
            b.Property(x => x.Description).IsRequired().HasMaxLength(100);
            b.Property(x => x.ExceptionName).IsRequired().HasMaxLength(120);
        });

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

        }

}





