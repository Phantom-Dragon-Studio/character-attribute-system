public interface IHealth
{
    //void IncreaseHealth(int amount);
    int CurrentHealth { get; }
    ICharacter CharacterToMonitor { get; set; }
}
