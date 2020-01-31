namespace Phantom_Dragon_Studio.Ability_System
{
    public enum ElementalEffectType
    {
        _None = 0,
        Fire,
        Water,
        Earth,
        Wind,
        Lightning,
        Divine,
        Dark,
        Arcane
    }

    public interface IElementalEffect
    {
        ElementalEffectType ElementalType { get; }
        float Amount { get; }
    }
}