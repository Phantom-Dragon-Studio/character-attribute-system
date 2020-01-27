using UnityEngine;

namespace Ability_System
{
    public class AbilityController : MonoBehaviour
    {
        [SerializeField] private AbilityInformation[] currentAbilities = default;
        public IAbilityHandler AbilityHandler { get; private set; }
        
        private void Awake()
        {
            AbilityHandler = AbilityHandlerFactory.Create(currentAbilities);
        }
    }
}