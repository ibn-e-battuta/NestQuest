using NestQuest.Domain.Abstractions;

namespace NestQuest.Domain.Bookings.Events;

public sealed record BookingConfirmedDomainEvent(Guid BookingId) : IDomainEvent;
