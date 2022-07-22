using UnityEngine;

public static class ComponentExtensions
{
	public static T FindComponent<T>(this Component self, string name) where T : Component
	{
		return null;
	}

	public static GameObject FindDeep(this Component self, string name, bool includeInactive = false)
	{
		return null;
	}
}
