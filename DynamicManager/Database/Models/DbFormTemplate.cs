using DynamicManager.Database.Models.Base;
using System.Collections.Generic;

namespace DynamicManager.Database.Models
{
    public class DbFormTemplate : DbBaseTable
    {
        public virtual string Name { get; set; }
        public virtual string Title { get; set; }
        public virtual DbTag Tag { get; set; }
        public virtual ICollection<DbFormField> FormFields { get; set; }
        public virtual ICollection<DbForm> Forms { get; set; }
    }
}
