using System;

namespace DynamicManager.Database.Models
{
    public abstract class DbTableBase
    {
        public int Id { get; set; }
        public DateTime AddDate { get; set; }
        public string AddLogin { get; set; }
        public DateTime? ModifDate { get; set; }
        public string ModifLogin { get; set; }
        public bool Active { get; set; }
    }
}
