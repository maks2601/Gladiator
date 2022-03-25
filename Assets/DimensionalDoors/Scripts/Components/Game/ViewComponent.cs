using System;
using JCMG.EntitasRedux;
using UnityEngine;

namespace DimensionalDoors.Components.Game
{
    [Game, Serializable]
    public sealed class ViewComponent : IComponent
    {
        public GameObject gameObject;
    }
}