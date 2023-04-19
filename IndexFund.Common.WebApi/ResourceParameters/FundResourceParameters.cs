using IndexFund.Common.WebApi.Entities;
using System.Globalization;

namespace IndexFund.Common.WebApi.ResourceParameters
{
    public class FundResourceParameters
    {
        const int maxPageSize = 10;
        const int minPageNumber = 1;
        private string[] allowedOrderByColumnNames = {nameof(Fund.Id),nameof(Fund.Name), nameof(Fund.Category), nameof(Fund.ShortName),};

        public string? CategoryName { get; set; }
        public string? SearchQuery { get; set; }

        private string? orderBy;
        public string? OrderBy
        {
            get { return orderBy; }
            set 
            {
                var valueUpper = value?.ToUpper();
                orderBy = allowedOrderByColumnNames.Select(i => i.ToUpper()).Contains(valueUpper) ? orderBy = valueUpper : orderBy = nameof(Fund.Name).ToUpper();
            }
        }
        public SortDirection SortDirection { get; set; } = SortDirection.ASC;
        private int _pageNumber = 1;
        public int PageNumber
        {
            get => _pageNumber;
            set => _pageNumber = (value < minPageNumber ? minPageNumber : value);
        }

        private int _pageSize = 10;
 

        public int PageSize
        {
            get => _pageSize;
            set => _pageSize = (value > maxPageSize || value <= 0) ? maxPageSize : value;
        }
    }
}
