﻿namespace IndexFund.Common.WebApi.Entities
{
    public class User
    {
        public Guid Id { get; set; }

        public string Firstname { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string PasswordHash { get; set; } = null!;

        public string Email { get; set; } = null!;

        public int RoleId { get; set; } = 1;

        public Role? Role { get; set; }
    }
}
