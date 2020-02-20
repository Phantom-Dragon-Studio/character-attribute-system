using System;
using System.Collections.Generic;
using System.Linq;
using PhantomDragonStudio.CombatMechanics;
using PhantomDragonStudio.PoolingSystem;
using PhantomDragonStudio.Tools;
using UnityEngine;

/// <summary>
/// This pool is tracked by the ITargetable InstanceID
/// </summary>
[CreateAssetMenu(fileName = "New Targetable Pool", menuName = "Phantom Dragon Studio/Pooling/Targetable Pool")]
[Serializable]
public class TargetablePool : ScriptableObject, IPool<ITargetable>
{
    [SerializeField] protected int startCount = default;
    [SerializeReference] private GameObject targetablesToPool = default;
    [SerializeField] [ShowOnly] private int currentSize = default;

    private Vector3 position;
    private Quaternion rotation;
    private ITargetable freshInstance;
    private KeyValuePair<int, ITargetable> pointer;
    private Dictionary<int, ITargetable> pool = new Dictionary<int, ITargetable>();
    public void GeneratePool()
    {
        currentSize = 0;
        for (int j = 0; j < startCount; j++)
        {
            var objToPool = FactoryRequest();
            AddToPool(objToPool);
        }
    }

    public ITargetable FindInPool(int key)
    {
        return pool.ContainsKey(key) ? pool[key] : null;
    }

    public void AddToPool(ITargetable target)
    {
        if (!pool.ContainsKey(target.GetInstanceID()))
        {
            pool.Add(target.GetInstanceID(), target);
            currentSize = pool.Count;
        } else
            Debug.LogError("Attempting to add an already existing ITargetable to " + this.name);
    }

    public ITargetable RemoveFromPool(Vector3 _position, Quaternion _rotation)
    {
        position = _position;
        rotation = _rotation;

        if (pool.Count > 0)
        {
            pointer = pool.First();
            pool.Remove(pointer.Key);
            currentSize = pool.Count;
            pointer.Value.Transform.position = position;
            pointer.Value.Transform.rotation = rotation;
            return pointer.Value;
        }
        freshInstance = FactoryRequest();
        freshInstance.Transform.position = position;
        freshInstance.Transform.rotation = rotation;
        
        Debug.LogWarning("Created NEW: " + freshInstance + " with InstanceID: " + freshInstance.GetInstanceID().ToString() + " for pool: " + this);
        return freshInstance;
    }

    protected  ITargetable FactoryRequest()
    {
        //TODO Something
        return null;
    }
}