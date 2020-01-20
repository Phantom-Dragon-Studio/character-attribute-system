public interface ICombatStatsHandler
{
    void AddCombatStat(ICombatStat attribute);

    ICombatStat CriticalStrikeChance { get; }
    ICombatStat DodgeChance { get; }
    ICombatStat BaseDamage { get; }
    ICombatStat MovementSpeed  { get; }
    ICombatStat AttackSpeed { get; }
    ICombatStat PhysicalDefense { get; }
    ICombatStat MagicDefense { get; }
    ICombatStat HealthBase { get; }
    ICombatStat HealthRegen { get; }
    ICombatStat M_E_F_Base { get; }
    ICombatStat M_E_F_Regen { get; }
    ICombatStat StaminaBase { get; }
    ICombatStat StaminaRegen { get; }
}
