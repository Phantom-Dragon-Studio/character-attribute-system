using System;
using System.Collections.Generic;
using System.Linq;
using PhantomDragonStudio.CombatMechanics;
using PhantomDragonStudio.HeroSystem;
using PhantomDragonStudio.PoolingSystem;
using PhantomDragonStudio.Tools;
using UnityEngine;
using UnityEngine.Serialization;

/// <summary>
/// This pool is tracked by the Transform InstanceID
/// </summary>
[CreateAssetMenu(fileName = "New Character Pool", menuName = "Phantom Dragon Studio/Pooling/Character Pool")]
[Serializable]
public class CharacterPool : ScriptableObject, IPool<ICharacter>
{
    [SerializeField] protected int startCount = default;
    [FormerlySerializedAs("charactersToPool")] [SerializeField] private CharacterSheet characterToPool = default;
    [SerializeField] [ShowOnly] private int currentSize = default;
    
    private ICharacter freshInstance;
    private KeyValuePair<int, ICharacter> pointer;
    private Dictionary<int, ICharacter> pool = new Dictionary<int, ICharacter>();

    public CharacterSheet CharacterToPool => characterToPool; 
    public int StartCount => startCount;
    public int CurrentSize => currentSize;
    public void GeneratePool()
    {
        currentSize = 0;
        for (int j = 0; j < startCount; j++)
        {
            var objToPool = FactoryRequest();
        }
    }

    public ICharacter FindInPool(int key)
    {
        return pool.ContainsKey(key) ? pool[key] : null;
    }

    public void AddToPool(ICharacter character)
    {
        if (!pool.ContainsKey(character.GetInstanceID()))
        {
            pool.Add(character.GetInstanceID(), character);
            currentSize = pool.Count;
        } else
            Debug.LogError("Attempting to add an already existing character to " + this.name);
    }

    public ICharacter RemoveFromPool(ICharacter projectile = null)
    {
        if (pool.Count > 0)
        {
            pointer = pool.First();
            pool.Remove(pointer.Key);
            currentSize = pool.Count;
            return pointer.Value;
        }
        freshInstance = FactoryRequest();

        Debug.LogWarning("Created NEW: " + freshInstance + " with InstanceID: " + freshInstance.GetInstanceID().ToString() + " for pool: " + this);
        return freshInstance;
    }

    protected  ICharacter FactoryRequest()
    {
        return CharacterFactory.Create(characterToPool.Prefab, this);
    }
}