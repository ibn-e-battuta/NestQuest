using NestQuest.Application.Abstractions.Messaging;

namespace NestQuest.Application.Bookings.ConfirmBooking;

public sealed record ConfirmBookingCommand(Guid BookingId) : ICommand;
