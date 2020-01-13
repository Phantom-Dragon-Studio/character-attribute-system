using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BurningEffect : StatusEffect
{
    [SerializeField] StatusEffectFunctionality effectInformation = default;
    public StatusEffectFunctionality EffectInformation => effectInformation;

    // Start is called before the first frame update
    void Awake()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
