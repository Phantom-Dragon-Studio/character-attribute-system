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

    public void Heal(int amount)
    {
        //It could be done inside the HealthClass as well, but we would need to pass all healingReceived statusEffects with it as well.
        Debug.Log("HEALING!");
        Healed?.Invoke(this, new HealedEventArgs(amount));
    }
    #endregion

    private void Awake()
    {
        this.characterAttributes = CharacterAttributesHandlerFactory.Create(characterSheet.Attributes);
        //Calculate in any gear bonuses.
        //Calculate in any StatusEffects from spells & items.
        //SecondaryAttributes

        Health = new Health(-1, this);
        Health.CharacterToMonitor = this;

        Heal(100);
    }

    public class HealedEventArgs : EventArgs
    {
        public HealedEventArgs(int amount)
        {
            Amount = amount;
        }

        public int Amount { get; private set; }
    }
}
