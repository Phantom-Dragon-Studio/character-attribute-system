using System.Collections;
using System.Collections.Generic;
using PhantomDragonStudio.Environment;
using UnityEngine;
using UnityEngine.Serialization;

public enum PlatformType
{
    _None = 0,
    Stationary = 1,
    Moving = 2,
    All = 3,
}

public class PlatformHandler : MonoBehaviour
{
    [SerializeField] private List<MovingPlatform> movingPlatforms = default;
    [SerializeField] private List<StationaryPlatform> stationaryPlatforms = default;
    [HideInInspector] public List<BasePlatform> allPlatforms = new List<BasePlatform>(); 
    
    void Awake()
    {
        allPlatforms.AddRange(movingPlatforms);
        allPlatforms.AddRange(stationaryPlatforms);
        DeactivateAll();
    }

    public void ActivateIndividualPlatform(PlatformType listType, int index, float time = -1)
    {
        switch (listType)
        {
            case PlatformType._None :{ return; }
            case PlatformType.Stationary :{ stationaryPlatforms[index].Activate(); break; }
            case PlatformType.Moving :{ movingPlatforms[index].Activate(); break; }
            case PlatformType.All :{ allPlatforms[index].Activate(); break; }
        }
    }
/// <summary>
/// Toggles all allPlatforms' current state.
///
/// The time parameter only effects time to be active. Time must be tracked on the calling object and then recall this function with -1 if you wish to invert the mechanics to be
/// deactivated for a specific time frame and then reactivate indefinitely.
/// </summary>
    public void ToggleAll(float time = -1)
    {
        for (int i = 0; i < allPlatforms.Count; i++)
        {
            if(allPlatforms[i].IsActive)
                allPlatforms[i].Deactivate();
            else
                allPlatforms[i].Activate();
        }
    }
    
    private void ActivateAll()
    {
        for (int i = 0; i < allPlatforms.Count; i++)
        {
            allPlatforms[i].Activate();
        }
    }
    
    private void DeactivateAll()
    {
        for (int i = 0; i < allPlatforms.Count; i++)
        {
            allPlatforms[i].Deactivate();
        }
    }
}
