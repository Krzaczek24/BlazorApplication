using DynamicManager.Database.Models.Base;
using System.Collections.Generic;

namespace DynamicManager.Database.Models
{
    public class DbTag : DbBaseTable
    {
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual ICollection<DbFormTemplate> FormTemplates { get; set; }
        public virtual ICollection<DbFormField> FormFields { get; set; }
    }
}
