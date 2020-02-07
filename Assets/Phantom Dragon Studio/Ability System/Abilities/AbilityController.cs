using UnityEngine;

namespace PhantomDragonStudio.Ability_System
{
    public class AbilityController : MonoBehaviour
    {
        [SerializeField] private Ability[] currentAbilities = default;
        public IAbilityHandler AbilityHandler { get; private set; }

        public void Awake()
        {
            AbilityHandler = AbilityHandlerFactory.Create(currentAbilities, this);
        }
    }
}