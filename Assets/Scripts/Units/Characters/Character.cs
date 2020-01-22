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
    [SerializeField] public CharacterCombatController CharacterCombatController { get; private set; }
    public Character Construct()
    {
        CharacterCombatController = GetComponent<CharacterCombatController>();

        League = GetComponent<ICharacterLeague>();
        return this;
    }

    #region Getters & Setters
    public GeneralObjectInformation GeneralObjectInformation => characterSheet.GeneralObjectInformation;
    public ICharacterLeague League { get; private set; }
    #endregion


    void Start()
    {
        Heal(20);
    }


    #region Health Mechanics
    public event EventHandler<HealedEventArgs> Healed;

    public void Heal(float amount)
    {
        Healed?.Invoke(this, new HealedEventArgs(this, amount));
    }

    public class HealedEventArgs : EventArgs
    {
        public HealedEventArgs(ICharacter character, float amount)
        {
            Character = character;
            Amount = amount;
        }

        public float Amount { get; private set; }
        public ICharacter Character { get; private set; }
    }
    #endregion
}
//Calculate in any gear bonuses for ALREADY equipped gear. Other gear will be accounted for at time of changes.
//Calculate in any StatusEffects from spells & items.