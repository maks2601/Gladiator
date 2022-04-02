//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v2.4.4.0).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using JCMG.EntitasRedux;

public static class GameComponentsLookup
{
	public const int Collisions = 0;
	public const int Controlled = 1;
	public const int FollowCamera = 2;
	public const int Move = 3;
	public const int Moving = 4;
	public const int Physics = 5;
	public const int Player = 6;
	public const int RandomCirclePosition = 7;
	public const int Rotatable = 8;
	public const int ScanField = 9;
	public const int Spawned = 10;
	public const int TargetObject = 11;
	public const int TargetPoint = 12;
	public const int Triggers = 13;
	public const int View = 14;
	public const int Timer = 15;

	public const int TotalComponents = 16;

	public static readonly string[] ComponentNames =
	{
		"Collisions",
		"Controlled",
		"FollowCamera",
		"Move",
		"Moving",
		"Physics",
		"Player",
		"RandomCirclePosition",
		"Rotatable",
		"ScanField",
		"Spawned",
		"TargetObject",
		"TargetPoint",
		"Triggers",
		"View",
		"Timer"
	};

	public static readonly System.Type[] ComponentTypes =
	{
		typeof(DimensionalDoors.Components.Game.CollisionsComponent),
		typeof(DimensionalDoors.Components.Game.Controlled),
		typeof(DimensionalDoors.Components.Game.FollowCameraComponent),
		typeof(DimensionalDoors.Components.Game.Move),
		typeof(DimensionalDoors.Components.Game.Moving),
		typeof(DimensionalDoors.Components.Game.PhysicsComponent),
		typeof(DimensionalDoors.Components.Game.Player),
		typeof(DimensionalDoors.Components.Game.RandomCirclePositionComponent),
		typeof(DimensionalDoors.Components.Game.Rotatable),
		typeof(DimensionalDoors.Components.Game.ScanFieldComponent),
		typeof(DimensionalDoors.Components.Game.Spawned),
		typeof(DimensionalDoors.Components.Game.TargetObjectComponent),
		typeof(DimensionalDoors.Components.Game.TargetPointComponent),
		typeof(DimensionalDoors.Components.Game.TriggersComponent),
		typeof(DimensionalDoors.Components.Game.ViewComponent),
		typeof(DimensionalDoors.Components.TimerComponent)
	};

	public static readonly Dictionary<Type, int> ComponentTypeToIndex = new Dictionary<Type, int>
	{
		{ typeof(DimensionalDoors.Components.Game.CollisionsComponent), 0 },
		{ typeof(DimensionalDoors.Components.Game.Controlled), 1 },
		{ typeof(DimensionalDoors.Components.Game.FollowCameraComponent), 2 },
		{ typeof(DimensionalDoors.Components.Game.Move), 3 },
		{ typeof(DimensionalDoors.Components.Game.Moving), 4 },
		{ typeof(DimensionalDoors.Components.Game.PhysicsComponent), 5 },
		{ typeof(DimensionalDoors.Components.Game.Player), 6 },
		{ typeof(DimensionalDoors.Components.Game.RandomCirclePositionComponent), 7 },
		{ typeof(DimensionalDoors.Components.Game.Rotatable), 8 },
		{ typeof(DimensionalDoors.Components.Game.ScanFieldComponent), 9 },
		{ typeof(DimensionalDoors.Components.Game.Spawned), 10 },
		{ typeof(DimensionalDoors.Components.Game.TargetObjectComponent), 11 },
		{ typeof(DimensionalDoors.Components.Game.TargetPointComponent), 12 },
		{ typeof(DimensionalDoors.Components.Game.TriggersComponent), 13 },
		{ typeof(DimensionalDoors.Components.Game.ViewComponent), 14 },
		{ typeof(DimensionalDoors.Components.TimerComponent), 15 }
	};

	/// <summary>
	/// Returns a component index based on the passed <paramref name="component"/> type; where an index cannot be found
	/// -1 will be returned instead.
	/// </summary>
	/// <param name="component"></param>
	public static int GetComponentIndex(IComponent component)
	{
		return GetComponentIndex(component.GetType());
	}

	/// <summary>
	/// Returns a component index based on the passed <paramref name="componentType"/>; where an index cannot be found
	/// -1 will be returned instead.
	/// </summary>
	/// <param name="componentType"></param>
	public static int GetComponentIndex(Type componentType)
	{
		return ComponentTypeToIndex.TryGetValue(componentType, out var index) ? index : -1;
	}
}
