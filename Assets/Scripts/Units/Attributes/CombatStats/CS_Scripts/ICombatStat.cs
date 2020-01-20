public enum CombatStatType
{
    _None = 0,
    CriticalStrikeChance,
    DodgeChance,
    BaseDamage,
    MovementSpeed,
    AttackSpeed,
    PhysicalDefense,
    MagicDefense,
    Health_RegenerationRate,
    Health_Base,
    M_E_F_RegenerationRate,
    M_E_F_Base,
    Stamina_RegenerationRate,
    Stamina_Base,
}

public interface ICombatStat
{
    CombatStatType CombatStatType { get; }
    float Value { get; }
    string ToString();
}
