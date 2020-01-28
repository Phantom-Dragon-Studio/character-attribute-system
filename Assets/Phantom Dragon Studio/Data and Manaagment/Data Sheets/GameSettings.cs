using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameDifficulty { Easy, Medium, Hard, Impossible }

[CreateAssetMenu(fileName = "New Game Settings", menuName = "Phantom Dragon Studio/Game Settings", order = 3)]
public class GameSettings : ScriptableObject
{
    [SerializeField] GameDifficulty gameDifficulty;

    [SerializeField] public float primaryAttributeAffectModifier = default;
    [SerializeField] public float secondaryAttributeAffectModifier = default;
}
