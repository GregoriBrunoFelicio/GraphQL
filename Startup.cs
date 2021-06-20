using GraphiQl;
using GraphQL.Project.Data;
using GraphQL.Project.GraphQL.Mutations;
using GraphQL.Project.GraphQL.Queries;
using GraphQL.Project.GraphQL.Schemas;
using GraphQL.Project.GraphQL.Types;
using GraphQL.Project.Interfaces;
using GraphQL.Project.Services;
using GraphQL.Server;
using GraphQL.Types;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace GraphQL.Project
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "GraphQL", Version = "v1" });
            });

            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<ProductType>();
            services.AddTransient<ProductQuery>();
            services.AddTransient<ProductMutation>();
            services.AddTransient<MenuType>();
            services.AddTransient<SubMenuType>();
            services.AddTransient<ReservationType>();
            services.AddTransient<MenuQuery>();
            services.AddTransient<SubMenuQuery>();
            services.AddTransient<ReservationQuery>();
            services.AddTransient<RootQuery>();
            services.AddTransient<RootMutation>();
            services.AddTransient<MenuMutation>();
            services.AddTransient<SubMenuMutation>();
            services.AddTransient<ReservationMutation>();
            services.AddTransient<MenuInputType>();
            services.AddTransient<SubMenuInputType>();
            services.AddTransient<ReservationInputType>();

            services.AddTransient<IMenuService, MenuServices>();
            services.AddTransient<ISubmenuService, SubMenuService>();
            services.AddTransient<IReservationService, ReservationService>();

            services.AddTransient<ISchema, RootSchema>();

            services.AddGraphQL(options => options.EnableMetrics = false).AddSystemTextJson();

            services.AddDbContext<GraphQlDbContext>(options => options.UseSqlServer(@"Data source= (localdb)\MSSQLLocalDB; Initial Catalog=CoffeShopDb; Integrated Security = true"));
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, GraphQlDbContext dbContext)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "GraphQL v1"));
            }

            dbContext.Database.EnsureCreated();
            app.UseGraphiQl("/graphql");
            app.UseGraphQL<ISchema>();
        }
    }
}
