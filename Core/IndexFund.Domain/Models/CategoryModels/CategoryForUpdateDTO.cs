using System.ComponentModel.DataAnnotations;

namespace IndexFund.Domain.Models.CategoryModels
{
    public class CategoryForUpdateDTO
    {
        [Required(ErrorMessage = "You should provide a name value.")]
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;
    }
}
