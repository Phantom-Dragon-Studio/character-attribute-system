namespace Phantom_Dragon_Studio.Ability_System
{
    public static class StatusEffectFactory
    {
        public static IStatusEffect Create(PhysicalStatusEffectType typeToCreate)
        {
            IStatusEffect newStatusEffect = new StatusEffect();

            return newStatusEffect;
        }
    }
}