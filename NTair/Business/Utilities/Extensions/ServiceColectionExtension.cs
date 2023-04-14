using Core.Utilities.Security.Encryption;
using Core.Utilities.Security.JWT;
using Token = Core.Utilities.Security.JWT;

namespace Business.Utilities.Extensions;

public static class ServiceColectionExtension
{
    public static IServiceCollection AddBusinessConfiguration(this IServiceCollection services, IConfiguration configuration)
    {
        Token.TokenOptions tokenOptions=configuration.GetSection("TokenOptions").Get<Token.TokenOptions>();
        //services.AddControllers().AddFluentValidation(opt =>
        //{
        //    opt.ImplicitlyValidateChildProperties = true;
        //    opt.ImplicitlyValidateRootCollectionElements = true;
        //    opt.RegisterValidatorsFromAssembly(Assembly.GetExecutingAssembly());
        //});

        services.AddFluentValidationAutoValidation(opt => opt.DisableDataAnnotationsValidation = false).AddFluentValidationClientsideAdapters();
        services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

        services.AddScoped<IProductRepository, ProductRepository>();
        services.AddScoped<IProductService, ProductService>();
        services.AddScoped<IAuthService, AuthService>();
        services.AddScoped<ITokenHelper, JWTHelper>();

        services.AddAuthentication().AddJwtBearer(opt =>
        {
            opt.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidateAudience=true,
                ValidateLifetime= true,
                ValidateIssuerSigningKey = true,
                ValidIssuer=tokenOptions.Issuer,
                ValidAudience=tokenOptions.Audience,
                IssuerSigningKey=SecurityKeyHelper.CreateSecurityKey(tokenOptions.SecurityKey)
            };
        });
        services.AddDbContext<AppDbContext>(opt =>
        {
            opt.UseSqlServer(configuration.GetConnectionString("Default"));
        });
        services.AddIdentity<AppUser, IdentityRole>().AddDefaultTokenProviders().AddEntityFrameworkStores<AppDbContext>();
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        return services;
    }
}
