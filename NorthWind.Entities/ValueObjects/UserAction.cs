
namespace NorthWind.Entities.ValueObjects
{
    public class UserAction(string user, string description)
    public class UserAction(string User, string Description)
    {
        public DateTime CreateDateTime { get; } = DateTime.Now;
        public string user => user;
        public string description => description;
        public string User => User;
        public string Description => Description;
    }
}
