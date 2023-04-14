using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Reflection;
using System.Text;
using WebApiConfig.DAL;
using WebApiConfig.DAL.Repositories;
using WebApiConfig.Entities;

namespace WebApiConfig
{
    public static class Configuration
    {
        

        public static IServiceCollection ServiceConfiguration(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddControllers().AddFluentValidation(opt =>
            {
                opt.ImplicitlyValidateChildProperties = true;
                opt.ImplicitlyValidateRootCollectionElements = true;
                opt.RegisterValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            });
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
          
           services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddControllers().AddFluentValidation(opt =>
            {
                opt.ImplicitlyValidateChildProperties = true;
                opt.ImplicitlyValidateRootCollectionElements = true;
                opt.RegisterValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            });
            
            services.AddScoped<IUnitOfWork, UnitOfWork>();



            TokenOption tokenOption = configuration.GetSection("TokenOptions").Get<TokenOption>();

            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("Default"));
            });
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            
            services.AddIdentity<AppUser, IdentityRole>()
                .AddDefaultTokenProviders()
                .AddEntityFrameworkStores<AppDbContext>();
            services.AddAuthentication(opt =>
            {
                opt.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
                opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(opt =>
            {
                opt.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = tokenOption.Issuer,
                    ValidAudience = tokenOption.Audience,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(tokenOption.SecurityKey))
                };
            });
            return services;
        }
    }
}
