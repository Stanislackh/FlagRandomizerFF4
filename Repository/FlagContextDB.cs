using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Entities;

namespace Repository
{
    public class FlagContextDB : DbContext
    {
        private readonly IConfiguration config;

        public FlagContextDB()
        {

        }

        public FlagContextDB(IConfiguration _config, DbContextOptions<FlagContextDB> options) : base(options)
        {
            config = _config;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //optionsBuilder.UseLazyLoadingProxies().UseSqlServer(config.GetConnectionString("SlackhRandomizer"));
                optionsBuilder.UseLazyLoadingProxies().UseSqlServer(@"Server=(localdb)\\mssqllocaldb;Database=SlackhDb;Trusted_Connection=True;MultipleActiveResultSets=true");
            }
        }

        // Entites
        public virtual DbSet<Boss> Bosses { get; set; }
        public virtual DbSet<CharacterRandom> CharacterRandoms { get; set; }
        public virtual DbSet<CharacterSpell> CharacterSpells { get; set; }
        public virtual DbSet<CharacterStart> CharacterStarts { get; set; }
        public virtual DbSet<Chest> Chests { get; set; }
        public virtual DbSet<EncounterDrop> EncounterDrops { get; set; }
        public virtual DbSet<EncounterToggle> EncounterToggles { get; set; }
        public virtual DbSet<Glitch> Glitches { get; set; }
        public virtual DbSet<ItemKey> ItemKeys { get; set; }
        public virtual DbSet<Junk> Junks { get; set; }
        public virtual DbSet<ObjectiveCustom> ObjectiveCustoms { get; set; }
        public virtual DbSet<ObjectiveMode> ObjectiveModes { get; set; }
        public virtual DbSet<Other> Others { get; set; }
        public virtual DbSet<OtherStarter> OtherStarters { get; set; }
        public virtual DbSet<Pass> Passes { get; set; }
        public virtual DbSet<Permadeath> Permadeaths { get; set; }
        public virtual DbSet<Prefixe> Prefixes { get; set; }
        public virtual DbSet<PresetFlag> PresetFlags { get; set; }
        public virtual DbSet<Seed> Seeds { get; set; }
        public virtual DbSet<Shop> Shops { get; set; }
        public virtual DbSet<Sparse> Sparses { get; set; }
        
    }
}
