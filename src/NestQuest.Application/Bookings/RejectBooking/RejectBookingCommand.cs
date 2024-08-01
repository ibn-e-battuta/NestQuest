using NestQuest.Application.Abstractions.Messaging;

namespace NestQuest.Application.Bookings.RejectBooking;

public sealed record RejectBookingCommand(Guid BookingId) : ICommand;
