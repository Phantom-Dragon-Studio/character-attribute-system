namespace PhantomDragonStudio.Ability_System
{
    public static class AbilityFactory
    {
        public static IAbility Create(Ability abilityInfo)
        {
            IAbility newAbility = new BaseAbility(abilityInfo);

            return newAbility;
        }
    }
}