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

public static class InputComponentsLookup
{
	public const int Controller = 0;
	public const int DisplayInput = 1;
	public const int ScreenToWorldPoint = 2;
	public const int Touch = 3;
	public const int Touched = 4;
	public const int Timer = 5;

	public const int TotalComponents = 6;

	public static readonly string[] ComponentNames =
	{
		"Controller",
		"DisplayInput",
		"ScreenToWorldPoint",
		"Touch",
		"Touched",
		"Timer"
	};

	public static readonly System.Type[] ComponentTypes =
	{
		typeof(DimensionalDoors.Components.Input.Controller),
		typeof(DimensionalDoors.Components.Input.DisplayInputComponent),
		typeof(DimensionalDoors.Components.Input.ScreenToWorldPoint),
		typeof(DimensionalDoors.Components.Input.TouchComponent),
		typeof(DimensionalDoors.Components.Input.Touched),
		typeof(DimensionalDoors.Components.TimerComponent)
	};

	public static readonly Dictionary<Type, int> ComponentTypeToIndex = new Dictionary<Type, int>
	{
		{ typeof(DimensionalDoors.Components.Input.Controller), 0 },
		{ typeof(DimensionalDoors.Components.Input.DisplayInputComponent), 1 },
		{ typeof(DimensionalDoors.Components.Input.ScreenToWorldPoint), 2 },
		{ typeof(DimensionalDoors.Components.Input.TouchComponent), 3 },
		{ typeof(DimensionalDoors.Components.Input.Touched), 4 },
		{ typeof(DimensionalDoors.Components.TimerComponent), 5 }
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
