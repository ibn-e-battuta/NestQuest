using NestQuest.Application.Bookings.GetBooking;
using NestQuest.Application.IntegrationTests.Infrastructure;
using NestQuest.Domain.Abstractions;
using NestQuest.Domain.Bookings;
using FluentAssertions;

namespace NestQuest.Application.IntegrationTests.Bookings;

public class GetBookingTests : BaseIntegrationTest
{
    private static readonly Guid BookingId = Guid.NewGuid();

    public GetBookingTests(IntegrationTestWebAppFactory factory)
        : base(factory)
    {
    }

    [Fact]
    public async Task GetBooking_ShouldReturnFailure_WhenBookingIsNotFound()
    {
        // Arrange
        var query = new GetBookingQuery(BookingId);

        // Act
        Result<BookingResponse> result = await Sender.Send(query);

        // Assert
        result.Error.Should().Be(BookingErrors.NotFound);
    }
}
