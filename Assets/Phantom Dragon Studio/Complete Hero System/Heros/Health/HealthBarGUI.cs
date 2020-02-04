using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace PhantomDragonStudio.HeroSystem
{
    public class HealthBarGUI : MonoBehaviour, IHealthbar
    {
        public IHealth HealthToMonitor { get; private set; }

        public Image Graphics => throw new System.NotImplementedException();

        public HealthBarGUI(IHealth _healthToMonitor)
        {
            HealthToMonitor = _healthToMonitor;
        }
    }
}
