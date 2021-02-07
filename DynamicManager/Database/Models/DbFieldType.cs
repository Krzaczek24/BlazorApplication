using DynamicManager.Database.Enums;
using DynamicManager.Database.Models.Base;
using System.Collections.Generic;

namespace DynamicManager.Database.Models
{
    public class DbFieldType : DbBaseTable
    {
        public virtual string Name { get; set; }
        public virtual string Title { get; set; }
        public virtual DbDataValueType DataValueType { get; set; }
        public virtual ICollection<DbFieldValidationRule> ValidationRules { get; set; }
    }
}
