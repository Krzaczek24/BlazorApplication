using System;

namespace DynamicManager.Database.Models.Base
{
    public abstract class DbBaseTable
    {
        public virtual int Id { get; set; }
        public virtual DateTime AddDate { get; set; }
        public virtual string AddLogin { get; set; }
        public virtual DateTime? ModifDate { get; set; }
        public virtual string ModifLogin { get; set; }
        public virtual bool IsActive { get; set; }
    }
}
