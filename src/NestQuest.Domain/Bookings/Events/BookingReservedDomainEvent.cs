using NestQuest.Domain.Abstractions;

namespace NestQuest.Domain.Bookings.Events;

public sealed record BookingReservedDomainEvent(Guid BookingId) : IDomainEvent;
