using System;
using System.Collections.Generic;
using DimensionalDoors.Components.Game;
using UnityEngine;

namespace DimensionalDoors.Base.Spawn
{
    [Serializable]
    public sealed class WaveData
    {
        [ReorderableList(ListStyle.Boxed, "Spawnable")]
        public List<Spawnable> spawnables;
    }
}