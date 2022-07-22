using System.Collections.Generic;
using Pml;
using UnityEngine;

public class Telescope
{
	private static Vector2Int SafariPointOrigin;

	private static Vector2Int[] SafariPoints;

	private const int SafariPointLookCount = 5;

	private List<int> PointIndices;

	private int CurrentIndex;

	private int NextIndex;

	private Vector2Int EventPos;

	public void StartSafari(Vector2Int eventPos)
	{
	}

	public void GetCurrentMons(out MonsNo monsNo, out ushort formNo)
	{
	}

	public void JumpNext()
	{
	}
}
