using System;
using Cinemachine;
using JCMG.EntitasRedux;
using UnityEngine;

namespace DimensionalDoors.Components.Game
{
    [Game, Serializable]
    public sealed class FollowCameraComponent : IComponent
    {
        public CinemachineVirtualCamera virtualCamera;
    }
}