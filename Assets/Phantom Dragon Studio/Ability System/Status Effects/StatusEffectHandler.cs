using System.Collections.Generic;
using UnityEngine;

public class StatusEffectHandler : IStatusEffectHandler
{
    private IElementalResistanceHandler elementalResistanceHandler;

    private Dictionary<PhysicalStatusEffectType, Queue<IStatusEffect>> statusEffects = new Dictionary<PhysicalStatusEffectType, Queue<IStatusEffect>>();

    //Any Getters & Setters added here for attributes will need to be added into the ICharacterAttribute Interface & Class as well for accessibility.
    public Dictionary<PhysicalStatusEffectType, Queue<IStatusEffect>> StatusEffectDictionary { get => statusEffects; }

    public Queue<IStatusEffect> Bleeding => StatusEffectDictionary[PhysicalStatusEffectType.Bleeding];
    public Queue<IStatusEffect> Blinded => StatusEffectDictionary [PhysicalStatusEffectType.Blinded];
    public Queue<IStatusEffect> Burning => StatusEffectDictionary [PhysicalStatusEffectType.Burning];
    public Queue<IStatusEffect> Corrupted => StatusEffectDictionary [PhysicalStatusEffectType.Corrupted];
    public Queue<IStatusEffect> Frozen => StatusEffectDictionary [PhysicalStatusEffectType.Frozen];
    public Queue<IStatusEffect> Poisoned => StatusEffectDictionary [PhysicalStatusEffectType.Poisoned];
    public Queue<IStatusEffect> Rooted => StatusEffectDictionary [PhysicalStatusEffectType.Rooted];
    public Queue<IStatusEffect> Silenced => StatusEffectDictionary [PhysicalStatusEffectType.Silenced];
    public Queue<IStatusEffect> Slowed => StatusEffectDictionary [PhysicalStatusEffectType.Slowed];
    public Queue<IStatusEffect> StaticallyCharged => StatusEffectDictionary [PhysicalStatusEffectType.StaticallyCharged];
    public Queue<IStatusEffect> Stunned => StatusEffectDictionary [PhysicalStatusEffectType.Stunned];
    public Queue<IStatusEffect> TimedLife => StatusEffectDictionary [PhysicalStatusEffectType.TimedLife];

    public void AddStatusEffect(PhysicalStatusEffectType type)
    {
        StatusEffectDictionary[type].Enqueue(StatusEffectFactory.Create(type));
    }

    public Queue<IStatusEffect> GetAllStatusEffectsOfType(PhysicalStatusEffectType statusEffectType)
    {
        return StatusEffectDictionary[statusEffectType];
    }

}
