using System.Collections;
using UnityEngine;

public static class ExtensionMethods
{
	public static void ReplaceLayerRecursively(this GameObject self, int source, int destination)
	{
	}

	public static void SetLayerRecursively(this GameObject self, int layer)
	{
	}

	public static T AddComponentIfNecessary<T>(this GameObject self) where T : Component
	{
		return null;
	}

	public static void SetPosition(this Transform self, Vector3 value)
	{
	}

	public static void SetPositionX(this Transform self, float value)
	{
	}

	public static void SetPositionY(this Transform self, float value)
	{
	}

	public static void SetPositionZ(this Transform self, float value)
	{
	}

	public static void SetLocalPosition(this Transform self, Vector3 value)
	{
	}

	public static void SetLocalPositionX(this Transform self, float value)
	{
	}

	public static void SetLocalPositionY(this Transform self, float value)
	{
	}

	public static void SetLocalPositionZ(this Transform self, float value)
	{
	}

	public static void SetRotationEuler(this Transform self, Vector3 value)
	{
	}

	public static void SetRotationXEuler(this Transform self, float value)
	{
	}

	public static void SetRotationYEuler(this Transform self, float value)
	{
	}

	public static void SetRotationZEuler(this Transform self, float value)
	{
	}

	public static void SetLocalRotationEuler(this Transform self, Vector3 value)
	{
	}

	public static void SetLocalRotationXEuler(this Transform self, float value)
	{
	}

	public static void SetLocalRotationYEuler(this Transform self, float value)
	{
	}

	public static void SetLocalRotationZEuler(this Transform self, float value)
	{
	}

	public static void SetLocalScale(this Transform self, Vector3 value)
	{
	}

	public static void SetLocalScaleX(this Transform self, float value)
	{
	}

	public static void SetLocalScaleY(this Transform self, float value)
	{
	}

	public static void SetLocalScaleZ(this Transform self, float value)
	{
	}

	public static T GetComponentThis<T>(this Component self, ref T value) where T : Component
	{
		return null;
	}

	public static T AddComponentIfNecessary<T>(this Component self) where T : Component
	{
		return null;
	}

	public static void SetActive(this Component self, bool value)
	{
	}

	public static bool IsNullOrEmpty(this IList self)
	{
		return default(bool);
	}

	public static bool IsBounds(this IList self, int index)
	{
		return default(bool);
	}
}
