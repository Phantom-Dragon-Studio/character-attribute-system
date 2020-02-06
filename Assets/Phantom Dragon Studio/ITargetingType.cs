using UnityEngine;

public enum TargetingType
{
    None,
    Self,
    SingleTarget_Melee,
    SingleTarget_Ranged,
    AreaOfEffect_Local,
    AreaOfEffect_Distant,
}

namespace PhantomDragonStudio.TargetingSystem
{
    public interface ITargetingType
    {

    }
}
