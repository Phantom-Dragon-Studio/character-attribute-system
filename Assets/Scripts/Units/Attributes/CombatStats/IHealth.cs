using System;

public interface IHealth
{
    int CurrentHealth { get; }
    ICharacter CharacterToMonitor { get; set; }
}
