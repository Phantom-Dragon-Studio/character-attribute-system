using PhantomDragonStudio.Tools;
using UnityEngine;
using UnityEngine.Serialization;

namespace PhantomDragonStudio.HeroSystem
{
    [System.Serializable]
    public class TalentPointRequirements
    {
        private ITalentPoint owner;
        [SerializeField] private int requiredPointsInTree;
        [SerializeField] private BaseTalentPoint[] requiredTalentPoints;

        bool Validate()
        {
            if(requiredPointsInTree == )
            for (int i = 0; i < requiredTalentPoints.Length; i++)
            {
                if (requiredTalentPoints[i] != null && requiredTalentPoints[i].IsMaxed())
                {
                    if (i == requiredTalentPoints.Length) return true;
                    continue;
                }
            }
        }
    }
}