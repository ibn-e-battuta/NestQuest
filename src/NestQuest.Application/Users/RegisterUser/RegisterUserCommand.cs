using NestQuest.Application.Abstractions.Messaging;

namespace NestQuest.Application.Users.RegisterUser;

public sealed record RegisterUserCommand(
        string Email,
        string FirstName,
        string LastName,
        string Password) : ICommand<Guid>;
