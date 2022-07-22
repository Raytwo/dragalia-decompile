using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Dpr.RouteSearch;

public class NodeData
{
	public int[] AttributeCache;

	public Vector2Int[] AddCantEntryObjectsPositions;

	public Node[] Nodes
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public int Width
	{
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public int Height
	{
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public Vector2Int GridOrigin
	{
		[CompilerGenerated]
		get
		{
			return default(Vector2Int);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public float PosY
	{
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public ObjectType CharacterType
	{
		[CompilerGenerated]
		get
		{
			return default(ObjectType);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public void Initialize(int width, int height)
	{
	}

	public Node GetNode(Vector2Int id)
	{
		return null;
	}

	public Node GetNode(int x, int y)
	{
		return null;
	}

	public bool CheckValidId(Vector2Int id)
	{
		return default(bool);
	}

	public bool CheckValidId(int x, int y)
	{
		return default(bool);
	}

	public void SetupNodesAndSetGoal([In] ref Vector2Int goal)
	{
	}
}
