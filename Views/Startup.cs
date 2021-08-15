using Business;
using Business.Contract;
using Entities;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Repository;
using Repository.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Views
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddDbContext<FlagContextDB>(options => options.UseSqlServer(Configuration.GetConnectionString("SlackhRandomizer"),
                b => b.MigrationsAssembly("Repository")
                ));

            services.AddControllersWithViews().AddRazorRuntimeCompilation();
            services.AddRazorPages();

            //Seed
            services.AddTransient<ISeedOption, SeedRepository>();
            services.AddTransient<ISeedBusiness, SeedBusiness>();

            //Pass
            services.AddTransient<IPassOptions, PassRepository>();
            services.AddTransient<IPassBusiness, PassBusiness>();

            //Bosses
            services.AddTransient<IBossesOptions, BossesRepository>();
            services.AddTransient<IBossesBusiness, BossesBusiness>();

            //CharactersRandom
            services.AddTransient<ICharacterRandomOptions, CharacterRandomRepository>();
            services.AddTransient<ICharacterRandomBusiness, CharacterRandomBusiness>();

            //CharacterSpell
            services.AddTransient<ICharacterSpellOptions, CharacterSpellRepository>();
            services.AddTransient<ICharacterSpellBusiness, CharacterSpellBusiness>();

            //CharacterStart
            services.AddTransient<ICharacterStartOptions, CharacterStartRepository>();
            services.AddTransient<ICharacterStartBusiness, CharacterStartBusiness>();

            //Chest
            services.AddTransient<IChestOptions, ChestRepository>();
            services.AddTransient<IChestBusiness, ChestBusiness>();

            //EncounterDToggle
            services.AddTransient<IEncounterToggleOptions, EncounterToggleRepository>();
            services.AddTransient<IEncounterToggleBusiness, EncounterToggleBusiness>();

            //EncounterDrop
            services.AddTransient<IEncounterDropOptions, EncounterDropRepository>();
            services.AddTransient<IEncounterDropBusiness, EncounterDropBusiness>();

            //Glitch
            services.AddTransient<IGlitchOptions, GlitchRepository>();
            services.AddTransient<IGlitchBusiness, GlitchBusiness>();

            //ItemKey
            services.AddTransient<IItemKeyOptions, ItemKeyRepository>();
            services.AddTransient<IItemKeyBusiness, ItemKeyBusiness>();

            //Junk
            services.AddTransient<IJunkOptions, JunkRepository>();
            services.AddTransient<IJunkBusiness, JunkBusiness>();

            //ObjectiveMode
            services.AddTransient<IObjectiveModeOptions, ObjectiveModeRepository>();
            services.AddTransient<IObjectiveBusiness, ObjectiveBusiness>();

            //ObjectiveCustom
            services.AddTransient<IObjectiveCustomOptions, ObjectiveCustomRepository>();
            services.AddTransient<IObjectiveCustomBusiness, ObjectiveCustomBusiness>();

            //Other
            services.AddTransient<IOtherOptions, OtherRepository>();
            services.AddTransient<IOtherBusiness, OtherBusiness>();

            //OtherStarter
            services.AddTransient<IOtherStarterOptions, OtherStarterRepository>();
            services.AddTransient<IOtherStarterBusiness, OtherStarterBusiness>();

            //Prefixe
            services.AddTransient<IPrefixeOptions, PrefixeRepository>();
            services.AddTransient<IPrefixeBusiness, PrefixeBusiness>();

            //Permadeth
            services.AddTransient<IPermadethOption, PermadeathRepository>();
            services.AddTransient<IPermadeathBusiness, PermadeathBusiness>();

            //PresetFlag
            services.AddTransient<IPresetFlagOption, PresetFlagRepository>();
            services.AddTransient<IPresetFlagBusiness, PresetFlagBusiness>();

            //Shop
            services.AddTransient<IShopOptions, ShopRepository>();
            services.AddTransient<IShopBusiness, ShopBusiness>();

            //Sparse
            services.AddTransient<ISparseOption, SparseRepository>();
            services.AddTransient<ISparseBusiness, SparseBusiness>();

            //AddinDb
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, FlagContextDB context)
        {
            context.Database.Migrate();

            //Test Addin Db at start
            SeedRepository seedRepository = new SeedRepository(context);
            seedRepository.AddDicoInDB();

            //if (env.IsDevelopment())
            //{
            app.UseDeveloperExceptionPage();
            // }
            //else
            //{
            //    app.UseExceptionHandler("/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            //     app.UseHsts();
            //}

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
