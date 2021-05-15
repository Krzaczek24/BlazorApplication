using DynamicForms.Database.Enums;
using DynamicForms.Database.Models.Base;
using System.Collections.Generic;

namespace DynamicForms.Database.Models
{
    public class DbFieldType : DbBaseTable
    {
        public virtual string Name { get; set; }
        public virtual string Title { get; set; }
        public virtual DbDataValueType DataValueType { get; set; }
        public virtual ICollection<DbFieldValidationRule> ValidationRules { get; set; }
    }
}
