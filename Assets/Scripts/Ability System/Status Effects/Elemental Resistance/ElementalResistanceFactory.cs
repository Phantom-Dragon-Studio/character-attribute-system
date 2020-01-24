public static class ElementalResistanceFactory
{
    public static IElementalResistance Create(ElementalEffectType elementalType, float amount)
    {
        ElementalResistance newElementalResistance = new ElementalResistance(elementalType, amount);

        newElementalResistance.ResistanceInfo.Type = elementalType;
        newElementalResistance.ResistanceInfo.Value = amount;

        return newElementalResistance;
    }
}
