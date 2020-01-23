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

    public CombatController(ICharacter _character)
    {
        this.Character = _character;
        this.Attributes = CharacterAttributesHandlerFactory.Create(Character.CharacterSheet.Attributes);
        this.CombatStats = CombatStatHandlerFactory.Create(this);
        
        
        this.StatusEffects = new StatusEffectHandler();
    }
}
