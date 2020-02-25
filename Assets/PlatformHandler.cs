using System.Collections;
using System.Collections.Generic;
using PhantomDragonStudio.Environment;
using UnityEngine;

public class PlatformHandler : MonoBehaviour
{
    [SerializeField] private List<BasePlatform> platforms; 
    
    void Awake()
    {
        DeactivateAll();
    }

    public void ActivateIndividualPlatform(int index, float time = -1)
    {
        platforms[index].Activate();
    }
/// <summary>
/// Toggles all platforms' current state.
///
/// The time parameter only effects time to be active. Time must be tracked on the calling object and then recall this function with -1 if you wish to invert the mechanics to be
/// deactivated for a specific time frame and then reactivate indefinitely.
/// </summary>
/// <param name="time"></param>
    public void ToggleAll(float time = -1)
    {
        for (int i = 0; i < platforms.Count; i++)
        {
            if(platforms[i].IsActive)
                platforms[i].Deactivate();
            else
                platforms[i].Activate(time);
        }
    }
    
    private void ActivateAll(float time = -1)
    {
        for (int i = 0; i < platforms.Count; i++)
        {
            platforms[i].Activate(time);
        }
    }
    
    private void DeactivateAll()
    {
        for (int i = 0; i < platforms.Count; i++)
        {
            platforms[i].Deactivate();
        }
    }
}
