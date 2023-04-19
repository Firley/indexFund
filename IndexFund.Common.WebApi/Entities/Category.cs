using System.ComponentModel.DataAnnotations;

namespace IndexFund.Common.WebApi.Entities
{
    public class Category
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; } = null!;
    }
}