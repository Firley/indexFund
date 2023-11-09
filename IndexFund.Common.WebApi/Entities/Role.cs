using System.ComponentModel.DataAnnotations;

namespace IndexFund.Common.WebApi.Entities
{
    public class Role
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;
    }
}