using System;
using UnityEngine;
/// <summary>
/// This class is the base class for all units. Classes such as the Hero class inherit from this class.
/// </summary>
[System.Serializable]
public class Character : MonoBehaviour, ICharacter
{
    [SerializeField] public CharacterSheet characterSheet = default;

    private ICharacterAttributesHandler characterAttributes = default;
    private ICharacterLeague characterLeague = default;
    private IStatusEffectHandler statusEffectHandler = default;

    public string CharacterName => characterSheet.CharacterName;
    public string CharacterDescription => characterSheet.CharacterDescription;
    public Sprite CharacterSprite => characterSheet.CharacterSprite;

    public ICharacterAttributesHandler Attributes => characterAttributes;
    public ICharacterLeague CharacterLeague => characterLeague;
    public IStatusEffectHandler StatusEffectHandler => statusEffectHandler;

    public GameObject GameObject => this.gameObject;

    private void Awake()
    {
        this.characterAttributes = CharacterAttributesHandlerFactory.Create(characterSheet.Attributes);
        //Calculate in any gear bonuses.
        //Calculate in any StatusEffects from spells OR gear.
        //SecondaryAttributes

    }
}
