using UnityEngine;

namespace  PhantomDragonStudio.Ability_System
{
    public interface IProjectileBehavior 
    {
        void Construct();

        void Execute();

        void Dispose();
    }
}
