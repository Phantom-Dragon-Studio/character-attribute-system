﻿using System.Collections.Generic;
using UnityEngine;

namespace PhantomDragonStudio.Ability_System
{
    public class AbilityHandler : IAbilityHandler
    {
        private Dictionary<int, IAbility> currentAbilities = new Dictionary<int, IAbility>();
        public Dictionary<int, IAbility> GetAbilities => currentAbilities;

        public void AddAbility(int abilityIndex, IAbility _ability)
        {
            currentAbilities.Add(abilityIndex, _ability);
        }

        public void RemoveAbility(int abilityIndex)
        {
            currentAbilities.Remove(abilityIndex);
        }

        public void LevelUpAbility(int index, int numberOfLevelsToIncrementBy)
        {
            currentAbilities[index].IncreaseLevel(numberOfLevelsToIncrementBy);
        }

        public void CastAbility(int abilityIndex)
        {
            GetAbilities[abilityIndex].Cast();
        }
    }
}
