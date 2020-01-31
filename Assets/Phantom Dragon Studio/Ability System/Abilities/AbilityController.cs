using UnityEngine;

namespace Phantom_Dragon_Studio.Ability_System
{
    public class AbilityController : MonoBehaviour
    {
        [SerializeField] private AbilityInformation[] currentAbilities = default;
        public IAbilityHandler AbilityHandler { get; private set; }

        public void Construct()
        {
            AbilityHandler = AbilityHandlerFactory.Create(currentAbilities);
        }
    }
}