﻿namespace NestQuest.Domain.Shared;

public sealed record Money(decimal Amount, Currency Currency)
{
    public static Money operator +(Money first, Money second) => first.Currency != second.Currency
            ? throw new InvalidOperationException("Currencies have to be equal")
            : first with { Amount = first.Amount + second.Amount };

    public static Money Zero() => new(0, Currency.None);

    public static Money Zero(Currency currency) => new(0, currency);

    public bool IsZero() => this == Zero(Currency);
}
