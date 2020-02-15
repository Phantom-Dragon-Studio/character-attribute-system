using System;
using System.Collections.Generic;
using System.Linq;
using PhantomDragonStudio.HeroSystem;
using PhantomDragonStudio.PoolingSystem;
using PhantomDragonStudio.Tools;
using UnityEngine;

/// <summary>
/// This pool is tracked by the Transform InstanceID
/// </summary>
[CreateAssetMenu(fileName = "New Character Pool", menuName = "Phantom Dragon Studio/Pooling/Character Pool")]
[Serializable]
public class CharacterPool : ScriptableObject, IPool<ICharacter>
{
    [SerializeField] protected int startCount = default;
    [SerializeField] private CharacterSheet charactersToPool = default;
    [SerializeField] [ShowOnly] private int currentSize = default;

    private Vector3 position;
    private Quaternion rotation;
    private ICharacter freshInstance;
    private KeyValuePair<int, ICharacter> pointer;
    private Dictionary<int, ICharacter> pool = new Dictionary<int, ICharacter>();
    public void GeneratePool()
    {
        currentSize = 0;
        for (int j = 0; j < startCount; j++)
        {
            var objToPool = FactoryRequest();
            AddToPool(objToPool);
        }
    }

    public ICharacter FindInPool(int key)
    {
        return pool.ContainsKey(key) ? pool[key] : null;
    }

    public void AddToPool(ICharacter character)
    {
        if (!pool.ContainsKey(character.Transform.GetInstanceID()))
        {
            pool.Add(character.Transform.GetInstanceID(), character);
            currentSize = pool.Count;
        } else
            Debug.LogError("Attempting to add an already existing character to " + this.name);
    }

    public ICharacter RemoveFromPool(Vector3 _position, Quaternion _rotation)
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
        
        Debug.LogWarning("Created NEW: " + freshInstance + " with InstanceID: " + freshInstance.Transform.GetInstanceID().ToString() + " for pool: " + this);
        return freshInstance;
    }

    protected  ICharacter FactoryRequest()
    {
        return CharacterFactory.Create(charactersToPool.Prefab, Vector3.zero, Quaternion.identity);
    }
}