using UnityEngine;

namespace SmartPoint.Components;

public static class TransformExtensions
{
	public static void Track(this Transform transform, float x, float y)
	{
	}

	public static void Dolly(this Transform transform, float delta)
	{
	}

	public static void Pan(this Transform transform, float yaw, float pitch)
	{
	}

	public static void Thumble(this Transform transform, Transform target, float yaw, float pitch)
	{
	}

	public static void Thumble(this Transform transform, float focalDistance, float yaw, float pitch)
	{
	}

	private static void Multiply(ref Quaternion inoutQ, ref Quaternion Q)
	{
	}

	private static void RotationAxis(out Quaternion outQ, ref Vector3 V, float Angle)
	{
	}

	private static void RotateY(ref Quaternion inoutQ, float Angle)
	{
	}
}
