using NestQuest.Application.Abstractions.Messaging;

namespace NestQuest.Application.Bookings.CancelBooking;

public sealed record CancelBookingCommand(Guid BookingId) : ICommand;
