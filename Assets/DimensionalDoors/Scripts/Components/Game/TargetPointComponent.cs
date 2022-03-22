using JCMG.EntitasRedux;
using UnityEngine;

namespace DimensionalDoors.Components.Game
{
    [Game]
    public sealed class TargetPointComponent : IComponent
    {
        public Vector2 targetPoint;
    }
}