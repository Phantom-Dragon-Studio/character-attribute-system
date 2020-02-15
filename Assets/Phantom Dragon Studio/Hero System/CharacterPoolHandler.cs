using PhantomDragonStudio.CombatMechanics;
using UnityEngine;

namespace PhantomDragonStudio.PoolingSystem
{
    public class CharacterPoolHandler : MonoBehaviour
    {
        [SerializeField] private CharacterPool pool = default;
        public CharacterPool Pool => pool;

        private void Awake()
        {
            Pool.GeneratePool();
        }
    }
}