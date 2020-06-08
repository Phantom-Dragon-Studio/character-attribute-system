using System.Collections.Generic;
using UnityEngine;

namespace Phantom_Dragon_Studio.Environment
{
    public interface IMoveable
    {
        void MoveInstant(Vector3 destination);
    }
}