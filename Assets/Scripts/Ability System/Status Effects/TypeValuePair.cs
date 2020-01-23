using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class TypeValuePair<TKey, TValue>
{
    public TKey Type;
    public TValue Value;

    public TypeValuePair(TKey _key, TValue _value)
    {
        Type = _key;
        Value = _value;
    }

    public override string ToString()
    {

        return Type.ToString() + " " +  Value.ToString();
    }
}
