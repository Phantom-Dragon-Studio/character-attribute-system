using System.Collections.Generic;
using UnityEngine;

namespace Phantom_Dragon_Studio.Environment
{
    public interface IPatrol
    {
        List<Vector3> Waypoints { get; }
        void Patrol();
    }
}