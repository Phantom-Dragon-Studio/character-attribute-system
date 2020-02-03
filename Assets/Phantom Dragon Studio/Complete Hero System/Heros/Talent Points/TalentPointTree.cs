using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PhantomDragonStudio.HeroSystem
{
    [System.Serializable]
    public class TalentPointTree
    {
        [SerializeField] TalentPointContainer talentPointsContainer = default;
        TalentPointContainer TalentPointContainer { get => talentPointsContainer; }

        public void SetUp(ICharacter character)
        {
            talentPointsContainer.Initialize(character);
        }

        public void UpgradeTalent(int indexToIncrease)
        {
            TalentPointContainer.IncreaseTalentPointLevel(indexToIncrease);
        }
    }
}
