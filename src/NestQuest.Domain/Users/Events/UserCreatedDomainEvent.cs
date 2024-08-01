using NestQuest.Domain.Abstractions;

namespace NestQuest.Domain.Users.Events;

public sealed record UserCreatedDomainEvent(Guid UserId) : IDomainEvent;
