namespace PhantomDragonStudio.Ability_System
{
    public static class AbilityFactory
    {
        public static IAbility Create(Ability abilityInfo, AbilityController abilityController)
        {
            //TODO Fix system to work with base class ability. Also need to refactor out singletons to be scriptable objects
            //IAbility newAbility = new BaseAbility(abilityInfo, abilityController);

            return null;
        }
    }
}