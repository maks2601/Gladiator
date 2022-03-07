using DimensionalDoors.Scripts.Components;
using DimensionalDoors.Scripts.Enums;
using Leopotam.Ecs;

namespace DimensionalDoors.Scripts.Systems
{
    public class MovementSystem : IEcsRunSystem
    {
        private EcsFilter<MovementComponent, PhysicsComponent> filter;

        public void Run()
        {
            foreach (var index in filter)
            {
                ref var movement = ref filter.Get1(index);
                ref var physics = ref filter.Get2(index);

                if (movement.moveState == MoveState.Move) Move(movement, physics);
            }
        }

        private void Move(MovementComponent movement, PhysicsComponent physics)
        {
            var force = movement.direction * movement.speed;
            physics.rigidbody.AddForce(force);
        }
    }
}