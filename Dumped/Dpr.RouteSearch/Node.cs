using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Dpr.RouteSearch;

public class Node
{
	private enum EStatus
	{
		Untouch,
		Open,
		Close
	}

	public NodeAttribute Attribute;

	public Vector2Int FromId;

	public float MoveCost;

	public int Depth;

	private EStatus status;

	public Vector2Int Id
	{
		[CompilerGenerated]
		get
		{
			return default(Vector2Int);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public float HeuristicCost
	{
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public bool IsOpen => default(bool);

	public bool IsClose => default(bool);

	public bool IsUntouch => default(bool);

	public float Score => default(float);

	public Node([In] ref Vector2Int id)
	{
	}

	public void Reset()
	{
	}

	public void SetGoal([In] ref Vector2Int goalId)
	{
	}

	public void Open([In] ref Vector2Int fromId, float moveCost, int depth)
	{
	}

	public void Colse()
	{
	}

	public static float CalcScore(float moveCost, float heuristicCost)
	{
		return default(float);
	}
}
