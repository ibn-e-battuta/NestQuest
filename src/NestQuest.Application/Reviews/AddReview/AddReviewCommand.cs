using NestQuest.Application.Abstractions.Messaging;

namespace NestQuest.Application.Reviews.AddReview;

public sealed record AddReviewCommand(Guid BookingId, int Rating, string Comment) : ICommand;
