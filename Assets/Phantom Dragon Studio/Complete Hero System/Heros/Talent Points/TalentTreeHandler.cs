using System.Collections.Generic;
using UnityEngine;

namespace PhantomDragonStudio.HeroSystem
{
    //[RequireComponent(typeof(MainCharacter))]
    [RequireComponent(typeof(Character))]
    public class TalentTreeHandler : MonoBehaviour
    {
        [SerializeField] TalentPointTree[] talentPointTrees = default;
        public ICharacter Character { get; private set; }
        void Start()
        {
            for (int i = 0; i < talentPointTrees.Length; i++)
            {
                Character = GetComponent<Character>();
                talentPointTrees[i].SetUp(Character);
            }
        }

        public void UpgradeTalent(int treeIndex, int talentIndex)
        {
            talentPointTrees[treeIndex].UpgradeTalent(talentIndex);
        }

        public void ResetTalentPointsInTree(int treeIndex)
        {
            talentPointTrees[treeIndex].ResetTree();
        }
    }
}
