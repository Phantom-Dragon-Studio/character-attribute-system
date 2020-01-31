namespace PhantomDragonStudio.Ability_System
{
    public static class AbilityFactory
    {
        public static IAbility Create(AbilityInformation abilityInfo)
        {
            IAbility newAbility = new BaseAbility(abilityInfo);

            return newAbility;
        }
    }
}