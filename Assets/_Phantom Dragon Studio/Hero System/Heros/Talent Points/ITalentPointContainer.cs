using UnityEngine;

namespace PhantomDragonStudio.HeroSystem
{
    public interface ITalentPointContainer
    {
        ITalentPoint GetTalentPoint(int index);
        int TotalPointsAvailable { get; }
        int TotalPointsSpent { get; }
        void AdjustPoints(int adjustmentAmount);
    }
}
