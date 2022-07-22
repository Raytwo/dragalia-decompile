using System.Runtime.InteropServices;
using UnityEngine;
using XLSXContent;

namespace Dpr.RouteSearch;

public static class FieldObjectRoute
{
	private static readonly int OneBlockGridCount;

	private static readonly Vector2Int[] MoveVec;

	private static readonly float StraightCost;

	private static readonly float DiagonalCost;

	private static readonly int DefaultNodeWidth;

	private static readonly int DefaultNodeHeight;

	public static Vector3[] Search(ObjectType characterType, [In] ref Vector3 start, [In] ref Vector3 goal, AttributeMatrix matrix)
	{
		return null;
	}

	public static Vector3[] Search(ObjectType characterType, [In] ref Vector3 start, [In] ref Vector3 goal, AttributeMatrix matrix, NodeData nodeData)
	{
		return null;
	}

	public static NodeData CreateNodeData(int width, int height)
	{
		return null;
	}

	private static Vector3[] SearchCore(ObjectType characterType, [In] ref Vector3 startPos, [In] ref Vector3 goalPos, AttributeMatrix matrix, NodeData nodeData)
	{
		return null;
	}

	private static void OpenNodes(Node currentNode, AttributeMatrix matrix, NodeData nodeData)
	{
	}

	private static void SetupAttribute(Node node, AttributeMatrix matrix, NodeData nodeData)
	{
	}

	private static Node GetBestScoreOpenNode(NodeData nodeData)
	{
		return null;
	}

	private static Vector3[] BuildRoute(Node startNode, Node goalNode, NodeData nodeData)
	{
		return null;
	}
}
