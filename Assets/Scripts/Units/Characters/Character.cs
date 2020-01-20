using System;
using UnityEngine;
/// <summary>
/// This class is the base class for all units. Classes such as the Hero class inherit from this class.
/// </summary>
[System.Serializable]
public class Character : MonoBehaviour, ICharacter
{
    //Inspector Editable Field
    [SerializeField] private CharacterSheet characterSheet = default;

    public Character Construct()
    {
        this.health = new Health(100, this);
        this.characterAttributes = CharacterAttributesHandlerFactory.Create(characterSheet.Attributes);
        League = GetComponent<ICharacterLeague>();
        return this;
    }

    #region Private Variables
    private ICharacterAttributesHandler characterAttributes = default;
    private IStatusEffectHandler statusEffectHandler = default;
    private IHealth health;
    private ICharacterLeague league;
    #endregion

    #region Getters & Setters
    public string CharacterName => characterSheet.CharacterName;
    public string CharacterDescription => characterSheet.CharacterDescription;
    public Sprite CharacterSprite => characterSheet.CharacterSprite;
    public ICharacterAttributesHandler Attributes => characterAttributes;
    public IStatusEffectHandler StatusEffectHandler => statusEffectHandler;
    public IHealth Health { get => health; private set { health = value; } }
    public ICharacterLeague League { get => league; set => league = value; }
    #endregion

    #region Health Mechanics
    public event EventHandler<HealedEventArgs> Healed;

    public void Heal(float amount)
    {
        Healed?.Invoke(this, new HealedEventArgs(amount));
    }

    public class HealedEventArgs : EventArgs
    {
        public HealedEventArgs(float amount)
        {
            Amount = amount;
        }

        public float Amount { get; private set; }
    }
    #endregion
}
//Calculate in any gear bonuses for ALREADY equipped gear. Other gear will be accounted for at time of changes.
//Calculate in any StatusEffects from spells & items.