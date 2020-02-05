using UnityEngine;

namespace PhantomDragonStudio.Ability_System
{
    public class AbilityController : MonoBehaviour
    {
        [SerializeField] private AbilityInformation[] currentAbilities = default;
        public IAbilityHandler AbilityHandler { get; private set; }

        public void Construct()
        {
            AbilityHandler = AbilityHandlerFactory.Create(currentAbilities);
        }

        public void CreateMagicBolt(Vector3 spawnPoint, Quaternion spawnRotation)
        {
            //Instantiate(_settings.abilityDataFile.GeneralAbilityInfo.Sfx, spawnPoint, spawnRotation, this.gameObject.transform);
        }
    }
}