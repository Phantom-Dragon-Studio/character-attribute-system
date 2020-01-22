using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatController : MonoBehaviour, ICombatController
{
    //Reference Character for the sheet???

    public ICharacter Character { get; set; }
    public ICharacterAttributesHandler Attributes { get; private set; }
    public ICombatStatsHandler CombatStats { get; private set; }
    public IStatusEffectHandler StatusEffects { get; private set; }
    public IElementalResistanceHandler ElementalResistances { get; set; }

    public CombatController()
    {
        this.Attributes = CharacterAttributesHandlerFactory.Create(Character.CharacterSheet.Attributes);
    }
}
