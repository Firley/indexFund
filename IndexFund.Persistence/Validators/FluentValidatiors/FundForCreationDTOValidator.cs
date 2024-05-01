using FluentValidation;
using IndexFund.Domain.Models.FundModels;
using IndexFund.Persistence;
using System.Text.RegularExpressions;

namespace IndexFund.Persistence.Validators.FluentValidatiors;

public class FundForCreationDTOValidator : AbstractValidator<FundForCreationDTO>
{
    public FundForCreationDTOValidator(FundDbContext fundDbContext)
    {
        RuleFor(fund => fund.Name)
            .MaximumLength(128)
            .MinimumLength(3)
            .NotNull();

        RuleFor(fund => fund.Name).Custom((value, context) =>
        {
            var nameInUse = fundDbContext.Funds.Any(f => f.Name == value);

            if (nameInUse)
            {
                context.AddFailure("Name", "That name is taken");
            }
        });

        RuleFor(fund => fund.ShortName)
            .MaximumLength(128)
            .MinimumLength(3)
            .NotNull();

        RuleFor(fund => fund.ShortName).Custom((value, context) =>
        {
            var shortNameInUse = fundDbContext.Funds.Any(f => f.ShortName == value);

            if (shortNameInUse)
            {
                context.AddFailure("ShortName", "That name is taken");
            }
        });

        RuleFor(fund => fund.Benchmark)
            .MaximumLength(128)
            .MinimumLength(3)
            .NotNull();

        RuleFor(fund => fund.RiskLevel)
            .InclusiveBetween(1, 5);

        RuleFor(fund => fund.FirstMinimalPayment)
            .InclusiveBetween(100, 5000)
            .PrecisionScale(5, 2, true);

        RuleFor(fund => fund.MinimalPayment)
            .InclusiveBetween(100, 5000)
            .PrecisionScale(5, 2, true);

        RuleFor(fund => fund.ManagementFee)
            .InclusiveBetween(0.01M, 10.0M)
            .PrecisionScale(5, 2, true);

        RuleFor(fund => fund.HandlingFee)
            .InclusiveBetween(0.01M, 10.0M)
            .PrecisionScale(5, 2, true);

        RuleFor(fund => fund.UnitPrice)
            .GreaterThanOrEqualTo(0)
            .PrecisionScale(5, 2, true);

        RuleFor(fund => fund.InternalCurrency)
            .Matches(new Regex("[a-zA-Z]{3}"))
            .Length(3)
            .WithMessage("Incorrect internal currency code.");

        RuleFor(fund => fund.ExternalCurrency)
             .Matches(new Regex("[a-zA-Z]{3}"))
             .Length(3)
            .WithMessage("Incorrect external currency code.");

        RuleFor(fund => fund.PayoutCurrency)
            .Matches(new Regex("[a-zA-Z]{3}"))
            .Length(3)
            .WithMessage("Incorrect payout currency code.");

        RuleFor(fund => fund.FundStartDate)
            .LessThanOrEqualTo(DateTime.Now);

        RuleFor(fund => fund.CategoryId)
            .NotNull();

        RuleFor(fund => fund.CategoryId).Custom((value, context) =>
        {
            var IdExists = fundDbContext.Categories.All(c => c.Id != value);

            if (IdExists)
            {
                context.AddFailure("CategoryId", "CategoryId doesn't exists");
            }
        });
    }
}
