using System;
using UnityEngine;

namespace XLSXContent;

[Serializable]
public class TowerSingleStockTable : ScriptableObject
{
	[Serializable]
	public class SheetTowerSingleStock
	{
		public uint ID;

		public TowerTrID TrainerID;

		public uint[] PokeID;

		public string BattleBGM;

		public string WinBGM;
	}

	public SheetTowerSingleStock[] TowerSingleStock;

	public SheetTowerSingleStock this[int index] => null;
}
