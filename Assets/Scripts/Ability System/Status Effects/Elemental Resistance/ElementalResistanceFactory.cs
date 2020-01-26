public static class ElementalResistanceFactory
{
    public static IElementalResistance Create(ElementalEffectType elementalType, float amount)
    {
        ElementalResistance newElementalResistance = new ElementalResistance(elementalType, amount)
        {
            ResistanceInfo = {type = elementalType, value = amount}
        };


        return newElementalResistance;
    }
}
