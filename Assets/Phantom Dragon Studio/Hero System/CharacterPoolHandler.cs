using PhantomDragonStudio.HeroSystem;
using UnityEngine;

namespace PhantomDragonStudio.PoolingSystem
{
    public class CharacterPoolHandler : MonoBehaviour
    {
        [SerializeField] private CharacterPool[] pools = default;
        public CharacterPool[] Pools => pools;

        private void Awake()
        {
            for (int i = 0; i < pools.Length; i++)
            {
                Pools[i].GeneratePool();
            }
        }

        public ICharacter SearchAllPools(int InstanceID)
        {
            ICharacter foundIndex = null;
            for (int i = 0; i < pools.Length; i++)
            {
                foundIndex = Pools[i].FindInPool(InstanceID);
                if (foundIndex == null)
                    continue;
                else
                    i = pools.Length;
            }

            return foundIndex;
        }
    }
}