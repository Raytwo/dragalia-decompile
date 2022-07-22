using UnityEngine;

public static class GameObjectExtensions
{
	public static T FindComponent<T>(this GameObject self, string name) where T : Component
	{
		return null;
	}

	public static GameObject FindDeep(this GameObject self, string name, bool includeInactive = false)
	{
		return null;
	}

	public static void DeleteAllChild(this GameObject self)
	{
	}

	public static T GetComponentNullable<T>(this GameObject go) where T : class
	{
		return null;
	}
}
