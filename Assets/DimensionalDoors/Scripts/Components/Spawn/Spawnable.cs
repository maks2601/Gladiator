using System;
using JCMG.EntitasRedux;

namespace DimensionalDoors.Components.Spawn
{
    [Spawn, Serializable]
    public class Spawnable : IComponent
    {
        public GameBlueprintBehaviour spawnable;
        public int count;
        public float spawnPeriod;
    }
}