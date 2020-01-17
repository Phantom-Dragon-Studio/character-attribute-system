using System;
using UnityEngine;
/// <summary>
/// This class is the base class for all units. Classes such as the Hero class inherit from this class.
/// </summary>
[System.Serializable]
public class Character : MonoBehaviour, ICharacter
{
    [SerializeField] private CharacterSheet characterSheet = default;

    #region Private Variables
    private ICharacterAttributesHandler characterAttributes = default;
    private ICharacterLeague characterLeague = default;
    private IStatusEffectHandler statusEffectHandler = default;
    private IHealth health;

    public Character Construct()
    {
        this.health = new Health(100, this);
        return this;
    }
    #endregion

    #region Getters & Setters
    public string CharacterName => characterSheet.CharacterName;
    public string CharacterDescription => characterSheet.CharacterDescription;
    public Sprite CharacterSprite => characterSheet.CharacterSprite;
    public ICharacterAttributesHandler Attributes => characterAttributes;
    public ICharacterLeague CharacterLeague => characterLeague;
    public IStatusEffectHandler StatusEffectHandler => statusEffectHandler;
    public IHealth Health { get => health; private set { health = value; } }
    public GameObject GameObject => this.gameObject;
    #endregion

    #region Health Mechanics
    public event EventHandler<HealedEventArgs> Healed;

    public void Heal(float amount)
    {
        Healed?.Invoke(this, new HealedEventArgs(amount));
    }
    #endregion

    private void Awake()
    {
        this.characterAttributes = CharacterAttributesHandlerFactory.Create(characterSheet.Attributes);
        //Calculate in any gear bonuses.
        //Calculate in any StatusEffects from spells & items.
        //CombatStats
    }

    public class HealedEventArgs : EventArgs
    {
        public HealedEventArgs(float amount)
        {
            Amount = amount;
        }

        public float Amount { get; private set; }
    }
}
