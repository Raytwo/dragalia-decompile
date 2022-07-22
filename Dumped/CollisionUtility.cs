using UnityEngine;

public class CollisionUtility
{
	private static Collider[] _overlapResults;

	public static Vector3 CollideObstacle(Vector3 position, float radius, Vector3 direction, float distance, out bool jump, out bool isCollided, out float dotAngle, int mask = -1, float threshold = 0.99f)
	{
		return default(Vector3);
	}

	public static bool IsCollideObstacle(Vector3 position, float radius, Vector3 direction, float distance, int mask = -1)
	{
		return default(bool);
	}

	public static Vector3 CollideObstacle(Vector3 position, float radius, Vector3 direction, float distance, out bool jump, out bool isCollided, out float dotAngle, out Vector3 colNormal, int mask = -1, float threshold = 0.99f)
	{
		return default(Vector3);
	}

	public static bool IsOverrapSphere(Transform target, Vector3 offset, float radius, int mask = -1)
	{
		return default(bool);
	}

	public static Collider[] OverrapSphere(Transform target, Vector3 offset, float radius, out int count, int mask = -1)
	{
		return null;
	}

	public static float CollideGround(Vector3 position, float rayHeightOffset, int mask)
	{
		return default(float);
	}

	public static bool IsCollideGround(Vector3 position, float rayHeightOffset, int mask)
	{
		return default(bool);
	}

	public static float OverCollideGround(Vector3 position, float rayHeightOffset, int mask)
	{
		return default(float);
	}

	public static bool IsOverCollideGround(Vector3 position, float rayHeightOffset, int mask)
	{
		return default(bool);
	}
}
