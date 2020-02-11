using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;

namespace PhantomDragonStudio.HeroSystem
{
    public class TalentPointUI //: Button //, ITalentPoint
    {
        private void Awake()
        {
            Debug.Log("TP Button Awake");
            //onClick.AddListener(UpgradeTalentPoint);
        }

        private void UpgradeTalentPoint()
        {
            
        }

        // public GeneralObjectInformation GeneralTalentInfo { get; }
        // public IState CurrentState { get; set; }
        // public int CurrentLevel { get; }
        // public int MaxLevel { get; }
    }
}