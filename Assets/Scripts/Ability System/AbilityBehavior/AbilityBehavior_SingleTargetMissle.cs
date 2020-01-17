using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[CreateAssetMenu(fileName = "Single Target Missle", menuName ="Single Target Missle", order = 1)]
public class AbilityBehavior_SingleTargetMissle : AbilityBehavior
{
    public override void Construct()
    {
        Debug.Log("AbilityBehavior_SingleTargetMissle: Constructing");
    }

    public override void Dispose()
    {
        Debug.Log("AbilityBehavior_SingleTargetMissle: Dispose");
    }

    public override void Execute()
    {
        //Debug.Log("AbilityBehavior_SingleTargetMissle: Executing");
    }

}
