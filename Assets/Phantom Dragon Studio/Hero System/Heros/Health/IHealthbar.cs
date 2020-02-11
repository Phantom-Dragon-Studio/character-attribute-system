using UnityEngine.UI;

namespace PhantomDragonStudio.HeroSystem
{
    public interface IHealthbar
    {
        IHealth HealthToMonitor { get; }
        Image Graphics { get; }
    }
}
