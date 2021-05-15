using DynamicForms.Database.Models.Base;
using System.Collections.Generic;

namespace DynamicForms.Database.Models
{
    public class DbFormField : DbBaseTable
    {
        public virtual string Name { get; set; }
        public virtual string Title { get; set; }
        public virtual string Code { get; set; }
        public virtual DbFormTemplate FormTemplate { get; set; }
        public virtual DbFieldType FieldType { get; set; }
        public virtual DbFieldValidationRule FieldValidationRule { get; set; }
        public virtual DbTag Tag { get; set; }
        public virtual ICollection<DbFormData> FieldData { get; set; }
    }
}
