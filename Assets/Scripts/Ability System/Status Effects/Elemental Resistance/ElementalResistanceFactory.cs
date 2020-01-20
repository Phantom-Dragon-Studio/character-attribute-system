public static class ElementalResistanceFactory
{
    public static IElementalResistance Create(ElementalEffectType elementalType, float amount)
    {
        ElementalResistance newCombatStat = new ElementalResistance();

        newCombatStat.ElementalType = elementalType;
        newCombatStat.Amount = amount;

        return newCombatStat;
    }
}
