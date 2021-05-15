using DynamicForms.Database.Models.Base;

namespace DynamicForms.Database.Models
{
    public class DbUser : IUser
    {
        public virtual string UserName { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
    }
}
