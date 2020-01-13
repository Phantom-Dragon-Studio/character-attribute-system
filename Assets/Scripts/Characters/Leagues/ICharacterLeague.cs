
public interface ICharacterLeague
{
    IAbilityHandler AbilityHandler { get; }
    IAttackStyle AttackStyle { get; }
    string ToString();
}
