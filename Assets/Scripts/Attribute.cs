using UnityEngine;

[System.Serializable]
public class Attribute
{
    public Attribute(AttributeType statType, float amount)
    {
        Amount = amount;
        AttributeType = statType;
    }

    [SerializeField] private AttributeType attributeType;
    [SerializeField] private float amount;

    public AttributeType AttributeType { get => attributeType; internal set => attributeType = value; }
    public float Amount { get => amount; internal set => amount = value; }

    public override string ToString()
    {
        return AttributeType.ToString() + ": " + Amount.ToString();
    }
}