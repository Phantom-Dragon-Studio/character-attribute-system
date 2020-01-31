namespace Phantom_Dragon_Studio.Ability_System
{
    public interface IElementalResistanceHandler
    {
        IElementalResistance Fire { get; }
        IElementalResistance Water { get; }
        IElementalResistance Earth { get; }
        IElementalResistance Wind  { get; }
        IElementalResistance Lightning { get; }
        IElementalResistance Divine { get; }
        IElementalResistance Dark { get; }
        IElementalResistance Arcane { get; }

        void AddResistance(ElementalEffectType typeToAdd, float amount);
        void UpdateIndividualResistance(ElementalEffectType typeToUpdate, float amount);
        IElementalResistance GetResistanceByType(ElementalEffectType typeToCheck);
    }
}
