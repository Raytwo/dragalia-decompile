using System;
using UnityEngine;

namespace XLSXContent;

[Serializable]
public class LightStoneTable : ScriptableObject
{
	[Serializable]
	public class SheetData
	{
		public ZoneID ZoneID;

		public int LightStone;

		public int BonusTime;
	}

	public SheetData[] Data;

	public SheetData this[int index] => null;
}
