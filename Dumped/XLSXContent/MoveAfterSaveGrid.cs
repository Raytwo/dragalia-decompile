using System;
using UnityEngine;

namespace XLSXContent;

[Serializable]
public class MoveAfterSaveGrid : ScriptableObject
{
	[Serializable]
	public class Sheetdata
	{
		public ZoneID zoneID;

		public Vector2Int grid;

		public Vector2Int regrid;
	}

	public Sheetdata[] data;

	public Sheetdata this[int index] => null;
}
