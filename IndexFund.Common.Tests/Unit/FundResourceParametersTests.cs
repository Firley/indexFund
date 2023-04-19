using IndexFund.Common.WebApi.ResourceParameters;

namespace IndexFund.Common.Tests.Unit
{
    public class FundResourceParametersTests
    {
        [Fact]
        public void FundResourceParameters_PageSizeCannotBeHigherThanMaxPageSize()
        {
            var fundsearchResource = new FundResourceParameters() { PageSize = 15 };
            Assert.Equal(10, fundsearchResource.PageSize);
        }

        [Fact]
        public void FundResourceParameters_DefualtPageSizeIsEqual10()
        {
            var fundsearchResource = new FundResourceParameters();
            Assert.Equal(10, fundsearchResource.PageSize);
        }

        [Fact]
        public void FundResourceParameters_PageSizeCannotBeNegative()
        {
            var fundsearchResource = new FundResourceParameters() { PageSize= -1};
            Assert.Equal(10, fundsearchResource.PageSize);
        }

        [Fact]
        public void FundResourceParameters_PageNumberCannotBeNegative()
        {
            var fundsearchResource = new FundResourceParameters() { PageNumber = -1 };
            Assert.Equal(1, fundsearchResource.PageNumber);          
        }

        [Fact]
        public void FundResourceParameters_PageNumberCannotBeEqualZero()
        {
            var fundsearchResource = new FundResourceParameters() { PageNumber = 0 };
            Assert.Equal(1, fundsearchResource.PageNumber);

        }

        [Fact]
        public void FundResourceParameters_OrderBySmallCharsAreConvertedToUpperChars()
        {
            var fundsearchResource = new FundResourceParameters() { OrderBy = "id"};
            Assert.Equal("ID", fundsearchResource.OrderBy);

        }

        [Fact]
        public void FundResourceParameters_DefualtOrderByIsSetAtOrderByName()
        {
            var fundsearchResource = new FundResourceParameters() { OrderBy = "notExistingOrderBy" };
            Assert.Equal("NAME", fundsearchResource.OrderBy);

        }

    }
}