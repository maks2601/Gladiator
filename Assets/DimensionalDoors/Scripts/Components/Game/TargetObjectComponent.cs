using JCMG.EntitasRedux;

namespace DimensionalDoors.Components.Game
{
    [Game]
    public sealed class TargetObjectComponent : IComponent
    {
        public GameEntity target;
    }
}