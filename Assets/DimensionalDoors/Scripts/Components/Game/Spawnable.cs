using System;
using JCMG.EntitasRedux;

namespace DimensionalDoors.Components.Game
{
    [Game, Serializable]
    public class Spawnable : IComponent
    {
        public GameBlueprintBehaviour spawnable;
        public int count;
        public float spawnPeriod;
    }
}