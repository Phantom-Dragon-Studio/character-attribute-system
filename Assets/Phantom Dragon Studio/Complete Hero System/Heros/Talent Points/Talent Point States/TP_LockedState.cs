using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PhantomDragonStudio.HeroSystem
{
    public class TP_LockedState : IState
    {
        private readonly ITalentPoint owner;
        private readonly TalentPointRequirements myRequirements;
        public TP_LockedState(ITalentPoint owner, TalentPointRequirements requirements)
        {
            this.owner = owner;
            myRequirements = requirements;
        }

        public void Enter()
        { 
            //TODO subscribe to an event so we know when to check execute? This would be done to avoid code in update.
            Debug.Log(owner.GeneralTalentInfo.Name + " Locked State Engaged!");
            Execute();
            //TODO Greyscale image?
        }

        public void Execute()
        {
            if(myRequirements.Validate(owner))
                owner.ChangeState(owner.UnlockedState );
        }

        public void Exit()
        {
            //unGreyscale image if needed
            //Should we dispose of this class now? 
            //Are we completely done with it?
        }
    }
}