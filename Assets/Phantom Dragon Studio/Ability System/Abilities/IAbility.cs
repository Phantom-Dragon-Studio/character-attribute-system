﻿namespace PhantomDragonStudio.Ability_System
{
    public interface IAbility 
    {
        AbilityInformation AbilityInformation { get; }
        void IncreaseLevel(int levelsToIncrease);
        void Execute();
    }
}