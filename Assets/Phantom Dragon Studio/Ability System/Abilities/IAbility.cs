namespace PhantomDragonStudio.Ability_System
{
    public interface IAbility 
    {
        Ability AbilityInformation { get; }
        void IncreaseLevel(int levelsToIncrease);
        void Cast();
    }
}