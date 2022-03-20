using System;
using JCMG.EntitasRedux;
using UnityEngine;

namespace DimensionalDoors.Components.Game
{
    [Game, Serializable]
    public class ViewComponent : IComponent
    {
        public GameObject gameObject;
    }
}