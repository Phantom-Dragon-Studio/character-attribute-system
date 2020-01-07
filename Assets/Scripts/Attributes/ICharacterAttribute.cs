using UnityEngine;

public interface ICharacterAttribute
{
    AttributeType AttributeType { get; set; }
    float Amount { get; set;  }

    string ToString();
}