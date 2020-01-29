using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatController : ICombatController
{
    public ICharacter Character { get; private set; }
    public ICharacterAttributesHandler Attributes { get; private set; }
    public ICombatStatsHandler CombatStats { get; private set; }
    public IStatusEffectHandler StatusEffects { get; private set; }
    public IElementalResistanceHandler ElementalResistances { get; private set; }
    

    public CombatController(ICharacter character)
    {
        Character = character;
        Attributes = CharacterAttributesHandlerFactory.Create(Character.CharacterSheet.Attributes);
        CombatStats = CombatStatHandlerFactory.Create(this, Character.CharacterSheet.League);
        ElementalResistances = new ElementalResistanceHandler();
        StatusEffects = new StatusEffectHandler();
    }
}
