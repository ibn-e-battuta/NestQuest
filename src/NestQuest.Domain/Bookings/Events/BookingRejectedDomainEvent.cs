using NestQuest.Domain.Abstractions;

namespace NestQuest.Domain.Bookings.Events;

public sealed record BookingRejectedDomainEvent(Guid BookingId) : IDomainEvent;
