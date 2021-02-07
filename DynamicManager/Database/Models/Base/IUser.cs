namespace DynamicManager.Database.Models.Base
{
    public interface IUser
    {
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
