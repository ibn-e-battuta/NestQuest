namespace NestQuest.Api.Controllers.Reviews;

public sealed record AddReviewRequest
{
    public required Guid BookingId { get; init; }
    public required int Rating { get; init; }
    public required string Comment { get; init; }
}
