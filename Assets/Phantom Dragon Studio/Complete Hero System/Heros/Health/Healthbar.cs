using UnityEngine;
using UnityEngine.UI;

namespace PhantomDragonStudio.HeroSystem
{
    public class Healthbar : MonoBehaviour, IHealthbar
    {
        public Image Graphics{ get; private set; }
        public IHealth HealthToMonitor { get; }

        public Healthbar(IHealth _healthToMonitor)
        {
            HealthToMonitor = _healthToMonitor;
            //Graphics
        }
    }
}
