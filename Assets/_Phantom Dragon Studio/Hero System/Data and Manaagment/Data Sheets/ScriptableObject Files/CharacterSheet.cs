﻿using System;
using UnityEngine;
using PhantomDragonStudio.Tools;

namespace PhantomDragonStudio.HeroSystem
{
    /// <summary>
    ///     Main Data Container for characters
    ///  Attributes do not have direct getters. They are loaded into an array and sent as a whole.
    ///  The SO is setup in this manner to allow explicit attribute base values to be assigned without needing to write a custom inspector.
    /// </summary>
    [CreateAssetMenu(fileName = "New Character Sheet", menuName = "Phantom Dragon Studio/Character Sheet", order = 0)]
    public class CharacterSheet : ScriptableObject, ICharacterSheet
    {
        [Header("General Information")]
        [SerializeField] private GeneralObjectInformation objectInformation = default;
        [SerializeField] private Character prefab = default;

        [SerializeField] private CharacterLeagueType characterLeagueType = default;
        [Header("Agility")]
        [SerializeField] private float baseAgilityValue = default;
        [Header("Strength")]
        [SerializeField] private float baseStrengthValue = default;
        [Header("Wisdom")]
        [SerializeField] private float baseWisdomValue = default;
        [Header("Endurance")]
        [SerializeField] private float baseEnduranceValue = default;
    
        public ICharacterAttribute[] Attributes { get; } = new ICharacterAttribute[Enum.GetNames(typeof(AttributeType)).Length];
        public GeneralObjectInformation GeneralObjectInformation => objectInformation;
        public Character Prefab => prefab;
        public ICharacterLeague League { get; private set; }

        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        #region Initialization

        public void OnEnable()
        {
            //Debug.Log("Initializing ICharacterSheet for " + GeneralObjectInformation.Name);
            Attributes[0] = CharacterAttributeFactory.Create(AttributeType._None, 0f);
            Attributes[1] = CharacterAttributeFactory.Create(AttributeType.Agility, baseAgilityValue);
            Attributes[2] = CharacterAttributeFactory.Create(AttributeType.Strength, baseStrengthValue);
            Attributes[3] = CharacterAttributeFactory.Create(AttributeType.Wisdom, baseWisdomValue);
            Attributes[4] = CharacterAttributeFactory.Create(AttributeType.Endurance, baseEnduranceValue);
            League = CreateLeague();
        }

        private ICharacterLeague CreateLeague()
        {
            switch (characterLeagueType)
            {
                case CharacterLeagueType.Rogue:
                {
                    return new Rogue();
                }
                case CharacterLeagueType.Warrior:
                {
                    return new Warrior();
                }
                case CharacterLeagueType.Wizard:
                {
                    return new Wizard();
                }
                default:
                {
                    Debug.LogWarning(GeneralObjectInformation.Name + " has an empty class type selected and therefore will have a null CharacterLeague.");
                    return null;
                }
            }
        }
        #endregion
    }
}
