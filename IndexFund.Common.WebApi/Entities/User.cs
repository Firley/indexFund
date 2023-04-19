namespace IndexFund.Common.WebApi.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string Firstname { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public int RoleId { get; set; } = 1;
        public Role? Role { get; set; }
    }
}
