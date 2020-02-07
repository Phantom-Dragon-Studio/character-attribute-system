namespace PhantomDragonStudio.Ability_System
{
    public static class AbilityFactory
    {
        public static IAbility Create(Ability abilityInfo,AbilityController abilityController)
        {
            IAbility newAbility = new BaseAbility(abilityInfo, abilityController);

            return newAbility;
        }
    }
}