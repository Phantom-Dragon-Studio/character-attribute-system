using System.Collections.Generic;
using UnityEngine;

public interface ICharacterLeague
{
    Dictionary<IAbility, IAbility> GetAbilities { get; }

    string ToString();
}
