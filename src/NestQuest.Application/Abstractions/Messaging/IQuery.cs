using NestQuest.Domain.Abstractions;
using MediatR;

namespace NestQuest.Application.Abstractions.Messaging;

public interface IQuery<TResponse> : IRequest<Result<TResponse>>
{
}
