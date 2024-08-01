using NestQuest.Application.Abstractions.Clock;

namespace NestQuest.Infrastructure.Clock;

internal sealed class DateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}
