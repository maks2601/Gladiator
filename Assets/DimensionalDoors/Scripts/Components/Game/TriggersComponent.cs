using System.Collections.Generic;
using JCMG.EntitasRedux;

namespace DimensionalDoors.Components.Game
{
    [Game]
    public sealed class TriggersComponent : IComponent
    {
        public List<GameEntity> list;
    }
}