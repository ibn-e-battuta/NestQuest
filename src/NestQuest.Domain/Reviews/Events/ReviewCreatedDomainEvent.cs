using NestQuest.Domain.Abstractions;

namespace NestQuest.Domain.Reviews.Events;

public sealed record ReviewCreatedDomainEvent(Guid ReviewId) : IDomainEvent;
