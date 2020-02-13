namespace  PhantomDragonStudio.CombatMechanics
{
    public interface IProjectileBehavior 
    {
        void Construct(Projectile projectile);

        void Perform();

        void End();
    }
}
