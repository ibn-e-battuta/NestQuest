using NestQuest.Application.Bookings.ConfirmBooking;
using NestQuest.Application.IntegrationTests.Infrastructure;
using NestQuest.Domain.Abstractions;
using NestQuest.Domain.Bookings;
using FluentAssertions;

namespace NestQuest.Application.IntegrationTests.Bookings;

public class ConfirmBookingTests : BaseIntegrationTest
{
    private static readonly Guid BookingId = Guid.NewGuid();

    public ConfirmBookingTests(IntegrationTestWebAppFactory factory)
        : base(factory)
    {
    }

    [Fact]
    public async Task ConfirmBooking_ShouldReturnFailure_WhenBookingIsNotFound()
    {
        // Arrange
        var command = new ConfirmBookingCommand(BookingId);

        // Act
        Result result = await Sender.Send(command);

        // Assert
        result.Error.Should().Be(BookingErrors.NotFound);
    }
}
