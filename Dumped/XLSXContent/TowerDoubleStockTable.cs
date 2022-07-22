using System;
using UnityEngine;

namespace XLSXContent;

[Serializable]
public class TowerDoubleStockTable : ScriptableObject
{
	[Serializable]
	public class SheetTowerDoubleStock
	{
		public uint ID;

		public TowerTrID[] TrainerID;

		public uint[] PokeID;

		public string BattleBGM;

		public string WinBGM;
	}

	public SheetTowerDoubleStock[] TowerDoubleStock;

	public SheetTowerDoubleStock this[int index] => null;
}
