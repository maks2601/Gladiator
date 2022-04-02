using System;
using JCMG.EntitasRedux;

namespace DimensionalDoors.Components.Game
{
    [Game, Serializable]
    public sealed class WeaponInitializeComponent : IComponent
    {
        public GameBlueprintBehaviour weapon;
    }
}