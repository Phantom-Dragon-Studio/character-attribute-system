public class Healthbar : IHealthbar
{
    public IHealth HealthToMonitor { get; private set; }

    public Healthbar(IHealth _healthToMonitor)
    {
        HealthToMonitor = _healthToMonitor;
    }
}
