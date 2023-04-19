using System.ComponentModel.DataAnnotations;

namespace IndexFund.Common.WebApi.Models
{
    public class CategoryForCreationDTO
    {
        [Required(ErrorMessage = "You should provide a name value.")]
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;
    }
}
