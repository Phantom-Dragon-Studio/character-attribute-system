using System.Collections.Generic;
using UnityEngine;

namespace Phantom_Dragon_Studio.Environment
{
    public interface IMoveable
    {
        void MoveTo(Vector3 destination);
        void MoveInstant(Vector3 destination);
    }
}