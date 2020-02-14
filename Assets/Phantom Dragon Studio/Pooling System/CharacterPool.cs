using System;
using System.Collections.Generic;
using System.Linq;
using PhantomDragonStudio.HeroSystem;
using PhantomDragonStudio.PoolingSystem;
using PhantomDragonStudio.Tools;
using UnityEngine;


[CreateAssetMenu(fileName = "New Character Pool", menuName = "Phantom Dragon Studio/Pooling/Character Pool")]
[Serializable]
public class CharacterPool : ScriptableObject, IPool<ICharacter>
{
    [SerializeField] protected int startCount = default;
    [SerializeField] private CharacterSheet charactersToPool = default;
    [SerializeField] [ShowOnly] private int currentSize = default;

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

    public void AddToPool(ICharacter character)
    {
        if (pool.ContainsKey(character.GetHashCode()))
        {
            Debug.LogError("Attempting to add an already existing character to " + this.name);
            return;
        }
        pool.Add(character.GetHashCode(), character as ICharacter);
        currentSize = pool.Count;
    }

    public ICharacter RemoveFromPool(Vector3 _position, Quaternion _rotation)
    {
        if (pool.Count > 0)
        {
            pointer = pool.First();
            pool.Remove(pointer.Key);
            currentSize = pool.Count;
            return pointer.Value;
        }
        else
        {
            //Debug.Log(this.name + " is trying to pull an object out of an empty pool.");
            //TODO Update to be similar to projectile pool. Utilizing passed in parameters to determine new object's location.
            return FactoryRequest();
        }
    }

    protected  ICharacter FactoryRequest()
    {
        return CharacterFactory.Create(charactersToPool.Prefab, Vector3.zero, Quaternion.identity);
    }
}