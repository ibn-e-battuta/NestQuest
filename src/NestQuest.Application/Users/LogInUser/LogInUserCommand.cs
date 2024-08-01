using NestQuest.Application.Abstractions.Messaging;

namespace NestQuest.Application.Users.LogInUser;

public sealed record LogInUserCommand(string Email, string Password)
    : ICommand<AccessTokenResponse>;
