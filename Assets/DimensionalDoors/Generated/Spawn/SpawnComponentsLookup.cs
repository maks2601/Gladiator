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

public static class SpawnComponentsLookup
{
	public const int Arena = 0;
	public const int Spawnable = 1;
	public const int Spawner = 2;
	public const int Wave = 3;
	public const int Timer = 4;

	public const int TotalComponents = 5;

	public static readonly string[] ComponentNames =
	{
		"Arena",
		"Spawnable",
		"Spawner",
		"Wave",
		"Timer"
	};

	public static readonly System.Type[] ComponentTypes =
	{
		typeof(DimensionalDoors.Components.Spawn.ArenaComponent),
		typeof(DimensionalDoors.Components.Spawn.Spawnable),
		typeof(DimensionalDoors.Components.Spawn.SpawnerComponent),
		typeof(DimensionalDoors.Components.Spawn.WaveComponent),
		typeof(DimensionalDoors.Components.TimerComponent)
	};

	public static readonly Dictionary<Type, int> ComponentTypeToIndex = new Dictionary<Type, int>
	{
		{ typeof(DimensionalDoors.Components.Spawn.ArenaComponent), 0 },
		{ typeof(DimensionalDoors.Components.Spawn.Spawnable), 1 },
		{ typeof(DimensionalDoors.Components.Spawn.SpawnerComponent), 2 },
		{ typeof(DimensionalDoors.Components.Spawn.WaveComponent), 3 },
		{ typeof(DimensionalDoors.Components.TimerComponent), 4 }
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
