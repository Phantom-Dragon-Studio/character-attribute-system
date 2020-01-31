namespace Phantom_Dragon_Studio.Hero_System
{
    public class Healthbar : IHealthbar
    {
        public IHealth HealthToMonitor { get; private set; }

        public Healthbar(IHealth _healthToMonitor)
        {
            HealthToMonitor = _healthToMonitor;
        }
    }
}
