using DynamicForms.Database.Models.Base;

namespace DynamicForms.Database.Models
{
    public class DbFieldValidationRule : DbBaseTable
    {
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual string Pattern { get; set; }
        public virtual string Message { get; set; }
        public virtual DbFieldType FieldType { get; set; }
    }
}
