using NestQuest.Application.Abstractions.Messaging;

namespace NestQuest.Application.Bookings.CompleteBooking;

public sealed record CompleteBookingCommand(Guid BookingId) : ICommand;
