using UnityEngine.Serialization;

namespace Phantom_Dragon_Studio.Tools
{
    [System.Serializable]
    public class TypeValuePair<TKey, TValue>
    {
        [FormerlySerializedAs("Type")] public TKey type;
        [FormerlySerializedAs("Value")] public TValue value;

        public TypeValuePair(TKey _key, TValue _value)
        {
            type = _key;
            value = _value;
        }

        public override string ToString()
        {

            return type.ToString() + " " + value.ToString();
        }
    }
}
