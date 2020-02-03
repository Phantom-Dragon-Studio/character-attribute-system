using UnityEngine;

namespace PhantomDragonStudio.HeroSystem
{

    public enum DefaultTalentPointState
    {
        Locked,
        Unlocked,
        Active
    }

    public interface ITalentPoint
    {
        GeneralObjectInformation GeneralTalentInfo { get; }
        IState CurrentState { get; }
        ITalentPointContainer Container { get; }
        void ChangeState(IState state);
        int CurrentLevel { get; }
        int MaxLevel { get; }
        void PerformFunctionality();
        void StopFunctionality();

        TP_LockedState LockedState { get; }
        TP_UnlockedState UnlockedState { get; }
        TP_ActiveState ActiveState { get; }
    }
}