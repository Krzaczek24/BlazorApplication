using DynamicManager.Database.Models.Base;

namespace DynamicManager.Database.Models
{
    public class DbForm : DbBaseTable
    {
        public virtual string Title { get; set; }
    }
}
