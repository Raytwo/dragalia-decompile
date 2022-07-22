using System.Runtime.InteropServices;
using Dpr.EvScript;
using UnityEngine;

namespace Dpr;

public static class FieldGridCollision
{
	public enum GridCollisionType
	{
		None,
		NoEntry,
		Water,
		Npc
	}

	public enum GridCollisionIgnoreDir
	{
		None,
		Side,
		Vert
	}

	public interface ICheckGridFunc
	{
		GridCollisionType Check(Vector2Int grid);
	}

	public static EvDataManager.EntityParam CheckGridEventMoveEntity(out Vector3 outWorldPos, FieldObjectEntity entity)
	{
		return null;
	}

	public static GridCollisionType CheckGriCollisionMoveEntity(out Vector3 outVelocity, Vector3 worldPosition, Vector3 worldVelocity, float entityRadius, ICheckGridFunc checkGridFunc, GridCollisionIgnoreDir ignoreDir = GridCollisionIgnoreDir.None)
	{
		return default(GridCollisionType);
	}

	public static GridCollisionType CheckGriCollisionMoveEntity(out Vector3 outVelocity, out Vector3 outHitNormal, out float outHitAngle, Vector3 worldPosition, Vector3 worldVelocity, float entityRadius, ICheckGridFunc checkGridFunc, GridCollisionIgnoreDir ignoreDir = GridCollisionIgnoreDir.None)
	{
		return default(GridCollisionType);
	}

	private static float Vector2Cross([In] ref Vector2 lhs, [In] ref Vector2 rhs)
	{
		return default(float);
	}

	private static Vector2 Vector2Project([In] ref Vector2 vector, [In] ref Vector2 normal)
	{
		return default(Vector2);
	}

	private static void PointPerpendicularLineOnLineSegment(out Vector2 outPoint, out float outTime, Vector2 point, Vector2 start, Vector2 end)
	{
	}

	private static bool CheckCirclePoint(out float outTime, Vector2 centerA, float radiusA, Vector2 velocityA, Vector2 pointB)
	{
		return default(bool);
	}

	private static bool CheckCircleLineSegment(out float outTime, Vector2 centerA, float radiusA, Vector2 velocityA, Vector2 startB, Vector2 endB)
	{
		return default(bool);
	}
}
