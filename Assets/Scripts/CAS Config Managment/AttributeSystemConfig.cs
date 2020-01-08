using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttributeSystemConfig : MonoBehaviour
{
    [SerializeField] private AttributeSystemConfigSettings settings;

    public AttributeSystemConfigSettings Settings { get => settings; set => settings = value; }


}
