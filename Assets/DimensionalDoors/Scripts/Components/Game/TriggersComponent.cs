using System.Collections.Generic;
using JCMG.EntitasRedux;
using UnityEngine;

namespace DimensionalDoors.Components.Game
{
    [Game]
    public sealed class TriggersComponent : IComponent
    {
        public List<GameObject> list;
    }
}