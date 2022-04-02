using JCMG.EntitasRedux;

namespace DimensionalDoors.Components.Game
{
    [Game]
    public sealed class WeaponHolderComponent : IComponent
    {
        public GameEntity weapon;
    }
}