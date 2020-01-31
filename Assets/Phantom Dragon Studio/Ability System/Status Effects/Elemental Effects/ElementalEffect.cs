namespace Phantom_Dragon_Studio.Ability_System
{
    [System.Serializable]
    public class ElementalEffect : IElementalEffect
    {
        public float Amount { get; set; }
        public ElementalEffectType ElementalType { get; }
        public ElementalEffect(ElementalEffectType type )
        {
            ElementalType = type;
        }
    
        public override string ToString()
        {
            return ElementalType.ToString() + ": " + Amount.ToString();
        }
    }
}
