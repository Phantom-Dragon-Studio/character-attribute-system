using System.Collections.Generic;

namespace Phantom_Dragon_Studio.Hero_System
{
    public class MainCharacter : Character, IMainCharacter
    {
        private Dictionary<ITalent, ITalent> talentPoints = new Dictionary<ITalent, ITalent>();

        public Dictionary<ITalent, ITalent> TalentPointList => talentPoints;

    }
}