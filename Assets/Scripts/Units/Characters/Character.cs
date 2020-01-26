using System;
using UnityEngine;
/// <summary>
/// This class is the class for all alive units (Anyting that can move basically because I intend on making structures their own script, similar to the Character script).
/// </summary>
[System.Serializable]
public class Character : MonoBehaviour, ICharacter
{
    //Inspector Editable Field
    [SerializeField] private CharacterSheet characterSheet = default;
    public ICharacterSheet CharacterSheet => characterSheet;
    public ICombatController CombatController { get; private set; }
    
    public IHealth Health { get; private set;  }

    public Character Construct()
    {
        CombatController = new CombatController(this);
        Initialize();
        return this;
    }
    
    private void Initialize()
    {
        Health = new Health(CombatController);
        CombatController.Attributes.UpdateAttribute(new TypeValuePair<AttributeType, float>(AttributeType.Agility, 1));
        CombatController.Attributes.UpdateAttribute(new TypeValuePair<AttributeType, float>(AttributeType.Strength, 1));
        CombatController.Attributes.UpdateAttribute(new TypeValuePair<AttributeType, float>(AttributeType.Wisdom, 1));
        CombatController.Attributes.UpdateAttribute(new TypeValuePair<AttributeType, float>(AttributeType.Endurance, 1));
    }

    public GeneralObjectInformation GeneralObjectInformation => characterSheet.GeneralObjectInformation;

    public event EventHandler<HealedEventArgs> Healed;

    public void Heal(float amount)
    {
        Debug.Log("Attempting to heal...");
        Healed?.Invoke(this, new HealedEventArgs(amount));
    }

    public class HealedEventArgs : EventArgs
    {
        public HealedEventArgs(float amount)
        {
            Debug.Log("Healed Event Fired....");
            Amount = amount;
        }

        public float Amount { get; private set; }
    }
}
//Calculate in any gear bonuses for ALREADY equipped gear. Other gear will be accounted for at time of changes.
//Calculate in any StatusEffects from spells & items.