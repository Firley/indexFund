namespace IndexFund.Common.WebApi.Helpers
{
    public class PaginationMetadata
    {
        public int TotalItemCount { get; set; }

        public int TotalPageCount { get; set; }

        public int PageSize { get; set; }

        public int CurrentPage { get; set; }

        public string? Previouslink { get; set; }

        public string? Nextlink { get; set; }

        public string? Currentlink { get; set; }

        public PaginationMetadata(int totalItemCount, int pageSize, int currentPage,string? previousLink, string? nextLink,string? currentLink)
        {
            TotalItemCount = totalItemCount;
            PageSize = pageSize;
            CurrentPage = currentPage;
            TotalPageCount = (int)Math.Ceiling(totalItemCount / (double)pageSize);
            Previouslink = previousLink;
            Nextlink = nextLink;
            Currentlink = currentLink;
        }
    }
}
