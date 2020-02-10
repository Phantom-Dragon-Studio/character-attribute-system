using System.Collections;
using System.Collections.Generic;
using PhantomDragonStudio.PoolingSystem;
using UnityEngine;

public class PoolsManager : MonoBehaviour
{
    private static PoolsManager _instance;

    public static PoolsManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<PoolsManager>();
            }
            return _instance;
        }
    }
}
//TODO Make Pools have publicly  accessible PullFromPool function via IPool interface.
//TODO Make helper class that listens for PushToPoolEvent and PullFromPoolEvent