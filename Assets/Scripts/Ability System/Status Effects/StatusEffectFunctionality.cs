using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "New StatusEffect Data", menuName = "Phantom Dragon Studio/Create New StatusEffect Data", order = 1)]
public class StatusEffectFunctionality : ScriptableObject
{
    public void Apply()
    {
        Debug.Log("StatusEffectFunctionality: Apply.");
    }

    public void Tick()
    {
        Debug.Log("StatusEffectFunctionality: Tick.");
    }

    public void Dispose()
    {
        Debug.Log("StatusEffectFunctionality: Dispose.");
    }
}
