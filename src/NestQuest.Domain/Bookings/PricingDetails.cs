using NestQuest.Domain.Shared;

namespace NestQuest.Domain.Bookings;

public sealed record PricingDetails
(
    Money PriceForPeriod,
    Money CleaningFee,
    Money AmenitiesUpCharge,
    Money TotalPrice
);
