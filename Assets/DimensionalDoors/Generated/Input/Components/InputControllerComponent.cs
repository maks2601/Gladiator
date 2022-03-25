//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v2.4.4.0).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class InputEntity
{
	static readonly DimensionalDoors.Components.Input.Controller ControllerComponent = new DimensionalDoors.Components.Input.Controller();

	public bool IsController
	{
		get { return HasComponent(InputComponentsLookup.Controller); }
		set
		{
			if (value != IsController)
			{
				var index = InputComponentsLookup.Controller;
				if (value)
				{
					var componentPool = GetComponentPool(index);
					var component = componentPool.Count > 0
							? componentPool.Pop()
							: ControllerComponent;

					AddComponent(index, component);
				}
				else
				{
					RemoveComponent(index);
				}
			}
		}
	}
}

//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v2.4.4.0).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class InputMatcher
{
	static JCMG.EntitasRedux.IMatcher<InputEntity> _matcherController;

	public static JCMG.EntitasRedux.IMatcher<InputEntity> Controller
	{
		get
		{
			if (_matcherController == null)
			{
				var matcher = (JCMG.EntitasRedux.Matcher<InputEntity>)JCMG.EntitasRedux.Matcher<InputEntity>.AllOf(InputComponentsLookup.Controller);
				matcher.ComponentNames = InputComponentsLookup.ComponentNames;
				_matcherController = matcher;
			}

			return _matcherController;
		}
	}
}
