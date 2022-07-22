using System;
using UnityEngine;

namespace XLSXContent;

[Serializable]
public class UgJumpPos : ScriptableObject
{
	[Serializable]
	public class SheetData
	{
		public int ID;

		public int MapGroupID;

		public ZoneID ZoneID;

		public Vector2 Locators;
	}

	public SheetData[] Data;

	public SheetData this[int index] => null;
}
