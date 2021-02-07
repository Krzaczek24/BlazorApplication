using DynamicManager.Database.Models.Base;

namespace DynamicManager.Database.Models
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
