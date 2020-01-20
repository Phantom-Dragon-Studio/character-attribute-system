using UnityEngine;

public interface IElementalResistanceHandler
{
     IElementalResistance Fire { get; }
     IElementalResistance Water { get; }
     IElementalResistance Earth { get; }
     IElementalResistance Wind  { get; }
     IElementalResistance Lightning { get; }
     IElementalResistance Divine { get; }
     IElementalResistance Dark { get; }
     IElementalResistance Arcane { get; }
}
