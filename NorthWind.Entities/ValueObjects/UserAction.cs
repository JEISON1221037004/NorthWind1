namespace NorthWind.Entities.ValueObjects
{
    public class UserAction(string user, string description)
    {
        public DateTime CreateDateTime { get; } = DateTime.Now;
        public string user => user;
        public string description => description;
    }
}
