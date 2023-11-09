using System.ComponentModel.DataAnnotations;

namespace IndexFund.Common.WebApi.Models
{
    public class FundUserCreditensialsDTO
    {
        [EmailAddress]
        public string Email { get; set; }

        [MinLength(6), MaxLength(64)]
        public string Password { get; set; }
    }
}
