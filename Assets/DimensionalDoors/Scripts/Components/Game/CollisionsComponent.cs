using System.Collections.Generic;
using JCMG.EntitasRedux;
using UnityEngine;

namespace DimensionalDoors.Components.Game
{
    [Game]
    public sealed class CollisionsComponent : IComponent
    {
        public List<GameObject> list;
    }
}