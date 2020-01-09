using System.Collections.Generic;

public interface IMainCharacter
{
    ICharacterLeague CharacterLeague {  get; }
    Dictionary<ITalent, ITalent> TalentPointList { get; }
}
