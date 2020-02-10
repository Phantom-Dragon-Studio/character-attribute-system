using System;
using System.Collections.Generic;
using System.Linq;
using PhantomDragonStudio.HeroSystem;
using PhantomDragonStudio.PoolingSystem;
using PhantomDragonStudio.Tools;
using UnityEngine;


[CreateAssetMenu(fileName = "New Character Pool", menuName = "Phantom Dragon Studio/Pooling/Character Pool")]
[Serializable]
public class CharacterPool : GenericPool<ICharacter>, IPool
{
    [SerializeField] private CharacterSheet charactersToPool = default;
    
    [SerializeField] [ShowOnly] private int currentSize = default;
    
    private new KeyValuePair<int, ICharacter> pointer = new KeyValuePair<int, ICharacter>();
    private new Dictionary<int, ICharacter> pool = new Dictionary<int, ICharacter>();
    public Dictionary<int, ICharacter> Pool => pool;

    public override void GeneratePool()
    {
        currentSize = 0;
        for (int j = 0; j < startCount; j++)
        {
            var objToPool = FactoryRequest();
            AddToPool(objToPool);
        }
    }

    public void AddToPool<T>(T character)
    {
        if (Pool.ContainsKey(character.GetHashCode()))
        {
            Debug.LogError("Attempting to add an already existing character to " + this.name);
            return;
        }
        pool.Add(character.GetHashCode(), character as ICharacter);
        currentSize = Pool.Count;
    }

    public ICharacter RemoveFromPool()
    {
        if (pool.Count > 0)
        {
            pointer = pool.First();
            pool.Remove(pointer.Key);
            currentSize = Pool.Count;
            return pointer.Value;
        }
        else
        {
            //Debug.Log(this.name + " is trying to pull an object out of an empty pool.");
            return FactoryRequest();
        }
    }

    protected override  ICharacter FactoryRequest()
    {
        return CharacterFactory.Create(charactersToPool.Prefab, Vector3.zero, Quaternion.identity);
    }
}