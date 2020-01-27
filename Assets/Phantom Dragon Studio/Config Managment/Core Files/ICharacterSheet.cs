using UnityEngine;

public interface ICharacterSheet
{
    ICharacterAttribute[] Attributes { get; }
    GeneralObjectInformation GeneralObjectInformation { get; }
    ICharacterLeague LeagueType { get; }
}
