using NestQuest.Application.Abstractions.Messaging;

namespace NestQuest.Application.Users.GetLoggedInUser;

public sealed record GetLoggedInUserQuery : IQuery<UserResponse>;
