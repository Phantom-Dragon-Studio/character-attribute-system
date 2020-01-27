using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttributeSystemConfig : MonoBehaviour
{
    public static AttributeSystemConfig instance;

    void Awake()
    {
        if(instance == null) instance = this; else Destroy(this);
    }

    [SerializeField] private AttributeSystemConfigSettings settings;

    public AttributeSystemConfigSettings Settings { get => settings; set => settings = value; }


}
