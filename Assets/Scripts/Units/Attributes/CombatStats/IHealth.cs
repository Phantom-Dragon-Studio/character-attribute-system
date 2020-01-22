using System;

public interface IHealth
{
    float Value { get; }
    float CurrentHealth { get; }
    float MaxHealth { get; }
}
