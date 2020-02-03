using UnityEngine;

namespace PhantomDragonStudio.HeroSystem
{
    public class TP_UnlockedState : IState
    {
        private ITalentPoint owner;

        public TP_UnlockedState(ITalentPoint _owner)
        {
            owner = _owner;
        }

        public void Enter()
        {
            Debug.Log(owner.GeneralTalentInfo.Name + " UNLOCKED");
            Execute();
            //TODO Sub to event so we know when to change to activated?
        }

        public void Execute()
        {
            //Glow if points are available            
            if (owner.CurrentLevel > 0)
                owner.ChangeState(owner.ActiveState);
        }

        public void Exit()
        {
            Debug.Log("Exiting unlocked state...");
        }
    }
}