using System.Collections.Generic;

namespace PhantomDragonStudio.HeroSystem
{
    public interface IMainCharacter
    {
        Dictionary<ITalent, ITalent> TalentPointList { get; }
    }
}
