namespace PhantomDragonStudio.Ability_System
{
    public interface IAbility 
    {
        Ability AbilityInformation { get; }
        AbilityController AbilityController { get; }
        void IncreaseLevel(int levelsToIncrease);
        void Cast();
        void EngageCooldown();
        void ResetCooldown();
    }
}