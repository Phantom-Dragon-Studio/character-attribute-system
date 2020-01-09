using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCharacter : Character, IMainCharacter, IControllable
{
    private Dictionary<ITalent, ITalent> talentPoints = new Dictionary<ITalent, ITalent>();

    public Dictionary<ITalent, ITalent> TalentPointList => talentPoints;

    public void ProcessInput()
    {

    }
}