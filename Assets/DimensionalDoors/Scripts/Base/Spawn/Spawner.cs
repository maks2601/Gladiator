using System.Collections.Generic;
using UnityEngine;

namespace DimensionalDoors.Base.Spawn
{
    [CreateAssetMenu(menuName = "DimensionalDoors/Spawner", fileName = "Spawner", order = 0)]
    public class Spawner : ScriptableObject
    {
        [ReorderableList(ListStyle.Boxed, "Arena")]
        public List<ArenaData> arenas;
    }
}