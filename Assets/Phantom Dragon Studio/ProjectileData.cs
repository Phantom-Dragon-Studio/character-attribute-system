﻿using UnityEngine;
using PhantomDragonStudio.Ability_System;

namespace PhantomDragonStudio
{
    
    [System.Serializable]
    public class ProjectileData
    {
        [SerializeField] private float value = default;
        [SerializeField] private float lifetime  = default;
        [SerializeField] private float speed  = default;
        public float Speed => speed;
        public float Lifetime => lifetime;
        public float Value => value;
    }
}
