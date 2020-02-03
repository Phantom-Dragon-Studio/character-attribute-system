using System;
using PhantomDragonStudio.Tools;
using System.Collections.Generic;
using UnityEngine;

namespace PhantomDragonStudio.HeroSystem
{
    [System.Serializable]
    [CreateAssetMenu(fileName = "New Talent Point Container", menuName = "Phantom Dragon Studio/Talents/Talent Point Container", order = 0)]
    public class TalentPointContainer : ScriptableObject, ITalentPointContainer
    {
        public ICharacter Character { get; private set; }
        public int TotalPointsAvailable { get => totalPointsAvailable; private set => totalPointsAvailable = value; }
        public int TotalPointsSpent { get => totalPointsSpent; private set => totalPointsSpent = value; }
        
        [SerializeField] BaseTalentPoint[] talentPoints = default;
        [SerializeField] private int totalPointsAvailable;
        [SerializeField] private int totalPointsSpent;


        public void Initialize(ICharacter _character)
        {
            Character = _character;
            for (int i = 0; i < talentPoints.Length; i++)
            {
                if (talentPoints[i] != null)
                {
                    //Debug.Log("Setting Up Talent: " + talentPoints[i].GeneralTalentInfo.Name);
                    talentPoints[i].Initialize(this);
                }
                else Debug.LogWarning(this.name + " has null talent points!");
            }
        } 

        public ITalentPoint GetTalentPoint(int index)
        {
            return talentPoints[index];
        }

        public void IncreaseTalentPointLevel (int index)
        {
            if(TotalPointsAvailable != 0)
            {
                if (!talentPoints[index].IsMaxed())
                {
                    Debug.Log("Increasing Talent Point Level for " + talentPoints[index].ToString());
                    TotalPointsSpent++;
                    TotalPointsAvailable--;
                    talentPoints[index].IncreaseLevel(1);
                }
                else
                {
                    Debug.Log("Current Talent is already at max level!");
                }
            }
            else { Debug.Log("Not enough points available!"); }
        }
    }
}