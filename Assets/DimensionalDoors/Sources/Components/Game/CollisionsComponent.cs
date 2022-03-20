using System;
using System.Collections.Generic;
using JCMG.EntitasRedux;
using UnityEngine;

namespace DimensionalDoors.Components.Game
{
    [Game, Serializable]
    public class CollisionsComponent : IComponent
    {
        public List<GameObject> list;
    }
}