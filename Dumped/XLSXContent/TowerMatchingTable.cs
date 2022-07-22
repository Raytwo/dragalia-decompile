using System;
using UnityEngine;

namespace XLSXContent;

[Serializable]
public class TowerMatchingTable : ScriptableObject
{
	[Serializable]
	public class SheetTowerMatching
	{
		public uint ID;

		public uint StockIDMin;

		public uint StockIDMax;

		public bool shuffle;
	}

	public SheetTowerMatching[] TowerMatching;

	public SheetTowerMatching this[int index] => null;
}
