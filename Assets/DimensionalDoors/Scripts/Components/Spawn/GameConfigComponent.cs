using System;
using JCMG.EntitasRedux;

namespace DimensionalDoors.Components.Spawn
{
    [Spawn, Serializable]
    public sealed class GameConfigComponent : IComponent
    {
        public GameBlueprintBehaviour playerBehaviour;
        public InputBlueprintBehaviour inputBehaviour;
        public SpawnBlueprintBehaviour spawnerBehaviour;
        public int currentArena;
        public int currentWave;
    }
}