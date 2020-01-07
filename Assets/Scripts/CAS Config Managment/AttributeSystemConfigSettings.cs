using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New CAS Config Settings", menuName = "Phantom Dragon Studio/New CAS Config Settings", order = 0)]
public class AttributeSystemConfigSettings : ScriptableObject
{
    [Header("Agility Per Level Base Value")]
    [SerializeField] private float baseAgiilityValue;
    [Header("Agility ")]
    [SerializeField] private float baseStrengthValue;
    [Header("Wisdom")]
    [SerializeField] private float baseWisdomValue;
    [Header("Endurance")]
    [SerializeField] private float baseEnduranceValue;
}
