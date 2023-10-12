using Domain.Common;

namespace Domain.Entities.Users
{
    public class User : AuditableEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }   
}
