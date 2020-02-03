using System;
using PhantomDragonStudio.HeroSystem;

namespace PhantomDragonStudio.HeroSystem
{
    public class WizardStat : BaseStat, ICombatStat
    {
        public override event EventHandler<CombatStatCalculatedEventArgs> Calculated;
        public override CharacterLeagueType LeagueType => CharacterLeagueType.Wizard;
        public WizardStat(CombatStatType type, ICharacterAttribute primaryAttribute, ICharacterAttribute secondaryAttribute) 
            : base(type, primaryAttribute, secondaryAttribute)
        {
        }

        protected override void Calculate()
        {
            base.Calculate();
            Value = CharacteristicsCalculator.CalculateCombatStat(this);
            Calculated?.Invoke((this), new CombatStatCalculatedEventArgs(Value));
        }
    }
} 