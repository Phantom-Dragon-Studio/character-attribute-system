using System.Collections.Generic;

namespace PhantomDragonStudio.HeroSystem
{
    public class MainCharacter : Character, IMainCharacter
    {
        private Dictionary<ITalent, ITalent> talentPoints = new Dictionary<ITalent, ITalent>();

        public Dictionary<ITalent, ITalent> TalentPointList => talentPoints;

    }
}