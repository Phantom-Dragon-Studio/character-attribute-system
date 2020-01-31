using System;

namespace PhantomDragonStudio.HeroSystem
{
    public abstract class BaseStat
    {
        public float Value { get; protected set; }
        public CombatStatType CombatStatType { get; protected set; }

        protected abstract CharacterLeagueType LeagueType { get; }
        protected ICharacterAttribute PrimaryAttribute { get; set; }
        protected ICharacterAttribute SecondaryAttribute { get; set; }

        private float primaryPlaceHolder = DefaultValue;
        private float secondaryPlaceHolder = DefaultValue;

        protected const float DefaultValue = 0f;

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
                primaryPlaceHolder *= CombatManager.Instance.LeagueSettings[LeagueType].primaryAttributeAffectModifier;
            }
            if (SecondaryAttribute != null)
            {
                secondaryPlaceHolder = SecondaryAttribute.AttributeInfo.value;
                secondaryPlaceHolder *= CombatManager.Instance.LeagueSettings[LeagueType].secondaryAttributeAffectModifier;
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