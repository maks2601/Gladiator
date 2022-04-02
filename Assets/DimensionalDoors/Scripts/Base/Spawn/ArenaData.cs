using System;
using System.Collections.Generic;
using UnityEngine;

namespace DimensionalDoors.Base.Spawn
{
    [Serializable]
    public sealed class ArenaData
    {
        [ReorderableList(ListStyle.Boxed, "Wave")]
        public List<WaveData> waves;
    }
}