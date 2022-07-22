using System;
using UnityEngine;

namespace XLSXContent;

[Serializable]
public class LightStonePosTable : ScriptableObject
{
	[Serializable]
	public class SheetData
	{
		public ZoneID ZoneID;

		public int MinNum;

		public int MaxNum;

		public int MinProbability;

		public int MaxProbability;

		public int Diglettrate;

		public int Dugtriorate;

		public Vector2Int[] Locator;
	}

	public SheetData[] Data;

	public SheetData this[int index] => null;
}
