using System;
using UnityEngine;

namespace PhantomDragonStudio.HeroSystem
{
    public abstract class BaseStat : ICombatStat
    {
        public abstract event EventHandler<CombatStatCalculatedEventArgs> Calculated;
        private const float DefaultValue = 0f;
        public float Value { get; protected set; }
        public CombatStatType CombatStatType { get; protected set; }
        public abstract CharacterLeagueType LeagueType { get; }
        private ICharacterAttribute PrimaryAttribute { get; set; }
        private ICharacterAttribute SecondaryAttribute { get; set; }
        private float primaryPlaceHolder = DefaultValue;
        private float secondaryPlaceHolder = DefaultValue;

        public BaseStat(CombatStatType type, ICharacterAttribute primaryAttribute, ICharacterAttribute secondaryAttribute)
        {
            Value = DefaultValue;
            CombatStatType = type;
            PrimaryAttribute = primaryAttribute;
            SecondaryAttribute = secondaryAttribute;

            if (PrimaryAttribute != null)
                PrimaryAttribute.Changed += (sender, args) => Calculate();
            if (secondaryAttribute != null)
                SecondaryAttribute.Changed += (sender, args) => Calculate();
        }

        public override string ToString()
        {
            return CombatStatType + ": " + Value;
        }

        protected virtual void Calculate()
        {
            primaryPlaceHolder = DefaultValue;
            secondaryPlaceHolder = DefaultValue;


            if (PrimaryAttribute != null)
            {
                primaryPlaceHolder = PrimaryAttribute.AttributeInfo.value;
                primaryPlaceHolder *= CharacteristicsCalculator.GetPrimaryAttributeModifier(this);
            }
            if (SecondaryAttribute != null)
            {
                secondaryPlaceHolder = SecondaryAttribute.AttributeInfo.value;
                secondaryPlaceHolder *= CharacteristicsCalculator.GetSecondaryAttributeModifier(this);
            }

            Value = primaryPlaceHolder + secondaryPlaceHolder;
        }
    }

    public class CombatStatCalculatedEventArgs : EventArgs
    {
        public float Value { get; }

        public CombatStatCalculatedEventArgs(float value)
        {
            Value = value;
        }
    }
}