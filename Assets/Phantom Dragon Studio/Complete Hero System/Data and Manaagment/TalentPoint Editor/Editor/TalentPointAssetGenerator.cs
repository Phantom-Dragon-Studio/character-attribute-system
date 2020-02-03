using System;
using UnityEditor;
using PhantomDragonStudio.HeroSystem;

namespace PhantomDragonStudio.Editor
{
    public class TalentPointAssetGenerator : CustomEditor
    {
        public TalentPointAssetGenerator(Type inspectedType) : base(inspectedType)
        {
            inspectedType = typeof(BaseTalentPoint);
        }
    }
}
