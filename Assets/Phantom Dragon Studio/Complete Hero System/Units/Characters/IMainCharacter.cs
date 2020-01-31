using System.Collections.Generic;

namespace Phantom_Dragon_Studio.Hero_System
{
    public interface IMainCharacter
    {
        Dictionary<ITalent, ITalent> TalentPointList { get; }
    }
}
