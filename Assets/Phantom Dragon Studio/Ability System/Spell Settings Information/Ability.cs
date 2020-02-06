using PhantomDragonStudio.HeroSystem;
using UnityEngine;

namespace PhantomDragonStudio.Ability_System
{
    [CreateAssetMenu(fileName = "New Ability Sheet", menuName = "Phantom Dragon Studio/Ability Sheet", order = 1)]
    public class Ability : ScriptableObject
    {
        [SerializeField] private GeneralObjectInformation information = default;
        [SerializeField] private AbilityInfo generalAbilityInfo = default;
        [SerializeField] private StatusEffect[] statusEffects = default;
        public string AbilityName => GeneraInformation.Name;
        public string AbilityDescription => GeneraInformation.Description;
        public GeneralObjectInformation GeneraInformation => information;
        public AbilityInfo GeneralAbilityInfo => generalAbilityInfo;
        public StatusEffect[] StatusEffects => statusEffects;
    }
}
