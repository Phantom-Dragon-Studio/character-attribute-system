using System;

public interface IHealth
{
    float CurrentHealth { get; }
    void ResetHealth();
}
