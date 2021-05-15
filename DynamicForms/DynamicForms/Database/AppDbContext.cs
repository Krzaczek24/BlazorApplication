using DynamicForms.Database.Mapping;
using DynamicForms.Database.Models;
using DynamicForms.Database.Models.Base;
using DynamicForms.Shared.Tools;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DynamicForms.Database
{
    public class AppDbContext : DbContext
    {
        public virtual DbSet<DbUser> Users { get; set; }
        public virtual DbSet<DbDictionary> Dictionaries { get; set; }
        public virtual DbSet<DbTag> Tags { get; set; }
        public virtual DbSet<DbFieldType> FieldTypes { get; set; }
        public virtual DbSet<DbFieldValidationRule> FieldValidationRules { get; set; }
        public virtual DbSet<DbFormTemplate> FormTemplates { get; set; }
        public virtual DbSet<DbFormField> FormFields { get; set; }
        public virtual DbSet<DbForm> Forms { get; set; }
        public virtual DbSet<DbFormData> FormData { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new DbUserMap());

            var tablesToMap = AssemblyHelper.GetAllNonAbstractSubclasses(typeof(DbBaseTable));
            foreach (dynamic configuration in GetConfigurations(tablesToMap, modelBuilder))
            {
                modelBuilder.ApplyConfiguration(configuration);
            }
        }

        private dynamic GetConfigurations(List<Type> tablesToMap, ModelBuilder modelBuilder)
        {
            var configurations = new List<dynamic>();
            var method = modelBuilder.GetType().GetMethods().Where(m => m.Name == "Entity" && m.IsGenericMethod && (m.ReturnType != m.ReflectedType)).Single();

            foreach (Type tableType in tablesToMap)
            {
                string mapTypeFullName = tableType.FullName.Replace("Models", "Mapping") + "Map";
                Type mapType = GetType().Assembly.GetType(mapTypeFullName);
                var builder = method.MakeGenericMethod(tableType).Invoke(modelBuilder, null);
                dynamic configurtionInstance = Activator.CreateInstance(mapType, builder);
                configurations.Add(configurtionInstance);
            }

            return configurations;
        }
    }
}
