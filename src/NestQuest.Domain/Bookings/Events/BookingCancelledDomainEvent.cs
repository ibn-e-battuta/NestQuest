using NestQuest.Domain.Abstractions;

namespace NestQuest.Domain.Bookings.Events;

public sealed record BookingCancelledDomainEvent(Guid BookingId) : IDomainEvent;
