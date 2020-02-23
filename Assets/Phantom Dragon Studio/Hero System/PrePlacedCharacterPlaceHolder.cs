using UnityEngine;
using PhantomDragonStudio.CombatMechanics;
using PhantomDragonStudio.PoolingSystem;

namespace PhantomDragonStudio.HeroSystem
{
    public class PrePlacedCharacterPlaceHolder : MonoBehaviour
    {
        [SerializeField] private CharacterPool[] pools = default;

        private void Awake()
        {
            InitializeWithPooling();
        }

        private void InitializeWithPooling()
        {
            for (int i = 0; i < pools.Length; i++)
            {
                for (int j = 0; j < pools[i].StartCount; j++)
                {
                    DamageablePoolHandler.AddToPool(
                        CharacterFactory.Create(pools[i].CharacterToPool.Prefab, pools[i]) as IDamageable);
                }
            }
        }
    }
}