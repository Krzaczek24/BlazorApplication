using DynamicForms.Database.Models.Base;
using System.Collections.Generic;

namespace DynamicForms.Database.Models
{
    public class DbDictionary : DbBaseTable
    {
        public virtual string Name { get; set; }
        public virtual string Value { get; set; }
        public virtual string Description { get; set; }
        public virtual DbDictionary Parent { get; set; }
        public virtual ICollection<DbDictionary> Children { get; set; }
    }
}
