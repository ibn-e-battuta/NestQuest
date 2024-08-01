using NestQuest.Domain.Abstractions;

namespace NestQuest.Domain.Bookings.Events;

public sealed record BookingCompletedDomainEvent(Guid BookingId) : IDomainEvent;
