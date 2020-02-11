namespace  PhantomDragonStudio.CombatMechanics
{
    public interface IProjectileBehavior 
    {
        void Construct(ProjectileData data);

        void Execute();

        void Dispose();
    }
}
