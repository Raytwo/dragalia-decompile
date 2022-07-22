using System;
using UnityEngine;

namespace XLSXContent;

[Serializable]
public class UgFatherPos : ScriptableObject
{
	[Serializable]
	public class SheetPos
	{
		public int ID;

		public int ugfatherCategory;

		public ZoneID ZoneID;

		public Vector2Int Locator;
	}

	public SheetPos[] Pos;

	public SheetPos this[int index] => null;
}
